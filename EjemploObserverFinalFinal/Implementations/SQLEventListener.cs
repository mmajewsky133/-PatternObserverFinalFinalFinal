using EjemploObserverFinalFinal.Interfaces;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal.Implementations
{
    public class SQLEventListener : IObserver
    {
        public void Update()
        {
            String fecha = DateTime.Now.ToString();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO ObrEventLogs (LogDate, Detail) VALUES (@Date, @Details)", conn);
                command.Parameters.AddWithValue("@Date", fecha);
                command.Parameters.AddWithValue("@Details", "Se realizo algo en formulario...");
                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
