using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;
    private string mode;
    private double totalMinedOre;
    private double totalEnergyStored;

    public DraftManager()
    {
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.mode = "Full";
        this.totalMinedOre = 0d;
        this.totalEnergyStored = 0d;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvester = harvesterFactory.CreateHarvester(arguments);
            var type = arguments[0];
            var id = arguments[1];
            harvesters.Add(harvester);
            var result = $"Successfully registered {harvester.Type} Harvester - {harvester.Id}";

            return result;
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        var provider = providerFactory.CreateProvider(arguments);
        var type = arguments[0];
        var id = arguments[1];
        var result = $"Successfully registered {provider.Type} Provider - {provider.Id}";

        return result;
    }

    public string Day()
    {
        
    }

    public string Mode(List<string> arguments)
    {
        var newMode = arguments[0];
        this.mode = newMode;
        var result = $"Successfully changed working mode to {newMode} Mode";

        return result;
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        Unit unit = (Unit) harvesters.FirstOrDefault(h => h.Id == id) ?? providers.FirstOrDefault(p => p.Id == id);

        if (unit == null)
        {
            return $"No element found with id - {id}";
        }

        return unit.ToString();
    }

    public string ShutDown()
    {
        var builder = new StringBuilder();
        builder.AppendLine("System Shutdown")
            .AppendLine($"Total Energy Stored: {this.totalEnergyStored}")
            .AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return builder.ToString();
    }
}

