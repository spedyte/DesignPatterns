using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace Singleton.Configuracion
{
    public class Configuracion
    {
        private static Configuracion config;

        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string DateFormat { get; set; }
        public string AppCurrencyDate { get; set; }

        private Configuracion()
        {
            try
            {
                // To use xml doc type  
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Path.Combine(Environment.CurrentDirectory, "./Resources/configuracion.xml")); // Specify your file name  
                XmlNode myNodes = xmlDoc.SelectSingleNode("/root"); // You can specify from which node you want to start reading  
                var nodoConfig = myNodes["Profile"];
                Console.WriteLine("First Name Is : {0}", myNodes["Profile"].InnerText); // To print value of First name  
                AppName = nodoConfig.GetAttribute("Name");
                AppVersion = nodoConfig.GetAttribute("AppVersion");
                DateFormat = nodoConfig.GetAttribute("DateFormat"); 
                 AppCurrencyDate = nodoConfig.GetAttribute("CurrencyDate");

            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public static Configuracion getInstance()
        {
            if (config == null)
                config = new Configuracion();
            return config;
        }
    }
}
