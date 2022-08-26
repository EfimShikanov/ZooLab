using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLib.Animals.Birds
{
    public class Penguin : Bird
    {
        private static readonly string[] _friendlyAnimals = new string[] {
            "Penguin"
        };

        public override int RequiredSpaceSqFt { get; } = 10;
        public override string[] FavouriteFood { get; } = new string[] { "Meat" };
        public override bool IsFriendlyWith(Animal animal)
        {
            return _friendlyAnimals.Contains(animal.GetType().Name);
        }
    }
}
