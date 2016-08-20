namespace FoundationDataTool.Forms
{
    partial class QrCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QrCodeForm));
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.btnGenerateQrCode = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // picQrCode
            // 
            this.picQrCode.Location = new System.Drawing.Point(546, 22);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(234, 231);
            this.picQrCode.TabIndex = 3;
            this.picQrCode.TabStop = false;
            // 
            // btnGenerateQrCode
            // 
            this.btnGenerateQrCode.Location = new System.Drawing.Point(111, 187);
            this.btnGenerateQrCode.Name = "btnGenerateQrCode";
            this.btnGenerateQrCode.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateQrCode.TabIndex = 2;
            this.btnGenerateQrCode.Text = "生成二维码";
            this.btnGenerateQrCode.UseVisualStyleBackColor = true;
            this.btnGenerateQrCode.Click += new System.EventHandler(this.btnGenerateQrCode_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(111, 22);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(330, 132);
            this.txtInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "信息";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(240, 187);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(103, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "上传二维码解析";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // QrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 464);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picQrCode);
            this.Controls.Add(this.btnGenerateQrCode);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QrCodeForm";
            this.Text = "Qr";
            this.Load += new System.EventHandler(this.QrCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGenerateQrCode;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.Button btnUpload;
    }
}