using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataCompareAndRollback
{
    public class BusinessLogic
    {
        SQLDBAccess ObjSQLDBAccess;
        public bool CheckConnection(string ConnectionString) {
            bool Connected = true;
            ObjSQLDBAccess = new SQLDBAccess(ConnectionString);
            Connected=ObjSQLDBAccess.CheckConnection();
            return Connected;
        }
        public DataTable GetDataTable(string ConnectionString) {
            ObjSQLDBAccess = new SQLDBAccess(ConnectionString);
            DataTable DT=ObjSQLDBAccess.GetDataTable("sp_databases", null);
            return DT;
        }
        public string GetProcedure(string ProcedureName,string ConnectionName) {
            string ProcedureFound = "";
            List<SqlParameter> LstSqlParameter = new List<SqlParameter>();
            LstSqlParameter.Add(new SqlParameter("@objname", ProcedureName));
            ObjSQLDBAccess = new SQLDBAccess(ConnectionName);
            DataTable dt=ObjSQLDBAccess.GetDataTable("sp_helptext", LstSqlParameter);
            if(dt!=null && dt.Rows.Count>0)
            {
                StringBuilder SB = new StringBuilder();
                for (int i=0;i<dt.Rows.Count;i++) {
                    SB.Append(dt.Rows[i]["Text"]);
                }
                ProcedureFound = SB.ToString();
            }
            return ProcedureFound;
        }
    }
}
