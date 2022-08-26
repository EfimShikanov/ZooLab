using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLib.Animals.Mammals;

namespace ZooLib.Animals.Reptiles
{
    public class Snake : Reptile
    {
        private static readonly string[] _friendlyAnimals = new string[]
        {
            "Snake"
        };

        public override int RequiredSpaceSqFt { get; } = 2;
        public override string[] FavouriteFood { get; } = new string[] { "Meat" };
        public override bool IsFriendlyWith(Animal animal)
        {
            return _friendlyAnimals.Contains(animal.GetType().Name);
        }
    }
}
