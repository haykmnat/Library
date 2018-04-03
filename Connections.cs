using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class LibConnection
    {
        public static string GetConnString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["MainConn"].ConnectionString);
            builder.Pooling = true;
            builder.MinPoolSize = 5;
            builder.MaxPoolSize = 10;
            return builder.ConnectionString;
        }
  
    }
} 
