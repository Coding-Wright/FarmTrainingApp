using FarmProject.FarmDomain;
using FarmProject.Farms.DummyFarm;
using Microsoft.Extensions.DependencyInjection;

namespace FarmProject.FarmUI
{
    public partial class Form1 : Form
    {
        private IFarm _farm;
        private IServiceCollection _services;
        public static string FarmVersion = "No Version";

        public Form1(IServiceCollection services)
        {
            _services = services;
            _farm = _services.BuildServiceProvider().GetService<IFarm>();
            InitializeComponent();

            FarmVersionLbl.Text = FarmVersion;
        }

        private void TalkBtn_Click(object sender, EventArgs e)
        {
            if (_farm == null)
            {
                return;
            }

            var animalDetails = _farm.GetAnimalDetails();

            foreach (var animalDetail in animalDetails)
            {
                AnimalDetailsList.Items.Add(animalDetail);
            }
        }

        private void AddDogBtn_Click(object sender, EventArgs e)
        {
            _farm.AddAnimal(AnimalType.Dog);
        }

        private void AddCatBtn_Click(object sender, EventArgs e)
        {
            _farm.AddAnimal(AnimalType.Cat);
        }

        private void AddHorseButton_Click(object sender, EventArgs e)
        {
            _farm.AddAnimal(AnimalType.Horse);
        }

        private void farmSelector_ValueChanged(object sender, EventArgs e)
        {
            Program.ChangeFarm(farmSelector.Value);
            _farm = _services.BuildServiceProvider().GetService<IFarm>();
            FarmVersionLbl.Text = FarmVersion;
        }
    }
}