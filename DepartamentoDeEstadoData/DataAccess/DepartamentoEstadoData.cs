using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DepartamentoDeEstadoData.DataAccess
{
    public class DepartamentoEstadoData
    {

        public static DataTable GetCorpClassesByYear(int filterYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DeptEstadoData"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.Open();

                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GetCorpClassesByYear";
                        cmd.Parameters.Add(new SqlParameter("@filterYear", filterYear));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable resultsTable = new DataTable("CorpClassesByYear");
                        adapter.Fill(resultsTable);

                        return resultsTable;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}