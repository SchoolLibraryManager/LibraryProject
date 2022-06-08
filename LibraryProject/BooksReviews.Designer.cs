namespace LibraryProject
{
    partial class BooksReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksReviews));
            this.GoBack = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BookCover1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BookCover2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover2)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.Transparent;
            this.GoBack.BackgroundImage = global::LibraryProject.Properties.Resources.GoBack;
            this.GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBack.FlatAppearance.BorderSize = 0;
            this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack.ForeColor = System.Drawing.Color.Transparent;
            this.GoBack.Location = new System.Drawing.Point(3, 2);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(30, 30);
            this.GoBack.TabIndex = 5;
            this.GoBack.UseVisualStyleBackColor = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(1079, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(137, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 100);
            this.panel3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(254, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(410, 71);
            this.label6.TabIndex = 1;
            this.label6.Text = "Books Reviews";
            // 
            // BookCover1
            // 
            this.BookCover1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCover1.InitialImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.BookCover1.Location = new System.Drawing.Point(137, 175);
            this.BookCover1.Name = "BookCover1";
            this.BookCover1.Size = new System.Drawing.Size(186, 231);
            this.BookCover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookCover1.TabIndex = 21;
            this.BookCover1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(396, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Book\'s Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(399, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(604, 144);
            this.label4.TabIndex = 25;
            this.label4.Text = " Review";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(399, 525);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 144);
            this.label2.TabIndex = 28;
            this.label2.Text = "Review";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(396, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "Book\'s Name";
            // 
            // BookCover2
            // 
            this.BookCover2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCover2.InitialImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.BookCover2.Location = new System.Drawing.Point(137, 438);
            this.BookCover2.Name = "BookCover2";
            this.BookCover2.Size = new System.Drawing.Size(186, 231);
            this.BookCover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookCover2.TabIndex = 26;
            this.BookCover2.TabStop = false;
            // 
            // BooksReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1110, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookCover2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookCover1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BooksReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeSpentReading";
            this.Load += new System.EventHandler(this.BooksReviews_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover2)).EndInit();
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
        private System.Windows.Forms.PictureBox BookCover2;
    }
}