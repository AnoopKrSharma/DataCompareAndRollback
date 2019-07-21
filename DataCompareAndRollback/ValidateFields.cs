using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompareAndRollback
{
    public class ValidateFields
    {
        /// <summary>
        /// For Validation the DB Fields
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="Authentication"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <param name="Action">Can be 1 and 2. 1 For Fetching the Database Name and 2 for validating the Connection string</param>
        /// <param name="DatabaseName"></param>
        /// <returns></returns>
        public bool ValidateServer(string ServerName, string Authentication, string UserName, string Password, int Action, string DatabaseName = "")
        {
            bool Validated = true;
            if (string.IsNullOrEmpty(ServerName.Trim()) || string.IsNullOrEmpty(Authentication.Trim()) || (Action == 1 ? false : string.IsNullOrEmpty(DatabaseName.Trim())))
            {
                Validated = false;
            }
            else if (Authentication == "SQL Server Authentication")
            {
                Validated = SQLAuthWithUserNamePassword(UserName, Password);
            }
            return Validated;
        }

        public bool SQLAuthWithUserNamePassword(string UserName, string Password)
        {
            bool Validated = true;
            if (string.IsNullOrEmpty(UserName.Trim()) || string.IsNullOrEmpty(Password.Trim()))
            {
                Validated = false;
            }
            return Validated;
        }

        public string CreateConnectionString(string ServerName, string Authentication, string UserName, string Password, int Action, string DatabaseName = "")
        {
            string ConnectionString = "";
            if (Authentication == "Windows Authentication")
            {
                if (Action == 1)
                {
                    ConnectionString = string.Format("Data Source={0}; Integrated Security=true", ServerName);
                }
                else {
                    ConnectionString = string.Format("Data Source={0};Initial Catalog={1}; Integrated Security=true", ServerName,DatabaseName);
                }
            }
            else
            {
                if (Action == 1)
                {
                    ConnectionString = string.Format("Data Source={0}; User Id={1};Password = {2}; ", ServerName, UserName, Password);
                }
                else
                {
                    ConnectionString = string.Format("Data Source={0}; User Id={1};Password = {2};Initial Catalog = {3}; ", ServerName, UserName, Password,DatabaseName);
                }
            }
            return ConnectionString;
        }
    }
}
