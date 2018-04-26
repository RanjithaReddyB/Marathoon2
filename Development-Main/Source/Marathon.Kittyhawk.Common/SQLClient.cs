using System.Data;
using System.Data.SqlClient;

namespace Marathon.Kittyhawk.Common
{
    /// <summary>
    /// This static class exposes methods for connecting to SQL data sources.
    /// </summary>
    public static class SQLClient
    {
		private const int MaxQueryExecutionTime = 3600;

        /// <summary>
        /// Executes an inline SQL statement and returns the number of rows affected.
        /// </summary>
        /// <param name="sqlStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <returns>Integer indicating the number of rows affected by the query</returns>
        public static int RunStatement(string sqlStatement, string connectionString)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand(sqlStatement, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = MaxQueryExecutionTime;

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlCommand != null)
                    sqlCommand.Dispose();
                if (sqlConnection != null)
                    sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes an inline SQL statement and returns the number of rows affected.
        /// </summary>
        /// <param name="sqlStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="commandParameters">Parameters for the SQL statement</param>
        /// <returns>Integer indicating the number of rows affected by the query</returns>
        public static int RunStatement(string sqlStatement, string connectionString,
            params SqlParameter[] commandParameters)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand(sqlStatement, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = MaxQueryExecutionTime;

                if (commandParameters != null)
                {
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        if (commandParameters[i] != null)
                        {
                            sqlCommand.Parameters.Add(commandParameters[i]);
                        }
                    }
                }

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlCommand != null)
                    sqlCommand.Dispose();
                if (sqlConnection != null)
                    sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes an inline SQL statement and returns a data table.
        /// </summary>
        /// <param name="sqlStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <returns>Data table containing the return data</returns>
        public static DataTable RunQuery(string sqlStatement, string connectionString)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand(sqlStatement, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = MaxQueryExecutionTime;

                adapter = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();

                sqlConnection.Open();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();
                if (sqlCommand != null)
                    sqlCommand.Dispose();
                if (sqlConnection != null)
                    sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes an inline SQL statement and returns a data table.
        /// </summary>
        /// <param name="sqlStatement">Inline SQL</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="commandParameters">Parameters for the SQL statement</param>
        /// <returns>Data table containing the return data</returns>
        public static DataTable RunQuery(string sqlStatement, string connectionString,
            params SqlParameter[] commandParameters)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand(sqlStatement, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = MaxQueryExecutionTime;

                if (commandParameters != null)
                {
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        if (commandParameters[i] != null)
                        {
                            sqlCommand.Parameters.Add(commandParameters[i]);
                        }
                    }
                }

                adapter = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();

                sqlConnection.Open();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();
                if (sqlCommand != null)
                {
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Dispose();
                }
                    
                if (sqlConnection != null)
                    sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes a stored procedure and returns a data table.
        /// </summary>
        /// <param name="procedureName">Procedure name</param>
        /// <param name="connectionString">Connection string</param>
        /// <returns>Data table containing the return data</returns>
        public static DataTable RunStoredProcedure(string procedureName, string connectionString)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand(procedureName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = MaxQueryExecutionTime;

                adapter = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();

                sqlConnection.Open();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();
                if (sqlCommand != null)
                    sqlCommand.Dispose();
                if (sqlConnection != null)
                    sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// Executes a stored procedure and returns a data table.
        /// </summary>
        /// <param name="procedureName">Procedure name</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="commandParameters">Parameters for the stored procedure</param>
        /// <returns>Data table containing the return data</returns>
        public static DataTable RunStoredProcedure(string procedureName, string connectionString,
            params SqlParameter[] commandParameters)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand(procedureName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = MaxQueryExecutionTime;

                if (commandParameters != null)
                {
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        if (commandParameters[i] != null)
                        {
                            sqlCommand.Parameters.Add(commandParameters[i]);
                        }
                    }
                }

                adapter = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();

                sqlConnection.Open();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();
                if (sqlCommand != null)
                    sqlCommand.Dispose();
                if (sqlConnection != null)
                    sqlConnection.Dispose();
            }
        }
    }
}
