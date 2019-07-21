using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoorMansTSqlFormatterLib.Tokenizers;

namespace DataCompareAndRollback
{
    public partial class DBCompareMain : Form
    {
        BusinessLogic ObjBusinessLogic = new BusinessLogic();

        DataTable dtNotFoundObject;

        public DBCompareMain()
        {
            InitializeComponent();
            ClearNotFoundDatatable();
        }

        public void ClearNotFoundDatatable() {
            //dtNotFoundObject = new DataTable();
            //dtNotFoundObject.Columns.Add("Objects_Not_Found", typeof(string));
            //dgvNotFound.DataSource = dtNotFoundObject;
            dgvNotFound.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearNotFoundDatatable();
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult Result = folderBrowserDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                lblLocation.Text = folderBrowserDialog1.SelectedPath;
                if (string.IsNullOrEmpty(lblLocation.Text))
                {
                    MessageBox.Show("Please select a valid folder in order to save the files!");
                    return;
                }
                Environment.SpecialFolder Root = folderBrowserDialog1.RootFolder;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Count", typeof(int));
            dt.Columns.Add("ObjectType", typeof(string));
            dt.Columns.Add("ObjectTypeCount", typeof(string));
            dt.Columns.Add("DDLObject", typeof(string));
            dt.Columns.Add("ProcedureName", typeof(string));
            dt.Columns.Add("UpdatedObject", typeof(string));
            dt.Columns.Add("RollbackObject", typeof(string));
            dt.Columns.Add("Valid", typeof(bool));

            if (!String.IsNullOrEmpty(txtProcedure.Text) && !String.IsNullOrWhiteSpace(txtProcedure.Text) && txtProcedure.Lines.Count() > 0)
            {
                int counter = 0;
                int counterProc = 0;
                int counterFunc = 0;
                for (int i = 0; i < txtProcedure.Lines.Count(); i++)
                {
                    if (!string.IsNullOrEmpty(txtProcedure.Lines[i]) && !string.IsNullOrWhiteSpace(txtProcedure.Lines[i]))
                    {
                        string RollBackProcedure = ObjBusinessLogic.GetProcedure(txtProcedure.Lines[i], Connection.Connection2);
                        string UpdatedProcedure = ObjBusinessLogic.GetProcedure(txtProcedure.Lines[i], Connection.Connection1);
                        if (!string.IsNullOrEmpty(UpdatedProcedure) && !string.IsNullOrEmpty(RollBackProcedure))
                        {
                            counter++;
                            string ObjectType = CheckProcedureFunction(UpdatedProcedure);
                            //Change Create Procedure to Alter Procedure
                            RollBackProcedure = Regex.Replace(RollBackProcedure, "Create Procedure", "Alter Procedure", RegexOptions.IgnoreCase);
                            RollBackProcedure = Regex.Replace(RollBackProcedure, "Create Proc", "Alter Procedure", RegexOptions.IgnoreCase);
                            RollBackProcedure = Regex.Replace(RollBackProcedure, "Create Func", "Alter Function", RegexOptions.IgnoreCase);
                            RollBackProcedure = Regex.Replace(RollBackProcedure, "Create Function", "Alter Function", RegexOptions.IgnoreCase);
                            UpdatedProcedure = Regex.Replace(UpdatedProcedure, "Create Procedure", "Alter Procedure", RegexOptions.IgnoreCase);
                            UpdatedProcedure = Regex.Replace(UpdatedProcedure, "Create Proc", "Alter Procedure", RegexOptions.IgnoreCase);
                            UpdatedProcedure = Regex.Replace(UpdatedProcedure, "Create Function", "Alter Function", RegexOptions.IgnoreCase);
                            UpdatedProcedure = Regex.Replace(UpdatedProcedure, "Create Func", "Alter Function", RegexOptions.IgnoreCase);
                            //Formatting up the procedures
                            RollBackProcedure = PoorMansTSqlFormatterLib.SqlFormattingManager.DefaultFormat(RollBackProcedure);
                            UpdatedProcedure = PoorMansTSqlFormatterLib.SqlFormattingManager.DefaultFormat(UpdatedProcedure);
                            DataRow dr = dt.Rows.Add();
                            dr["Count"] = counter;
                            dr["ObjectType"] = ObjectType;
                            if (ObjectType == "Procedure")
                            {
                                counterProc++;
                                dr["ObjectTypeCount"] = dt.Select("ObjectType='Procedure' and DDLObject='Alter'").Count()+1;
                            }
                            else if (ObjectType == "Function")
                            {
                                counterFunc++;
                                dr["ObjectTypeCount"] = dt.Select("ObjectType='Function' and DDLObject='Alter'").Count() + 1;
                            }
                            dr["DDLObject"] = "Alter";
                            dr["ProcedureName"] = txtProcedure.Lines[i];
                            dr["UpdatedObject"] = UpdatedProcedure;
                            dr["RollbackObject"] = RollBackProcedure;
                        }
                        else if (!string.IsNullOrEmpty(UpdatedProcedure))
                        {
                            counter++;
                            string ObjectType = CheckProcedureFunction(UpdatedProcedure);
                            DataRow dr = dt.Rows.Add();
                            dr["Count"] = counter;
                            dr["ObjectType"] = ObjectType;
                            if (ObjectType == "Procedure")
                            {
                                counterProc++;
                                dr["ObjectTypeCount"] = dt.Select("ObjectType='Procedure' and DDLObject='Create'").Count() + 1; ;
                            }
                            else if (ObjectType == "Function")
                            {
                                counterFunc++;
                                dr["ObjectTypeCount"] = dt.Select("ObjectType='Function' and DDLObject='Create'").Count() + 1; ; ;
                            }
                            dr["DDLObject"] = "Create";
                            dr["ProcedureName"] = txtProcedure.Lines[i];
                            dr["UpdatedObject"] = UpdatedProcedure;
                            dr["RollbackObject"] = "";
                        }
                        else
                        {
                            dgvNotFound.Rows.Add(txtProcedure.Lines[i]);
                        }
                    }
                }
            }
            dgvNotFound.DataSource = dtNotFoundObject;
            SaveSQLScripts(dt);
        }

        public string CheckProcedureFunction(string Query)
        {
            string Statement = "";
            if (Query.ToLower().Contains("create procedure") || Query.ToLower().Contains("create proc"))
            {
                Statement = "Procedure";
            }
            else if (Query.ToLower().Contains("create function") || Query.ToLower().Contains("create func"))
            {
                Statement = "Function";
            }

            return Statement;
        }

        public void SaveSQLScripts(DataTable dt)
        {
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    //lblLocation.Text
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //Script Available on the Rollback Server
                        if (!String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["RollbackObject"])))
                        {
                            string FolderPathRollback = lblLocation.Text + "/Rollback_" + Convert.ToString(dt.Rows[i]["ObjectType"]);
                            if (!Directory.Exists(FolderPathRollback))
                            {
                                Directory.CreateDirectory(FolderPathRollback);
                            }
                            string FilePathRollback = FolderPathRollback + "/" + Convert.ToString(dt.Rows[i]["ObjectTypeCount"])+"_" + Convert.ToString(dt.Rows[i]["DDLObject"]) +"_"+ Convert.ToString(dt.Rows[i]["ObjectType"]) +"_[dbo]."+ Convert.ToString(dt.Rows[i]["ProcedureName"]) + ".sql";
                            if (!File.Exists(FilePathRollback))
                            {
                                using (var tw = new StreamWriter(FilePathRollback, true))
                                {
                                    tw.WriteLine(Convert.ToString(dt.Rows[i]["RollbackObject"]));
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["UpdatedObject"])))
                        {
                            string FolderPathUpdate = lblLocation.Text + "/"+ Convert.ToString(dt.Rows[i]["DDLObject"]) + "_" + Convert.ToString(dt.Rows[i]["ObjectType"]);
                            if (!Directory.Exists(FolderPathUpdate))
                            {
                                Directory.CreateDirectory(FolderPathUpdate);
                            }
                            string FilePathRollback = FolderPathUpdate + "/" + Convert.ToString(dt.Rows[i]["ObjectTypeCount"]) + "_" + Convert.ToString(dt.Rows[i]["DDLObject"]) + "_" + Convert.ToString(dt.Rows[i]["ObjectType"]) + "_[dbo]." + Convert.ToString(dt.Rows[i]["ProcedureName"]) + ".sql";
                            if (!File.Exists(FilePathRollback))
                            {
                                using (var tw = new StreamWriter(FilePathRollback, true))
                                {
                                    tw.WriteLine(Convert.ToString(dt.Rows[i]["UpdatedObject"]));
                                }
                            }
                        }
                    }
                    MessageBox.Show("Scripts Generated Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DBCompareMain_Load(object sender, EventArgs e)
        {
            
        }

        private void DBCompareMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox objAboutBox = new AboutBox();
            objAboutBox.ShowDialog();
        }
    }
}
