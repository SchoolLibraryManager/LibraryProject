namespace LibraryProject
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.BookCover3 = new System.Windows.Forms.PictureBox();
            this.BookCover2 = new System.Windows.Forms.PictureBox();
            this.BookCover1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover1)).BeginInit();
            this.SuspendLayout();
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.White;
            this.RightButton.BackgroundImage = global::LibraryProject.Properties.Resources.GoRight;
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.ForeColor = System.Drawing.Color.Transparent;
            this.RightButton.Location = new System.Drawing.Point(969, 283);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(35, 35);
            this.RightButton.TabIndex = 9;
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.White;
            this.LeftButton.BackgroundImage = global::LibraryProject.Properties.Resources.GoBack;
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.ForeColor = System.Drawing.Color.Transparent;
            this.LeftButton.Location = new System.Drawing.Point(64, 283);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(35, 35);
            this.LeftButton.TabIndex = 8;
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // BookCover3
            // 
            this.BookCover3.Location = new System.Drawing.Point(696, 148);
            this.BookCover3.Name = "BookCover3";
            this.BookCover3.Size = new System.Drawing.Size(236, 326);
            this.BookCover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover3.TabIndex = 7;
            this.BookCover3.TabStop = false;
            this.BookCover3.Click += new System.EventHandler(this.BookCover3_Click);
            // 
            // BookCover2
            // 
            this.BookCover2.Location = new System.Drawing.Point(427, 148);
            this.BookCover2.Name = "BookCover2";
            this.BookCover2.Size = new System.Drawing.Size(236, 326);
            this.BookCover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover2.TabIndex = 6;
            this.BookCover2.TabStop = false;
            this.BookCover2.Click += new System.EventHandler(this.BookCover2_Click);
            // 
            // BookCover1
            // 
            this.BookCover1.Location = new System.Drawing.Point(154, 148);
            this.BookCover1.Name = "BookCover1";
            this.BookCover1.Size = new System.Drawing.Size(236, 326);
            this.BookCover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover1.TabIndex = 5;
            this.BookCover1.TabStop = false;
            this.BookCover1.Click += new System.EventHandler(this.BookCover1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::LibraryProject.Properties.Resources.GoBack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(1052, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 634);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.BookCover3);
            this.Controls.Add(this.BookCover2);
            this.Controls.Add(this.BookCover1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookCover3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BookCover1;
        private System.Windows.Forms.PictureBox BookCover2;
        private System.Windows.Forms.PictureBox BookCover3;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
    }
}