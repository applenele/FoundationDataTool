namespace FoundationDataTool.Forms
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.dgwConfig = new System.Windows.Forms.DataGridView();
            this.ConfigListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConfig)).BeginInit();
            this.ConfigListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwConfig
            // 
            this.dgwConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConfig.Location = new System.Drawing.Point(29, 40);
            this.dgwConfig.Name = "dgwConfig";
            this.dgwConfig.RowTemplate.Height = 23;
            this.dgwConfig.Size = new System.Drawing.Size(364, 250);
            this.dgwConfig.TabIndex = 0;
            this.dgwConfig.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwConfig_CellMouseDown);
            // 
            // ConfigListContextMenu
            // 
            this.ConfigListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editConfigToolStripMenuItem,
            this.deleteConfigToolStripMenuItem});
            this.ConfigListContextMenu.Name = "ConfigListContextMenu";
            this.ConfigListContextMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // editConfigToolStripMenuItem
            // 
            this.editConfigToolStripMenuItem.Name = "editConfigToolStripMenuItem";
            this.editConfigToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editConfigToolStripMenuItem.Text = "编辑配置";
            this.editConfigToolStripMenuItem.Click += new System.EventHandler(this.editConfigToolStripMenuItem_Click);
            // 
            // deleteConfigToolStripMenuItem
            // 
            this.deleteConfigToolStripMenuItem.Name = "deleteConfigToolStripMenuItem";
            this.deleteConfigToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteConfigToolStripMenuItem.Text = "删除配置";
            this.deleteConfigToolStripMenuItem.Click += new System.EventHandler(this.deleteConfigToolStripMenuItem_Click);
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Location = new System.Drawing.Point(29, 11);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(75, 23);
            this.btnAddConfig.TabIndex = 1;
            this.btnAddConfig.Text = "增加配置";
            this.btnAddConfig.UseVisualStyleBackColor = true;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(110, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 322);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.dgwConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwConfig)).EndInit();
            this.ConfigListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwConfig;
        private System.Windows.Forms.ContextMenuStrip ConfigListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteConfigToolStripMenuItem;
        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.Button btnRefresh;
    }
}