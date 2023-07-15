using FarmProject.FarmDomain;

namespace FarmProject.Farms.DummyFarm
{
    public class MyDummyFarm : IFarm
    {
        public void AddAnimal(AnimalType animalType)
        {
            return;
        }

        public List<string> GetAnimalDetails()
        {
            return new List<string>()
            {
                "BARK! I'm Fluffers and I'm 9 years old!",
                "MEOW! I'm Whiskers, 7 years old and I have 9 lives",
                "NEIGH! I'm Horsey and I'm 3 years old. I have won 4 races"
            };
        }
    }
}