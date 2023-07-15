namespace FarmProject.FarmDomain
{
    public interface IFarm
    {
        void AddAnimal(AnimalType animalType);

        List<string> GetAnimalDetails();
    }
}