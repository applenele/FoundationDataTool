namespace FoundationDataTool.Forms
{
    partial class LotteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotteryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstPrize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondPrize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThirdPrize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoPrize = new System.Windows.Forms.TextBox();
            this.btnLottery = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "一等奖比率";
            // 
            // txtFirstPrize
            // 
            this.txtFirstPrize.Location = new System.Drawing.Point(111, 36);
            this.txtFirstPrize.Name = "txtFirstPrize";
            this.txtFirstPrize.Size = new System.Drawing.Size(100, 21);
            this.txtFirstPrize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "二等奖比率";
            // 
            // txtSecondPrize
            // 
            this.txtSecondPrize.Location = new System.Drawing.Point(314, 36);
            this.txtSecondPrize.Name = "txtSecondPrize";
            this.txtSecondPrize.Size = new System.Drawing.Size(100, 21);
            this.txtSecondPrize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "三等奖比率";
            // 
            // txtThirdPrize
            // 
            this.txtThirdPrize.Location = new System.Drawing.Point(111, 81);
            this.txtThirdPrize.Name = "txtThirdPrize";
            this.txtThirdPrize.Size = new System.Drawing.Size(100, 21);
            this.txtThirdPrize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "未中奖比率";
            // 
            // txtNoPrize
            // 
            this.txtNoPrize.Location = new System.Drawing.Point(314, 81);
            this.txtNoPrize.Name = "txtNoPrize";
            this.txtNoPrize.Size = new System.Drawing.Size(100, 21);
            this.txtNoPrize.TabIndex = 7;
            // 
            // btnLottery
            // 
            this.btnLottery.Location = new System.Drawing.Point(314, 296);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(75, 23);
            this.btnLottery.TabIndex = 8;
            this.btnLottery.Text = "抽奖";
            this.btnLottery.UseVisualStyleBackColor = true;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "结果";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(204, 177);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(41, 12);
            this.lbResult.TabIndex = 10;
            this.lbResult.Text = "label6";
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 371);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLottery);
            this.Controls.Add(this.txtNoPrize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThirdPrize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecondPrize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstPrize);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LotteryForm";
            this.Text = "LotteryForm";
            this.Load += new System.EventHandler(this.LotteryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstPrize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecondPrize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThirdPrize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoPrize;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbResult;
    }
}