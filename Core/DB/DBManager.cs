using System;
using System.Data;
using System.Data.SqlClient;

namespace Core.DB
{
    public class DBManager //: IDisposable
    {
        #region Fields&Properties

        private string connectionString
        {
            get
            {
                return Configs.Configs.GetInstance()["ConnectionString"].Value;
            }
        }

        private SqlConnection connection;

        #endregion

        #region Constructors

        private DBManager()
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        #endregion

        #region SingletonItems

        private static DBManager instance;

        public static DBManager GetInstance()
        {
            if (instance == null)
                instance = new DBManager();
            return instance;
        }

        #endregion

        #region ExecutableCommands

        public void ExecuteCommand(string command, params Tuple<string, object>[] parameters)
        {
            SqlCommand cmd = new SqlCommand(command, connection);

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue("@" + parameter.Item1, parameter.Item2);
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public DataSet ExecuteReader(string command, params Tuple<string, object>[] parameters)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            DataSet ds = new DataSet();

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue("@" + parameter.Item1, parameter.Item2);
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    adapter.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

        public DataSet ExecuteProcedure(string procName, params Tuple<string, object>[] parameters)
        {
            SqlCommand cmd = new SqlCommand(procName, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue("@" + parameter.Item1, parameter.Item2);
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    adapter.Fill(ds);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

        #endregion

        //#region DisposableItems

        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            instance = null;
        //            connection.Dispose();
        //        }
        //    }
        //    disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //#endregion
    }
}
