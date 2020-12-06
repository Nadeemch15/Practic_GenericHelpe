using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice_GenericHelper.ComponentHelper;
using Practice_GenericHelper.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_GenericHelper.TestScript
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            // ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigationToUrl(ObjectRepository.Config.GetWebsite());

        }
    }
}
