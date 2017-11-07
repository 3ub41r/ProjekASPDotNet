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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Insert ke table PencapaianProgram

            const string sql = @"
            INSERT INTO PencapaianProgram (KodProgram, TarikhProgram, BilanganHari, Lulus)
            VALUES (@KodProgram, @TarikhProgram, @BilanganHari, @Lulus)";

            // Get connection string from Web.config
            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();

            // Buka connection
            using (var c = new SqlConnection(connection))
            {
                var pencapaianProgram = new Entities.PencapaianProgram
                {
                    KodProgram = KodProgram.Text,
                    TarikhProgram = DateTime.Parse(TarikhProgram.Text),
                    BilanganHari = int.Parse(BilanganHari.Text),
                    Lulus = Lulus.Checked
                };

                c.Execute(sql, pencapaianProgram);
            }

            Response.Redirect("List.aspx");

        }
    }
}