namespace LibraryProject
{
    partial class TimeSpentReading
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GoBack = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.White;
            this.GoBack.BackgroundImage = global::LibraryProject.Properties.Resources.GoBack;
            this.GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack.ForeColor = System.Drawing.Color.Transparent;
            this.GoBack.Location = new System.Drawing.Point(0, 0);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(35, 35);
            this.GoBack.TabIndex = 5;
            this.GoBack.UseVisualStyleBackColor = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(1053, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 81);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1065, 347);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // TimeSpentReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 634);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeSpentReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeSpentReading";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}