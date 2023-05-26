using Microsoft.Extensions.Configuration;

namespace ETicaretApp.Persistence
{
    public static class Settings
    {
        public static string ConnString
        {
            get
            {
                ConfigurationManager configManager = new(); configManager.SetBasePath(Directory.GetCurrentDirectory() + "/../../Presentation/ETicaretApp.WEBAPI");
                configManager.AddJsonFile("appsettings.json");
                //return configManager.GetSection("ConnectionStrings")["homeSqlServer"];
                return configManager.GetConnectionString("ConnString");
            }
        }
    }
}
