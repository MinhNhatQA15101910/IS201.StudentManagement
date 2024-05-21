using System.Configuration;

namespace DAL
{
    public class Utils
    {
        private static string StrName = "StudentManagementCS";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
    }
}
