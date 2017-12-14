using System.Configuration;

namespace HarneyCounty.Common
{
    public static class AppSettings
    {
        public static int PageSize
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PageSize"]); }
        }

        public static int DefaultSearchYear
        {
            get { return int.Parse(ConfigurationManager.AppSettings["DefaultSearchYear"]); }
        }
    }
}