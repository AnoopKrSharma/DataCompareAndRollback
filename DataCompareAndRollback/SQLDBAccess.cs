using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataCompareAndRollback
{
    public class SQLDBAccess
    {
        private string _ConnectionString;
        public SQLDBAccess(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public bool CheckConnection() {
            bool Connected = true;
            SqlConnection Con = new SqlConnection(this._ConnectionString);
            try {
                Con.Open();
            }
            catch (Exception Ex) {
                Connected = false;
            }
            finally {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            return Connected;
        }

        public DataTable GetDataTable(string ProcedureName,List<SqlParameter> LstSqlParameter) {
            DataTable DT = new DataTable();
            try {
                SqlConnection Con = new SqlConnection(this._ConnectionString);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand Com = new SqlCommand();
                Com.CommandType = CommandType.StoredProcedure;
                Com.CommandText = ProcedureName;
                Com.Connection = Con;
                if (LstSqlParameter != null)
                {
                    foreach (SqlParameter SQLPara in LstSqlParameter)
                    {
                        Com.Parameters.Add(SQLPara);
                    }
                }
                SqlDataAdapter Adpat = new SqlDataAdapter(Com);
                Adpat.Fill(DT);
            } catch (Exception Ex) {

            }
            return DT;
        }

        public DataTable GetDataTableWithQuery(string Query, List<SqlParameter> LstSqlParameter)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlConnection Con = new SqlConnection(this._ConnectionString);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand Com = new SqlCommand();
                Com.CommandType = CommandType.Text;
                Com.CommandText = Query;
                Com.Connection = Con;
                if (LstSqlParameter != null)
                {
                    foreach (SqlParameter SQLPara in LstSqlParameter)
                    {
                        Com.Parameters.Add(SQLPara);
                    }
                }
                SqlDataAdapter Adpat = new SqlDataAdapter(Com);
                Adpat.Fill(DT);
            }
            catch (Exception Ex)
            {

            }
            return DT;
        }
    }
}
