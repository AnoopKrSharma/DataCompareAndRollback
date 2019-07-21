using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCompareAndRollback
{
    public partial class DBConnect : Form
    {
        ValidateFields ObjValidateFields;
        BusinessLogic ObjBusinessLogic;
        public DBConnect()
        {
            ObjValidateFields = new ValidateFields();
            ObjBusinessLogic = new BusinessLogic();
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtServer1_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text)))
            {
                Connection.Connection1 = ObjValidateFields.CreateConnectionString(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection1))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection1);
                    ddlDBName1.DataSource = DT;
                    ddlDBName1.DisplayMember = "Database_Name";
                    ddlDBName1.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void ddlAuth1_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text)))
            {
                Connection.Connection1 = ObjValidateFields.CreateConnectionString(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection1))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection1);
                    ddlDBName1.DataSource = DT;
                    ddlDBName1.DisplayMember = "Database_Name";
                    ddlDBName1.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void txtUserName1_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text)))
            {
                Connection.Connection1 = ObjValidateFields.CreateConnectionString(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection1))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection1);
                    ddlDBName1.DataSource = DT;
                    ddlDBName1.DisplayMember = "Database_Name";
                    ddlDBName1.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void txtPassword1_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text)))
            {
                Connection.Connection1 = ObjValidateFields.CreateConnectionString(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 1, Convert.ToString(ddlDBName1.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection1))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection1);
                    ddlDBName1.DataSource = DT;
                    ddlDBName1.DisplayMember = "Database_Name";
                    ddlDBName1.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void ddlAuth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(ddlAuth1.SelectedItem)== "Windows Authentication") {
                txtUserName1.Text = "";
                txtPassword1.Text = "";
                txtUserName1.Enabled = false;
                txtPassword1.Enabled = false;
            }
            else
            {
                txtUserName1.Enabled = true;
                txtPassword1.Enabled = true;
            }
        }

        private void txtServer2_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text)))
            {
                Connection.Connection2 = ObjValidateFields.CreateConnectionString(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection2))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection2);
                    ddlDBName2.DataSource = DT;
                    ddlDBName2.DisplayMember = "Database_Name";
                    ddlDBName2.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void ddlAuth2_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text)))
            {
                Connection.Connection2 = ObjValidateFields.CreateConnectionString(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection2))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection2);
                    ddlDBName2.DataSource = DT;
                    ddlDBName2.DisplayMember = "Database_Name";
                    ddlDBName2.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void txtUserName2_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text)))
            {
                Connection.Connection2 = ObjValidateFields.CreateConnectionString(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection2))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection2);
                    ddlDBName2.DataSource = DT;
                    ddlDBName2.DisplayMember = "Database_Name";
                    ddlDBName2.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text)))
            {
                Connection.Connection2 = ObjValidateFields.CreateConnectionString(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 1, Convert.ToString(ddlDBName2.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection2))
                {
                    DataTable DT = ObjBusinessLogic.GetDataTable(Connection.Connection2);
                    ddlDBName2.DataSource = DT;
                    ddlDBName2.DisplayMember = "Database_Name";
                    ddlDBName2.ValueMember = "Database_Name";
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void ddlAuth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(ddlAuth2.SelectedItem) == "Windows Authentication")
            {
                txtUserName2.Text = "";
                txtPassword2.Text = "";
                txtUserName2.Enabled = false;
                txtPassword2.Enabled = false;
            }
            else
            {
                txtUserName2.Enabled = true;
                txtPassword2.Enabled = true;
            }
        }

        private void btnTestConnection1_Click(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 2, Convert.ToString(ddlDBName1.Text)))
            {
                Connection.Connection1 = ObjValidateFields.CreateConnectionString(txtServer1.Text, Convert.ToString(ddlAuth1.Text), txtUserName1.Text, txtPassword1.Text, 2, Convert.ToString(ddlDBName1.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection1))
                {
                    MessageBox.Show("Tested Connection Successfully!");
                    DisableControl(1);
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        private void btnTestConnection2_Click(object sender, EventArgs e)
        {
            if (ObjValidateFields.ValidateServer(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 2, Convert.ToString(ddlDBName2.Text)))
            {
                Connection.Connection2 = ObjValidateFields.CreateConnectionString(txtServer2.Text, Convert.ToString(ddlAuth2.Text), txtUserName2.Text, txtPassword2.Text, 2, Convert.ToString(ddlDBName2.Text));
                if (ObjBusinessLogic.CheckConnection(Connection.Connection2))
                {
                    MessageBox.Show("Tested Connection Successfully!");
                    DisableControl(2);
                }
                else
                {
                    MessageBox.Show("Invalid Connection Details!");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Server">Value 1 for Server with Updated Objects abd Value 2 for Server which needs to be updated</param>
        private void DisableControl(int Server) {
            if (Server==1) {
                txtServer1.Enabled = false;
                ddlAuth1.Enabled = false;
                txtUserName1.Enabled = false;
                txtPassword1.Enabled = false;
                ddlDBName1.Enabled = false;
                chkRemember1.Enabled = false;
                btnTestConnection1.Enabled = false;
            }
            else if (Server == 2) {
                txtServer2.Enabled = false;
                ddlAuth2.Enabled = false;
                txtUserName2.Enabled = false;
                txtPassword2.Enabled = false;
                ddlDBName2.Enabled = false;
                chkRemember2.Enabled = false;
                btnTestConnection2.Enabled = false;
            }
            if (!btnTestConnection1.Enabled && !btnTestConnection2.Enabled) {
                btnConnect.Enabled = true;
            }
            else
            {
                btnConnect.Enabled = false;
            }
        }

        private void ResetControl(int Server) {
            if (Server==1)
            {
                txtServer1.Enabled = true;
                txtServer1.Text = "";
                ddlAuth1.Enabled = true;
                if (ddlAuth1.Text== "SQL Server Authentication") {
                    txtUserName1.Enabled = true;
                    txtPassword1.Enabled = true;
                }
                txtUserName1.Text = "";
                txtPassword1.Text = "";
                ddlDBName1.Enabled = true;
                ddlDBName1.DataSource = null;
                chkRemember1.Enabled = true;
                btnTestConnection1.Enabled = true;
            }
            else if(Server==2)
            {
                txtServer2.Enabled = true;
                txtServer2.Text = "";
                ddlAuth2.Enabled = true;
                if (ddlAuth1.Text == "SQL Server Authentication")
                {
                    txtUserName2.Enabled = true;
                    txtPassword2.Enabled = true;
                }                
                txtUserName2.Text = "";
                txtPassword2.Text = "";
                ddlDBName2.Enabled = true;
                ddlDBName2.DataSource = null;
                chkRemember2.Enabled = true;
                btnTestConnection2.Enabled = true;
            }
        }
        private void btnReset1_Click(object sender, EventArgs e)
        {
            ResetControl(1);
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            ResetControl(2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DBConnect_Load(object sender, EventArgs e)
        {

        }

        private void DBConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DBCompareMain ObjDBCompareMain = new DBCompareMain();
            ObjDBCompareMain.Show();
            this.Hide();
        }
    }
}
