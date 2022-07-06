using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;
        public static void setDriver()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless"); //leidzia testus neatidarius chrome
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        //public static void takeScreenshot()
        //{
        //    string screenshotsPath = $"{AppDomain.CurrentDomain.BaseDirectory}/screenshots";
        //    string screenshotsName = $"{screenshotsPath}/src-{Guid.NewGuid()}.png";

        //    Directory.CreateDirectory(screenshotsPath);

        //    Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
        //    screenshot.SaveAsFile(screenshotsName, ScreenshotImageFormat.Png);
        //}

        public static void closeDriver()
        {
            driver.Quit();
        }
    }
}
