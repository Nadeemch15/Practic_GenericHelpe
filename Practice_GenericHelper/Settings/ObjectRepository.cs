using OpenQA.Selenium;
using Practice_GenericHelper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_GenericHelper.Settings
{
    public class ObjectRepository
    {
        public static IWebDriver Driver { get; set; }
        public static IConfig Config { get; set; }
    }
}
