using Microsoft.Data.SqlClient;
using System;

namespace medi_queue.database
{
    public class DatabaseConnection
    {
        // =============================================
        // VARIABLES QUE DEBES CONFIGURAR PARA TU ENTORNO
        // =============================================
        private const string DB_SERVER = ""; // Cambiar por tu servidor
        private const string DB_NAME = "medi_queue";
        private const bool USE_WINDOWS_AUTH = true;                 // True para autenticación Windows
        private const string DB_USER = "";                          // Usuario SQL (si USE_WINDOWS_AUTH=false)
        private const string DB_PASSWORD = "";                      // Password SQL (si USE_WINDOWS_AUTH=false)
        // =============================================

        private static readonly Lazy<string> _connectionString = new Lazy<string>(() =>
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = DB_SERVER,
                InitialCatalog = DB_NAME,
                Encrypt = false,
                TrustServerCertificate = true
            };

            if (USE_WINDOWS_AUTH)
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                builder.UserID = DB_USER;
                builder.Password = DB_PASSWORD;
            }

            return builder.ToString();
        });

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString.Value);
            connection.StatisticsEnabled = true;
            return connection;
        }

        public static void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine($"Conexión exitosa a: {connection.Database} en {connection.DataSource}");
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Error conectando a {connection.DataSource}: {ex.Message}", ex);
                }
            }
        }
    }
}