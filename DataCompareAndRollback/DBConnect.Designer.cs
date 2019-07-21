namespace DataCompareAndRollback
{
    partial class DBConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddlDBName1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnTestConnection1 = new System.Windows.Forms.Button();
            this.chkRemember1 = new System.Windows.Forms.CheckBox();
            this.ddlAuth1 = new System.Windows.Forms.ComboBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUserName1 = new System.Windows.Forms.TextBox();
            this.txtServer1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ddlDBName2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnTestConnection2 = new System.Windows.Forms.Button();
            this.chkRemember2 = new System.Windows.Forms.CheckBox();
            this.ddlAuth2 = new System.Windows.Forms.ComboBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUserName2 = new System.Windows.Forms.TextBox();
            this.txtServer2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 32);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "DB Script Generator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ddlDBName1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnReset1);
            this.panel2.Controls.Add(this.btnTestConnection1);
            this.panel2.Controls.Add(this.chkRemember1);
            this.panel2.Controls.Add(this.ddlAuth1);
            this.panel2.Controls.Add(this.txtPassword1);
            this.panel2.Controls.Add(this.txtUserName1);
            this.panel2.Controls.Add(this.txtServer1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 247);
            this.panel2.TabIndex = 1;
            // 
            // ddlDBName1
            // 
            this.ddlDBName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDBName1.FormattingEnabled = true;
            this.ddlDBName1.Location = new System.Drawing.Point(100, 137);
            this.ddlDBName1.Name = "ddlDBName1";
            this.ddlDBName1.Size = new System.Drawing.Size(256, 21);
            this.ddlDBName1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Database Name :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(100, 216);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(256, 23);
            this.btnReset1.TabIndex = 12;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnTestConnection1
            // 
            this.btnTestConnection1.Location = new System.Drawing.Point(100, 187);
            this.btnTestConnection1.Name = "btnTestConnection1";
            this.btnTestConnection1.Size = new System.Drawing.Size(256, 23);
            this.btnTestConnection1.TabIndex = 11;
            this.btnTestConnection1.Text = "Test Connection";
            this.btnTestConnection1.UseVisualStyleBackColor = true;
            this.btnTestConnection1.Click += new System.EventHandler(this.btnTestConnection1_Click);
            // 
            // chkRemember1
            // 
            this.chkRemember1.AutoSize = true;
            this.chkRemember1.Location = new System.Drawing.Point(100, 164);
            this.chkRemember1.Name = "chkRemember1";
            this.chkRemember1.Size = new System.Drawing.Size(95, 17);
            this.chkRemember1.TabIndex = 6;
            this.chkRemember1.Text = "Remember Me";
            this.chkRemember1.UseVisualStyleBackColor = true;
            // 
            // ddlAuth1
            // 
            this.ddlAuth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAuth1.FormattingEnabled = true;
            this.ddlAuth1.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlAuth1.Location = new System.Drawing.Point(100, 58);
            this.ddlAuth1.Name = "ddlAuth1";
            this.ddlAuth1.Size = new System.Drawing.Size(256, 21);
            this.ddlAuth1.TabIndex = 2;
            this.ddlAuth1.SelectedIndexChanged += new System.EventHandler(this.ddlAuth1_SelectedIndexChanged);
            this.ddlAuth1.Leave += new System.EventHandler(this.ddlAuth1_Leave);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(100, 109);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(256, 20);
            this.txtPassword1.TabIndex = 4;
            this.txtPassword1.Leave += new System.EventHandler(this.txtPassword1_Leave);
            // 
            // txtUserName1
            // 
            this.txtUserName1.Location = new System.Drawing.Point(100, 82);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.Size = new System.Drawing.Size(256, 20);
            this.txtUserName1.TabIndex = 3;
            this.txtUserName1.Leave += new System.EventHandler(this.txtUserName1_Leave);
            // 
            // txtServer1
            // 
            this.txtServer1.Location = new System.Drawing.Point(100, 32);
            this.txtServer1.Name = "txtServer1";
            this.txtServer1.Size = new System.Drawing.Size(256, 20);
            this.txtServer1.TabIndex = 1;
            this.txtServer1.Leave += new System.EventHandler(this.txtServer1_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Authentication :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Server - which have updated objects";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ddlDBName2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnReset2);
            this.panel3.Controls.Add(this.btnTestConnection2);
            this.panel3.Controls.Add(this.chkRemember2);
            this.panel3.Controls.Add(this.ddlAuth2);
            this.panel3.Controls.Add(this.txtPassword2);
            this.panel3.Controls.Add(this.txtUserName2);
            this.panel3.Controls.Add(this.txtServer2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(400, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 247);
            this.panel3.TabIndex = 1;
            // 
            // ddlDBName2
            // 
            this.ddlDBName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDBName2.FormattingEnabled = true;
            this.ddlDBName2.Location = new System.Drawing.Point(100, 137);
            this.ddlDBName2.Name = "ddlDBName2";
            this.ddlDBName2.Size = new System.Drawing.Size(256, 21);
            this.ddlDBName2.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Database Name :";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(100, 216);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(256, 23);
            this.btnReset2.TabIndex = 13;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnTestConnection2
            // 
            this.btnTestConnection2.Location = new System.Drawing.Point(100, 187);
            this.btnTestConnection2.Name = "btnTestConnection2";
            this.btnTestConnection2.Size = new System.Drawing.Size(256, 23);
            this.btnTestConnection2.TabIndex = 12;
            this.btnTestConnection2.Text = "Test Connection";
            this.btnTestConnection2.UseVisualStyleBackColor = true;
            this.btnTestConnection2.Click += new System.EventHandler(this.btnTestConnection2_Click);
            // 
            // chkRemember2
            // 
            this.chkRemember2.AutoSize = true;
            this.chkRemember2.Location = new System.Drawing.Point(100, 164);
            this.chkRemember2.Name = "chkRemember2";
            this.chkRemember2.Size = new System.Drawing.Size(95, 17);
            this.chkRemember2.TabIndex = 11;
            this.chkRemember2.Text = "Remember Me";
            this.chkRemember2.UseVisualStyleBackColor = true;
            // 
            // ddlAuth2
            // 
            this.ddlAuth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAuth2.FormattingEnabled = true;
            this.ddlAuth2.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlAuth2.Location = new System.Drawing.Point(100, 58);
            this.ddlAuth2.Name = "ddlAuth2";
            this.ddlAuth2.Size = new System.Drawing.Size(256, 21);
            this.ddlAuth2.TabIndex = 10;
            this.ddlAuth2.SelectedIndexChanged += new System.EventHandler(this.ddlAuth2_SelectedIndexChanged);
            this.ddlAuth2.Leave += new System.EventHandler(this.ddlAuth2_Leave);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(100, 109);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(256, 20);
            this.txtPassword2.TabIndex = 11;
            this.txtPassword2.Leave += new System.EventHandler(this.txtPassword2_Leave);
            // 
            // txtUserName2
            // 
            this.txtUserName2.Location = new System.Drawing.Point(100, 82);
            this.txtUserName2.Name = "txtUserName2";
            this.txtUserName2.Size = new System.Drawing.Size(256, 20);
            this.txtUserName2.TabIndex = 10;
            this.txtUserName2.Leave += new System.EventHandler(this.txtUserName2_Leave);
            // 
            // txtServer2
            // 
            this.txtServer2.Location = new System.Drawing.Point(100, 32);
            this.txtServer2.Name = "txtServer2";
            this.txtServer2.Size = new System.Drawing.Size(256, 20);
            this.txtServer2.TabIndex = 9;
            this.txtServer2.Leave += new System.EventHandler(this.txtServer2_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Username :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Authentication :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Server Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DB Server - which needs to be updated";
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(272, 318);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(251, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(251, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DBConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBConnect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBConnect_FormClosing);
            this.Load += new System.EventHandler(this.DBConnect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtUserName1;
        private System.Windows.Forms.TextBox txtServer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtUserName2;
        private System.Windows.Forms.TextBox txtServer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlAuth1;
        private System.Windows.Forms.ComboBox ddlAuth2;
        private System.Windows.Forms.Button btnTestConnection1;
        private System.Windows.Forms.CheckBox chkRemember1;
        private System.Windows.Forms.Button btnTestConnection2;
        private System.Windows.Forms.CheckBox chkRemember2;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlDBName1;
        private System.Windows.Forms.ComboBox ddlDBName2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label13;
    }
}

