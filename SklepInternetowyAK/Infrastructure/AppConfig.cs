using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SklepInternetowyAK.Infrastructure
{
    public class AppConfig
    {
        public static string PostersPath = ConfigurationManager.AppSettings["Posters"];

        public  static string PostersPath1
        {
            get => PostersPath;
            set => PostersPath = value;
        }
    }
}