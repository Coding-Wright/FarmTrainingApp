using FarmProject.FarmDomain;

namespace FarmProject.Farms.SimpleFarm
{
    public class MySimpleFarm : IFarm
    {
        public int[] AgesOfAnimals = new int[10];
        public string[] NameOfAnimals = new string[10];

        public int CurrentAnimalIndex = 0;

        public void AddAnimal(AnimalType animalType)
        {
            //Generate Age
            var animalAge = new Random().Next(0, 13);

            AgesOfAnimals[CurrentAnimalIndex] = animalAge;


            //Generate Name
            var animalNameIndex = new Random().Next(0, AnimalNames.Length);
            var animalname = AnimalNames[animalNameIndex];

            NameOfAnimals[CurrentAnimalIndex] = animalname;

            
            //Move to next animal
            CurrentAnimalIndex = CurrentAnimalIndex + 1;
        }

        public List<string> GetAnimalDetails()
        {
            var infoList = new List<string>();

            for(var i = 0; i < CurrentAnimalIndex; i++)
            {
                var animalInfo = "";
                animalInfo = animalInfo + AgesOfAnimals[i];

                animalInfo = animalInfo + " " + NameOfAnimals[i];

                infoList.Add(animalInfo);               
            }

            return infoList;            
        }


        public string[] AnimalNames = new string[]
        {
            "Name1",
            "MEW",
            "Bobby",
            "Plim",
            "Plom"
        };
    }
}