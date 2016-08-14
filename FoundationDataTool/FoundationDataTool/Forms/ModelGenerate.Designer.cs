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
            this.chlTables.Location = new System.Drawing.Point(42, 93);
            this.chlTables.Name = "chlTables";
            this.chlTables.Size = new System.Drawing.Size(138, 308);
            this.chlTables.TabIndex = 3;
            // 
            // btnGenerateModel
            // 
            this.btnGenerateModel.Location = new System.Drawing.Point(229, 93);
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
            this.txtResult.Location = new System.Drawing.Point(335, 93);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(519, 396);
            this.txtResult.TabIndex = 5;
            // 
            // ModelGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 517);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnGenerateModel);
            this.Controls.Add(this.chlTables);
            this.Controls.Add(this.btnLinkToMySql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectstring);
            this.Name = "ModelGenerate";
            this.Text = "ModelGenerate";
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
    }
}