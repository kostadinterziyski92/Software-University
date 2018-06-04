using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class RaceTower
{
    private const string CrashReason = "Crashed";

    private Track track;
    private IList<Driver> racingDrivers;
    private Stack<Driver> failedDrivers;

    public RaceTower()
    {
        this.racingDrivers = new List<Driver>();
        this.failedDrivers = new Stack<Driver>();
    }

    public bool IsRaceOver => this.track.CurrentLap == this.track.LapsNumber;

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.track = new Track(lapsNumber, trackLength);
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            var drivertype = commandArgs[0];
            var driverName = commandArgs[1];

            var hp = int.Parse(commandArgs[2]);
            var fuelAmount = double.Parse(commandArgs[3]);

            string[] tyreArgs = commandArgs.Skip(4).ToArray();

            Tyre tyre = this.CreateTyre(tyreArgs);
            Car car = new Car(hp, fuelAmount, tyre);
            Driver driver = this.CreateDriver(drivertype, driverName, car);

            racingDrivers.Add(driver);
        }
        catch 
        {}

    }

    private Driver CreateDriver(string drivertype, string driverName, Car car)
    {
        Driver driver = null;

        if (drivertype == "Aggressive")
        {
            driver = new AggressiveDriver(driverName, car);
            return driver;
        }
        else if (drivertype == "Endurance")
        {
            driver = new EnduranceDriver(driverName, car);
            return driver;
        }

        throw new ArgumentException(OutputMessages.InvalidDriverType);
    }

    private Tyre CreateTyre(string[] tyreArgs)
    {
        var type = tyreArgs[0];
        var hardness = double.Parse(tyreArgs[1]);

        Tyre tyre = null;

        if (type == "Hard")
        {
            tyre = new HardTyre(hardness);
            return tyre;
        }
        else if (type == "Ultrasoft")
        {
            var grip = double.Parse(tyreArgs[2]);
            tyre = new UltrasoftTyre(hardness, grip);
            return tyre;
        }
            throw new ArgumentException(OutputMessages.InvalidTyreType);
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var boxReason = commandArgs[0];
        var driverName = commandArgs[1];

        Driver driver = this.racingDrivers
            .FirstOrDefault(d => d.Name == driverName);

        string[] methodArgs = commandArgs.Skip(2).ToArray();

        if (boxReason == "Refuel")
        {
            driver.Refuel(methodArgs);
        }
        else if (boxReason == "ChangeTyres")
        {
            Tyre tyre = CreateTyre(methodArgs);
            driver.ChangeTyres(tyre);
        }
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        StringBuilder builder = new StringBuilder();
        int numberOfLaps = int.Parse(commandArgs[0]);

        if (numberOfLaps > this.track.LapsNumber - this.track.CurrentLap)
        {
            try
            {
                throw new ArgumentException(string.Format(OutputMessages.InvalidLaps, this.track.CurrentLap));

            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        for (int lap = 0; lap < numberOfLaps; lap++)
        {
            for (int index = 0; index < this.racingDrivers.Count; index++)
            {
                Driver driver = racingDrivers[index];

                try
                {
                    driver.CompleteLap(this.track.TrackLength);

                }
                catch (ArgumentException e)
                {
                    driver.Fail(e.Message);
                    this.failedDrivers.Push(driver);
                    this.racingDrivers.RemoveAt(index);
                    index--;
                }

                this.track.CurrentLap++;

                var orderedDrivers = this.racingDrivers
                    .OrderByDescending(d => d.TotalTime)
                    .ToList();

                for (int i = 0; i < orderedDrivers.Count - 1; i++)
                {
                    Driver overtakingDriver = orderedDrivers[i];
                    Driver targetDriver = orderedDrivers[i + 1];

                    bool overtakeHappened = this.TryOvertake(overtakingDriver, targetDriver);

                    if (overtakeHappened)
                    {
                        index++;
                        builder.AppendLine(string.Format(OutputMessages.OvertakeMessage, overtakingDriver.Name,
                            targetDriver.Name));
                    }
                    else
                    {
                        if (!overtakingDriver.IsRacing)
                        {
                            this.failedDrivers.Push(overtakingDriver);
                            this.racingDrivers.Remove(overtakingDriver);
                        }
                    }
                }
            }
        }

        if (this.track.CurrentLap == this.track.LapsNumber)
        {
            Driver winner = this.racingDrivers.OrderBy(d => d.TotalTime).First();
            builder.AppendLine(string.Format(OutputMessages.WinnerMessage, winner.Name, winner.TotalTime));
        }

        string result = builder.ToString().TrimEnd();
        return result;
    }

    private bool TryOvertake(Driver overtakingDriver, Driver targetDriver)
    {
        double timeDiff = overtakingDriver.TotalTime - targetDriver.TotalTime;

        
            bool aggressiveDriver = overtakingDriver is AggressiveDriver &&
                                    overtakingDriver.Car.Tyre is UltrasoftTyre;
            bool enduranceDriver = overtakingDriver is EnduranceDriver &&
                                   overtakingDriver.Car.Tyre is HardTyre;
            bool crash = (aggressiveDriver && this.track.Weather == Weather.Foggy) ||
                         (enduranceDriver && this.track.Weather == Weather.Rainy);
            if ((aggressiveDriver || enduranceDriver) && timeDiff <= 3)
            {
                if (crash)
                {
                    overtakingDriver.Fail(CrashReason);
                    return false;
                }

                overtakingDriver.TotalTime -= 3;
                targetDriver.TotalTime += 3;
                return true;
            }
        
        else if (timeDiff <= 2)
        {
            overtakingDriver.TotalTime -= 2;
            targetDriver.TotalTime += 2;
            return true;
        }

        return false;
    }

    public string GetLeaderboard()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Lap {this.track.CurrentLap}/{this.track.LapsNumber}");

        IEnumerable<Driver> leaderBoardDrivers = this.racingDrivers
            .OrderBy(d => d.TotalTime)
            .Concat(this.failedDrivers);

        int position = 1;

        foreach (Driver driver in leaderBoardDrivers)
        {
            builder.AppendLine($"{position} {driver.ToString().TrimEnd()}");
            position++;
        }

        return builder.ToString().TrimEnd();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        string weatherType = commandArgs[0];
        bool validWeather = Enum.TryParse(typeof(Weather), weatherType, out object weatherObj);

        if (!validWeather)
        {
            throw new ArgumentException(OutputMessages.InvalidWeatherType);
        }
        Weather weather = (Weather) weatherObj;
        this.track.Weather = weather;
    }
}

