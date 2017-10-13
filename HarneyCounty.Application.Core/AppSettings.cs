using System.Configuration;

namespace HarneyCounty.Application.Core
{
    public static class AppSettings
    {
        public static int PageSize
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PageSize"]); }
        }        
    }
}