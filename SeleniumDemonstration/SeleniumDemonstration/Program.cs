using System;

using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaring variables for web drivers */
            IWebDriver driver = new ChromeDriver(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            WebDriverWait wait;

          
                /* Assigning timeout */
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                /* Navigating to google.co.in */
                driver.Navigate().GoToUrl(@"https://www.google.co.in");

                wait.Until<bool>((d) => { return d.Title.Contains("Google"); });
                IWebElement searchbox = driver.FindElement(By.Name("q"));
                searchbox.Click();

                /* Search for "Selenium C#" */
                searchbox.SendKeys("Selenium C#");
                IWebElement btnSearch = driver.FindElement(By.Name("btnK"));
                btnSearch.Submit();

                Thread.Sleep(120000);
            
        }
    }
}
