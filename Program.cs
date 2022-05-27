using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string applicationSettingsValue = Properties.Settings.Default.keyName;
            string appSettingsValue = ConfigurationManager.AppSettings["keyName"];
            Console.WriteLine("applicationSettings keyName = "+ applicationSettingsValue);
            Console.WriteLine("appSettings keyName = "+ appSettingsValue);
            Console.ReadKey();
        }
    }
}
