namespace FoundationDataTool.Forms
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.cbmCity = new System.Windows.Forms.ComboBox();
            this.cbmCounty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(325, 164);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(75, 23);
            this.btnGetWeather.TabIndex = 0;
            this.btnGetWeather.Text = "获取天气";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // cbmCity
            // 
            this.cbmCity.FormattingEnabled = true;
            this.cbmCity.Location = new System.Drawing.Point(74, 53);
            this.cbmCity.Name = "cbmCity";
            this.cbmCity.Size = new System.Drawing.Size(121, 20);
            this.cbmCity.TabIndex = 1;
            this.cbmCity.SelectedIndexChanged += new System.EventHandler(this.cbmCity_SelectedIndexChanged);
            // 
            // cbmCounty
            // 
            this.cbmCounty.FormattingEnabled = true;
            this.cbmCounty.Location = new System.Drawing.Point(248, 53);
            this.cbmCounty.Name = "cbmCounty";
            this.cbmCounty.Size = new System.Drawing.Size(121, 20);
            this.cbmCounty.TabIndex = 2;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 399);
            this.Controls.Add(this.cbmCounty);
            this.Controls.Add(this.cbmCity);
            this.Controls.Add(this.btnGetWeather);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherForm";
            this.Text = "WeatherForm";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.ComboBox cbmCity;
        private System.Windows.Forms.ComboBox cbmCounty;
    }
}