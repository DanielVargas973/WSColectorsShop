using System.Configuration;

namespace WSColectorsShop.com.wcs.conf
{
    public class Connection
    {
        public static string GetValueOfAppSettings(string key)
        {
            return ConfigurationManager.AppSettings.Get(key).ToString();
        }
    }
}