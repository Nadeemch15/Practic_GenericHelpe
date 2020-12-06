using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Practice_GenericHelper.BaseClasses;
using Practice_GenericHelper.ComponentHelper;
using Practice_GenericHelper.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_GenericHelper.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigationToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("search_query_top"));
            //element.SendKeys("summer dress");
            //TextBoxHelper.TypeInTextBox(By.Id("search_query_top"), "summer dress");
            //ButtonHelper.ClickButton(By.Name("submit_search"));
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            LinkHelper.ClickLink(By.LinkText("Women"));

        }
    }
}
