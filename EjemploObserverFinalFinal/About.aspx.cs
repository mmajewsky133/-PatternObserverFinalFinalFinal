using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT LogDate, Detail FROM ObrEventLogs", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gvEvents.DataSource = table;
                gvEvents.DataBind();
            }
        }
    }
}