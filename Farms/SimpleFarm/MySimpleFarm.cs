using FarmProject.FarmDomain;

namespace FarmProject.Farms.SimpleFarm
{
    public class MySimpleFarm : IFarm
    {
        public int[] AgesOfAnimals = new int[10];
        public int[] NumberOfLives = new int[10];
        public string[] NameOfAnimals = new string[10];
        public AnimalType[] AnimalTypes = new AnimalType[10];


        public int CurrentAnimalIndex = 0;

        public void AddAnimal(AnimalType animalType)
        {
            //TODO 
            // If animalType is Horse, then add number of races won to a new arraay (e.g. RacesWon[])



            //Assign anymal type
            AnimalTypes[CurrentAnimalIndex] = animalType;

            //Generate Age
            var animalAge = new Random().Next(0, 13);

            AgesOfAnimals[CurrentAnimalIndex] = animalAge;

            //Generate Cat Name

            if (animalType == AnimalType.Cat)
            {
                var animalNameIndex = new Random().Next(0, CatNames.Length);
                var animalname = CatNames[animalNameIndex];
                NameOfAnimals[CurrentAnimalIndex] = animalname;

            }

            if (animalType == AnimalType.Dog)
            {
                var animalNameIndex = new Random().Next(0, DogNames.Length);
                var animalname = DogNames[animalNameIndex];
                NameOfAnimals[CurrentAnimalIndex] = animalname;

            }


            //Assign nr lives
            if (animalType == AnimalType.Cat)
            {
                NumberOfLives[CurrentAnimalIndex] = new Random().Next(0, 9);
            }
            
            //Move to next animal
            CurrentAnimalIndex = CurrentAnimalIndex + 1;
        }

        public List<string> GetAnimalDetails()
        {
            //TODO 
            // If animalType is Horse, then animalInfo should be similar to "Neigh, I am Horsy and I have won 3 races"

            var infoList = new List<string>();

            for(var i = 0; i < CurrentAnimalIndex; i++)
            {
                var animalInfo = "";
                if (AnimalTypes[i] == AnimalType.Cat)
                {

                    animalInfo += "Meow ";

                }
                if (AnimalTypes[i] == AnimalType.Dog)
                {

                    animalInfo += "Bark ";

                }

                animalInfo = animalInfo + ", My name is " + NameOfAnimals[i];

                animalInfo = animalInfo + " " + "and I am " + AgesOfAnimals[i];

                if (AnimalTypes[i] == AnimalType.Cat)
                {
                    animalInfo = animalInfo + " and I have " + NumberOfLives[i] + " lives";
                }

                infoList.Add(animalInfo);               
            }

            return infoList;            
        }


        public string[] CatNames = new string[]
        {
            "MEW",
            "Plim",
            "Plom"
        };
        public string[] DogNames = new string[]
{
            "Yuki",
            "Bobby",
            "Jerry",
            "Baxter"
};
    }
}