using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Threading;

namespace kpt.classes
{
    public class Sql
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;

        public Sql()
        {
            conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["kp"].ConnectionString);
            try
            {
                conn.Open();

                var startTime = DateTime.Now;
                var endTime = DateTime.Now.AddSeconds(5);
                var timeOut = false;

                while (conn.State != ConnectionState.Open)
                {
                    if (DateTime.Now.CompareTo(endTime) >= 0)
                    {
                        timeOut = true;
                        break;
                    }
                    Thread.Yield();
                }

                if (timeOut)
                {
                    // if sql connection times out
                    // add code
                }                
            }
            catch (NpgsqlException ex)
            {
                Debug.Write(ex);
                throw;
            }
        }

        //public NpgsqlDataReader PostgresDataReader(string sql)
        //{
        //    try
        //    {
        //        _cmd = new NpgsqlCommand(sql, _conn);
        //        _dr = _cmd.ExecuteReader();
        //        return _dr;
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        Debug.Write(ex);
        //        return null;
        //    }
        //}

        // Select with parameters
        public DataTable Select(string sql, Dictionary<string, string> myParams)
        {
            DataTable myTable = new DataTable();
            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                foreach (KeyValuePair<string, string> entry in myParams)
                {
                    cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                }

                dr = cmd.ExecuteReader();
                myTable.Load(dr);

                return myTable;
            }
            catch (NpgsqlException ex)
            {
                Debug.Write(ex);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        // Select without parameters
        public DataTable Select(string sql)
        {
            DataTable myTable = new DataTable();
            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                myTable.Load(dr);

                return myTable;
            }
            catch (NpgsqlException ex)
            {
                Debug.Write(ex);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}