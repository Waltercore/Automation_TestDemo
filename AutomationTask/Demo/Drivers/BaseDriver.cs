using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Framework.Drivers
{
    public class BaseDriver
    {
        public static IWebDriver driver { get; set; }

        public static IWebDriver SeleniumInitialization(string browser)
        {
            if (browser == "Chrome")
            {                              
                ChromeOptions chromeOptions = new ChromeOptions();                
                chromeOptions.AddArguments(new List<string>() { "start-maximized", "--incognito" });
                driver = new ChromeDriver(chromeOptions);
            }
            else if (browser == "Edge")
            {

            }
            else if (browser == "Firefox")
            {

            }
            return driver;
        }
        public static void Quit()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
