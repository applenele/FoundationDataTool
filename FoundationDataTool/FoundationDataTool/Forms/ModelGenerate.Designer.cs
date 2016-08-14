namespace FoundationDataTool.Forms
{
    partial class ModelGenerate
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
            this.txtConnectstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLinkToMySql = new System.Windows.Forms.Button();
            this.chlTables = new System.Windows.Forms.CheckedListBox();
            this.btnGenerateModel = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lbHost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.btnLinkDB2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnectstring
            // 
            this.txtConnectstring.Location = new System.Drawing.Point(94, 25);
            this.txtConnectstring.Name = "txtConnectstring";
            this.txtConnectstring.Size = new System.Drawing.Size(328, 21);
            this.txtConnectstring.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接字符串";
            // 
            // btnLinkToMySql
            // 
            this.btnLinkToMySql.Location = new System.Drawing.Point(449, 23);
            this.btnLinkToMySql.Name = "btnLinkToMySql";
            this.btnLinkToMySql.Size = new System.Drawing.Size(75, 23);
            this.btnLinkToMySql.TabIndex = 2;
            this.btnLinkToMySql.Text = "连接";
            this.btnLinkToMySql.UseVisualStyleBackColor = true;
            this.btnLinkToMySql.Click += new System.EventHandler(this.LinkToMySql_Click);
            // 
            // chlTables
            // 
            this.chlTables.FormattingEnabled = true;
            this.chlTables.Location = new System.Drawing.Point(26, 103);
            this.chlTables.Name = "chlTables";
            this.chlTables.Size = new System.Drawing.Size(138, 308);
            this.chlTables.TabIndex = 3;
            // 
            // btnGenerateModel
            // 
            this.btnGenerateModel.Location = new System.Drawing.Point(185, 103);
            this.btnGenerateModel.Name = "btnGenerateModel";
            this.btnGenerateModel.Size = new System.Drawing.Size(75, 39);
            this.btnGenerateModel.TabIndex = 4;
            this.btnGenerateModel.Text = "生成实体";
            this.btnGenerateModel.UseVisualStyleBackColor = true;
            this.btnGenerateModel.Click += new System.EventHandler(this.btnGenerateModel_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(283, 103);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(519, 396);
            this.txtResult.TabIndex = 5;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(94, 53);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 21);
            this.txtHost.TabIndex = 6;
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(59, 56);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(29, 12);
            this.lbHost.TabIndex = 7;
            this.lbHost.Text = "主机";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "端口";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(244, 52);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(56, 21);
            this.txtPort.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "用户名";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(353, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 11;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(459, 56);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(29, 12);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(494, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "数据库";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(647, 51);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 21);
            this.txtDB.TabIndex = 15;
            // 
            // btnLinkDB2
            // 
            this.btnLinkDB2.Location = new System.Drawing.Point(766, 50);
            this.btnLinkDB2.Name = "btnLinkDB2";
            this.btnLinkDB2.Size = new System.Drawing.Size(57, 23);
            this.btnLinkDB2.TabIndex = 16;
            this.btnLinkDB2.Text = "连接";
            this.btnLinkDB2.UseVisualStyleBackColor = true;
            this.btnLinkDB2.Click += new System.EventHandler(this.btnLinkDB2_Click);
            // 
            // ModelGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 517);
            this.Controls.Add(this.btnLinkDB2);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnGenerateModel);
            this.Controls.Add(this.chlTables);
            this.Controls.Add(this.btnLinkToMySql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectstring);
            this.Name = "ModelGenerate";
            this.Text = "实体生成器";
            this.Load += new System.EventHandler(this.ModelGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLinkToMySql;
        private System.Windows.Forms.CheckedListBox chlTables;
        private System.Windows.Forms.Button btnGenerateModel;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Button btnLinkDB2;
    }
}