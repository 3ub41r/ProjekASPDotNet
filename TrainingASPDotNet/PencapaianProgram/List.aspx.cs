using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;

namespace TrainingASPDotNet.PencapaianProgram
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindProgram();
        }

        protected void BindProgram()
        {
            const string sql = @"SELECT * FROM PencapaianProgram";

            // Get connection string from Web.config
            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();

            using (var c = new SqlConnection(connection))
            {
                var data = c.Query<Entities.PencapaianProgram>(sql);
                ProgramRepeater.DataSource = data;
                ProgramRepeater.DataBind();
            }
        }
    }
}