using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


namespace SwagLabTestBDDFramework.Framework.Drivers
{
    public static class WebFactory
    {
        public static readonly ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>();

        public static IWebDriver CreateDriver(string browserType)
        {

            switch (browserType.ToLower())
            {

                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--disable-popup-blocking");
                    options.AddArguments("--headless");
                    _driver.Value = new ChromeDriver(options);
                    break;

                case "edge":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    edgeOptions.AddArgument("--disable-popup-blocking");
                    edgeOptions.AddArguments("--headless");
                    _driver.Value = new EdgeDriver(edgeOptions);
                    break;

                case "firefox":
                    FirefoxOptions fxOptions = new FirefoxOptions();
                    fxOptions.AddArgument("--disable-popup-blocking");
                    fxOptions.AddArguments("--headless");
                    _driver.Value = new FirefoxDriver();
                    break;

                default:
                    throw new ArgumentException();

            }

            _driver.Value.Manage().Window.Maximize();


            return _driver.Value;
        }
    }
}
