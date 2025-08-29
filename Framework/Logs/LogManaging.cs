using log4net.Config;
using log4net;
using System.Reflection;
using System.IO;

namespace SwagLabTestBDDFramework.Framework.Logs
{
     public  class LogManaging
     {
        private static readonly ILog _log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void InitializeLogging()
        {
            

            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var log4NetConfig = Path.Combine(baseDir, "Framework", "Credentials", "Log4net.config");

            
            var logFilePath = Path.Combine(baseDir, "Framework", "Logs");
            if (!Directory.Exists(logFilePath))
            {
                Directory.CreateDirectory(logFilePath);
            }

            if (File.Exists(log4NetConfig))
            {
                XmlConfigurator.ConfigureAndWatch(new FileInfo(log4NetConfig));
            }

            _log.Info("Logging has been initialized.");
        
        }

        
        public static ILog GetLogger()
        {
            var callingType = MethodBase.GetCurrentMethod().DeclaringType;
            return log4net.LogManager.GetLogger(callingType);
        }
    }
}


