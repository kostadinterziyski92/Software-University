using System;


public class Ferrari : ICar
{
    private string model;
    private string driver;

    public Ferrari(string model, string driver)
    {
        this.Model = model;
        this.Driver = driver;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Driver
    {
        get { return driver; }
        set { driver = value; }
    }

    public string PushBrakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }
}

