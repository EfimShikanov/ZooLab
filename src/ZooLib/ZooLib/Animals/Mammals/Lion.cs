using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLib.Animals.Mammals
{
    public class Lion : Mammal
    {
        private static readonly string[] _friendlyAnimals = new string[] 
        {
            "Lion"
        };

        public override int RequiredSpaceSqFt { get; } = 1000;
        public override string[] FavouriteFood { get; } = new string[] { "Meat" };
        public override bool IsFriendlyWith(Animal animal)
        {
            return _friendlyAnimals.Contains(animal.GetType().Name);
        }
    }
}
