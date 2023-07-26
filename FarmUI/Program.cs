using System.Collections.Specialized;
using System.Configuration;
using FarmProject.FarmDomain;
using FarmProject.Farms.DummyFarm;
using FarmProject.Farms.SimpleFarm;
using Microsoft.Extensions.DependencyInjection;


namespace FarmProject.FarmUI
{
    internal static class Program
    {
        private static ServiceCollection _services = new ServiceCollection();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            var farmVersion = ConfigurationManager.AppSettings["FarmVersion"];

            var farmVersionValue = 1m;
            if(decimal.TryParse(farmVersion, out farmVersionValue))
            {
                _services.AddSingleton(typeof(IFarm), GetFarm(farmVersionValue));
                Form1.FarmVersion = GetFarmName(farmVersionValue);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(_services));
        }

        public static void ChangeFarm(decimal farmVersion)
        {
            _services.AddSingleton(typeof(IFarm), GetFarm(farmVersion));
            Form1.FarmVersion = GetFarmName(farmVersion);
        }

        private static IFarm GetFarm(decimal farmVersion)
        {
            if (farmVersion == 1m)
            {
                return new MyDummyFarm();
            }
            else if(farmVersion == 2m)
            {
                return new MySimpleFarm();
            }

            return new MyDummyFarm();
        }

        private static string GetFarmName(decimal farmVersion)
        {
            if (farmVersion == 1m)
            {
                return "Dummy Farm";
            }
            else if (farmVersion == 2m)
            {
                return "Simple Farm";
            }

            return "Dummy Farm";
        }
    }
}