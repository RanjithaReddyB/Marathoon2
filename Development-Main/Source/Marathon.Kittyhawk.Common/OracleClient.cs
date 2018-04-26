using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Marathon.Kittyhawk.Common
{
    /// <summary>
    /// This static class exposes methods for connecting to OLEDB data sources.
    /// </summary>
    public static class OracleClient
    {
        /// <summary>
        /// Executes an inline SQL statement and returns the number of rows affected.
        /// </summary>
        /// <param name="dbStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <returns>Integer indicating the number of rows affected by the query</returns>
        public static int RunStatement(string dbStatement, string connectionString)
        {
            OracleConnection dbConnection = null;
            OracleCommand dbCommand = null;

            try
            {
                dbConnection = new OracleConnection(connectionString);
                dbCommand = new OracleCommand(dbStatement, dbConnection);
                dbCommand.CommandType = CommandType.Text;

                dbConnection.Open();
                return dbCommand.ExecuteNonQuery();
            }
            finally
            {
                if (dbCommand != null)
                    dbCommand.Dispose();
                if (dbConnection != null)
                    dbConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes an inline SQL statement and returns the number of rows affected.
        /// </summary>
        /// <param name="dbStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="commandParameters">Parameters for the SQL statement</param>
        /// <returns>Integer indicating the number of rows affected by the query</returns>
        public static int RunStatement(string dbStatement, string connectionString,
            params OracleParameter[] commandParameters)
        {
            OracleConnection dbConnection = null;
            OracleCommand dbCommand = null;

            try
            {
                dbConnection = new OracleConnection(connectionString);
                dbCommand = new OracleCommand(dbStatement, dbConnection);
                dbCommand.CommandType = CommandType.Text;

                if (commandParameters != null)
                {
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        if (commandParameters[i] != null)
                        {
                            dbCommand.Parameters.Add(commandParameters[i]);
                        }
                    }
                }

                dbConnection.Open();
                return dbCommand.ExecuteNonQuery();
            }
            finally
            {
                if (dbCommand != null)
                    dbCommand.Dispose();
                if (dbConnection != null)
                    dbConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes an inline SQL statement and returns a data table.
        /// </summary>
        /// <param name="dbStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <returns>Data table containing the return data</returns>
        public static DataTable RunQuery(string dbStatement, string connectionString)
        {
            OracleConnection dbConnection = null;
            OracleCommand dbCommand = null;
            OracleDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                dbConnection = new OracleConnection(connectionString);
                dbCommand = new OracleCommand(dbStatement, dbConnection);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandTimeout = 600;

                adapter = new OracleDataAdapter(dbCommand);
                dt = new DataTable();

                dbConnection.Open();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();
                if (dbCommand != null)
                    dbCommand.Dispose();
                if (dbConnection != null)
                    dbConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes an inline SQL statement and returns a data table.
        /// </summary>
        /// <param name="dbStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="commandParameters">Parameters for the SQL statement</param>
        /// <returns>Data table containing the return data</returns>
        public static DataTable RunQuery(string dbStatement, string connectionString,
            params OracleParameter[] commandParameters)
        {
            OracleConnection dbConnection = null;
            OracleCommand dbCommand = null;
            OracleDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                dbConnection = new OracleConnection(connectionString);
                dbCommand = new OracleCommand(dbStatement, dbConnection);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandTimeout = 600;

                if (commandParameters != null)
                {
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        if (commandParameters[i] != null)
                        {
                            dbCommand.Parameters.Add(commandParameters[i]);
                        }
                    }
                }

                adapter = new OracleDataAdapter(dbCommand);
                dt = new DataTable();

                dbConnection.Open();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();
                if (dbCommand != null)
                    dbCommand.Dispose();
                if (dbConnection != null)
                    dbConnection.Dispose();
            }
        }
    }
}
