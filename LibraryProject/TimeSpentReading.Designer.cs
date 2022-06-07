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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSpentReading));
            this.GoBack = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BookCover1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.White;
            this.GoBack.BackgroundImage = global::LibraryProject.Properties.Resources.GoBack;
            this.GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack.ForeColor = System.Drawing.Color.Transparent;
            this.GoBack.Location = new System.Drawing.Point(13, 13);
            this.GoBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(47, 43);
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
            this.CloseButton.Location = new System.Drawing.Point(1420, 13);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 43);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(183, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 123);
            this.panel3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(338, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(511, 88);
            this.label6.TabIndex = 1;
            this.label6.Text = "Books Reviews";
            // 
            // BookCover1
            // 
            this.BookCover1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCover1.InitialImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.BookCover1.Location = new System.Drawing.Point(183, 215);
            this.BookCover1.Margin = new System.Windows.Forms.Padding(4);
            this.BookCover1.Name = "BookCover1";
            this.BookCover1.Size = new System.Drawing.Size(248, 284);
            this.BookCover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookCover1.TabIndex = 21;
            this.BookCover1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(528, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 49);
            this.label1.TabIndex = 22;
            this.label1.Text = "Book\'s Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(532, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(806, 177);
            this.label4.TabIndex = 25;
            this.label4.Text = " Review";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(532, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 177);
            this.label2.TabIndex = 28;
            this.label2.Text = "Review";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(528, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 49);
            this.label3.TabIndex = 27;
            this.label3.Text = "Book\'s Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.pictureBox1.Location = new System.Drawing.Point(183, 539);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // TimeSpentReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1480, 836);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookCover1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimeSpentReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeSpentReading";
            this.Load += new System.EventHandler(this.TimeSpentReading_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox BookCover1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}