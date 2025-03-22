using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabTestBDDFramework.Framework.Reports
{ 
    

    public class ReportManager
    {
        private  static ExtentReports _extentReports;
        private  static ExtentSparkReporter _sparkReporter;

        public static ExtentReports GetReports()
        {
            
            if (_extentReports == null)
            {
                var reportDir = @"C:\Users\sumanta_swain\source\repos\SwagLabTestBDDFramework\Framework\Reports";

                if (!Directory.Exists(reportDir))
                {
                    Directory.CreateDirectory(reportDir);
                }

                var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                var reportPath = Path.Combine(reportDir, $"ExtentReport_{timestamp}.html");

                _sparkReporter = new ExtentSparkReporter(reportPath);
                _extentReports = new ExtentReports();
                _extentReports.AttachReporter(_sparkReporter);
            }
            return _extentReports;
        }

        public static void FlushReports()
        {
            _extentReports?.Flush();
        }
    }
}
