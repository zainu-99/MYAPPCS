using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS.Helper
{
    class SqlService
    {
        static DataSet ds = new DataSet();
        public static string SetConnection{ get; set; }
        public static SqlDataAdapter GetDataAdapter(String query)
        {
            try
            {
                var con = new SqlConnection(SetConnection);
                con.Open();
                var sda = new SqlDataAdapter(query, con);
                con.Close();
                return sda;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
        public static DataSet GetDataSet(String query, String tableName = "Table")
        {
            var con = new SqlConnection(SetConnection);
            con.Open();
            try
            {
                var adapter = new SqlDataAdapter(query, con);
                if (ds.Tables.Contains(tableName))
                    ds.Tables.Remove(tableName);
                adapter.Fill(ds, tableName);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            con.Close();
            return ds;
        }
        public static DataTable GetDataTable(String query, String tableName = "Table")
        {
            var con = new SqlConnection(SetConnection);
            con.Open();
            try
            {
                var adapter = new SqlDataAdapter(query, con);
                if (ds.Tables.Contains(tableName))
                    ds.Tables.Remove(tableName);
                adapter.Fill(ds, tableName);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return ds.Tables[tableName];
        }
        public static ModSqlCommand GetCommand(String query)
        {
            try
            {
                var con = new SqlConnection(SetConnection);
                con.Open();
                return new ModSqlCommand(new SqlCommand(query, con), con);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
        public static ExecuteQueryReturn ExecuteQuery(String query)
        {
            var eqr = new ExecuteQueryReturn();
            try
            {
                var con = new SqlConnection(SetConnection);
                con.Open();
                var sqlcom = new SqlCommand(query, con);
                sqlcom.ExecuteNonQuery();
                eqr.Message = "";
                eqr.Success = true;
                return eqr;
            }
            catch (Exception e)
            {
                eqr.Message = e.Message;
                eqr.Success = false;
                return eqr;
            }
        }
        public static ModSqlDataReader GetDataReader(String query)
        {
            try
            {
                var con = new SqlConnection(SetConnection);
                con.Open();
                var sqlcom = new SqlCommand(query, con);
                return new ModSqlDataReader(sqlcom.ExecuteReader(), con);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
    }

    class ModSqlCommand
    {
        public SqlCommand sqlCommand;
        public SqlConnection sqlConnection;
        public ModSqlCommand(SqlCommand sqlCommand, SqlConnection sqlConnection)
        {
            this.sqlCommand = sqlCommand;
            this.sqlConnection = sqlConnection;
        }
    }
    class ModSqlDataReader
    {
        public SqlDataReader sqlDataReader;
        public SqlConnection sqlConnection;
        public ModSqlDataReader(SqlDataReader sqlDataReader, SqlConnection sqlConnection)
        {
            this.sqlDataReader = sqlDataReader;
            this.sqlConnection = sqlConnection;
        }
    }
    class ExecuteQueryReturn
    {
        public Boolean Success { set; get; }
        public String Message { set; get; }
    }

}
