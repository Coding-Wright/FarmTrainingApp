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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            var services = new ServiceCollection();

            var farmVersion = ConfigurationManager.AppSettings["FarmVersion"];

            if (farmVersion == null || farmVersion.Trim().ToLower() == "1")
            {
                services.AddSingleton(typeof(IFarm), new MyDummyFarm());
                Form1.FarmVersion = "Dummy Farm";
            } 
            else if(farmVersion.Trim().ToLower() == "2")
            {
                services.AddSingleton(typeof(IFarm), new MySimpleFarm());
                Form1.FarmVersion = "Simple Farm";
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(services));
        }
    }
}