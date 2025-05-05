using Config;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection cn;

        // function to connect SQL Server
        private static void connect()
        {
            try
            {
                string connectionString = "";

                // Window Authentication
                if (Config_Settings.Authen == "windows")
                {
                    connectionString = $"Server={Config_Settings.Server}; Database={Config_Settings.Database}; Trusted_Connection=True;";
                }
                // SQL Server Authentication
                else
                {
                    connectionString = $"Server={Config_Settings.Server}; Database={Config_Settings.Database}; User Id={Config_Settings.Username}; Password={Config_Settings.Password};";
                }

                cn = new SqlConnection(connectionString);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during connection: " + ex.Message);
            }
        }

        // function to implement (INSERT, UPDATE, DELETE)
        public static void actionQuery(string sql)
        {
            try
            {
                connect();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during data retrieval!" + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        // function to implement SELECT
        public static DataTable selectQuery(string sql)
        {
            try
            {
                connect();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn))
                {
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during data retrieval!: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
    }
}
