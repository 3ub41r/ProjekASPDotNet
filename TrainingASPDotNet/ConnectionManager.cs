using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrainingASPDotNet
{
    public static class ConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            return new SqlConnection(connection);
        }
    }
}