using OpenQA.Selenium;
using SwagLabTestBDDFramework.Framework.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabTestBDDFramework.Framework.Screenshots
{
    public class TakeScreenshot
    {
        public static string CaptureScreenShot()
        {
            ITakesScreenshot sc = (ITakesScreenshot) WebFactory._driver.Value;
            var image = sc.GetScreenshot();
            return image.AsBase64EncodedString;

        }
    }
}
