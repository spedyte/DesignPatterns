using Observer.abstractas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Observer.concretas.observables
{
    public class ConfigurationManager:AbstractObservable
    {
        private static ConfigurationManager configurationManager;

        private CultureInfo cultureInfo;
        private NumberFormatInfo numberformat;

        private ConfigurationManager()
        {

        }
              

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ConfigurationManager getInstance()
        {
            if (configurationManager == null)
            {
                configurationManager = new ConfigurationManager();
            }
            return configurationManager;
        }


        public CultureInfo CultureInfo
        { 
            get => cultureInfo;
            set 
            {
                cultureInfo = value;
                notifyAll("cultureInfo", this);
            } 
        }
        public NumberFormatInfo Numberformat 
        { 
            get => numberformat; 
            set { 
                numberformat = value; 
                notifyAll("numberforamt", this); 
            } 
        }
    }
}
