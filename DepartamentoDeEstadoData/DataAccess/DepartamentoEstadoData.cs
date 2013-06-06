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

        public static DataTable GetCorpClassesByYearSeries()
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
                        cmd.CommandText = "GetCorpClassesByYearSeries";
                        cmd.Parameters.Add(new SqlParameter("@filterYear", 2012));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable resultsTable = new DataTable("CorpClassesByYearSeries");
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

        public static DataTable GetCorpJurisdictionsByYear(int filterYear)
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
                        cmd.CommandText = "GetCorpJurisdictionsByYear";
                        cmd.Parameters.Add(new SqlParameter("@filterYear", filterYear));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable resultsTable = new DataTable("CorpJurisdictionsByYear");
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

        public static DataTable GetCorpOrganizationTypesByYear(int filterYear)
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
                        cmd.CommandText = "GetCorpOrganizationTypesByYear";
                        cmd.Parameters.Add(new SqlParameter("@filterYear", filterYear));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable resultsTable = new DataTable("CorpOrganizationTypesByYear");
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

        public static DataTable GetCorpTypesByYear(int filterYear)
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
                        cmd.CommandText = "GetCorpTypesByYear";
                        cmd.Parameters.Add(new SqlParameter("@filterYear", filterYear));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable resultsTable = new DataTable("CorpTypesByYear");
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