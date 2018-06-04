using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.PokemonTrainer
{
    class StartUp
    {
        static void Main()
        {
            var trainers = new List<Trainer>();

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var trainerArgs = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                var trainerName = trainerArgs[0];
                var pokemonName = trainerArgs[1];
                var pokemonElement = trainerArgs[2];
                var pokemonHealth = int.Parse(trainerArgs[3]);

                if (!trainers.Any(t=>t.Name == trainerName))
                {
                    var newTrainer = new Trainer(trainerName, new List<Pokemon>());
                    trainers.Add(newTrainer);

                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    var currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                    trainer.Pokemons.Add(currentPokemon);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p=>p.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                }
            }

            trainers
                .OrderByDescending(t=>t.NumberOfBadges)
                .ToList()
                .ForEach(t=> Console.WriteLine(t));
        }
    }
}
