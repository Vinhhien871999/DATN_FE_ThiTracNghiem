using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FE_ThiTracNghiem.Commons
{
    public class CommonVariable
    {
        internal static string baseAddress { get; set; }

        public static void loadConfigBase()
        {
            string jsonString = "";
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory.ToString() + "config.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            SystemParam sys = new SystemParam();
            sys = JsonConvert.DeserializeObject<SystemParam>(jsonString);

            baseAddress = sys.Address;

        }
    }
}