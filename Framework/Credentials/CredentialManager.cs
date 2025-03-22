using Microsoft.Extensions.Configuration;


namespace SwagLabTestBDDFramework.Framework.Credentials
{
    public class CredentialManager
    {
        private static IConfiguration _configuration;

        static CredentialManager()
        {
            try
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                    AddJsonFile(Path.Combine("Framework","Credentials", "AppConfig.json"), optional: false, reloadOnChange: true);
                _configuration = builder.Build();
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        public static string GetBaseUrl()
        {
            var BaseUrl = _configuration.GetSection("TestSettings:BaseUrl").Value;
            if (string.IsNullOrEmpty(BaseUrl))
            {
                throw new InvalidOperationException("BaseUrl is not Configured");
            }
            return BaseUrl;

        }

        public static string GetEndpoint()
        {
            var endPoint = _configuration.GetSection("ApiTesting:Endpoint").Value;
            if (string.IsNullOrEmpty(endPoint))
            {
                throw new InvalidOperationException("Endpoint is not Configured");

            }
            return endPoint;
        }


        public static (string Username, string Password) GetCredentials()
        {
            var username = _configuration.GetSection("TestSettings:Username").Value;
            var password = _configuration.GetSection("TestSettings:Password").Value;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new InvalidOperationException("Credentials are not Configured");
            }

            return (username, password);
        }

    }
}
