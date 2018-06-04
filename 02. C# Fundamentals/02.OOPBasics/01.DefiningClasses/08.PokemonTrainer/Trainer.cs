using System.Collections.Generic;

public class Trainer
{
    public Trainer(string name, ICollection<Pokemon> pokemons)
    {
        this.Name = name;
        this.NumberOfBadges = 0;
        this.Pokemons = new List<Pokemon>();
    }

    public string Name { get; set; }

    public int NumberOfBadges { get; set; }

    public ICollection<Pokemon> Pokemons { get; set; }


    public override string ToString()
    {
        return $"{Name} {NumberOfBadges} {this.Pokemons.Count}";
    }
}

