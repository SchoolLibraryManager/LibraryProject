﻿namespace LibraryProject
{
    partial class BookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfo));
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FavouriteBtn = new System.Windows.Forms.Button();
            this.RemoveMeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::LibraryProject.Properties.Resources.GoBack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // FavouriteBtn
            // 
            this.FavouriteBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteBtn.Location = new System.Drawing.Point(840, 559);
            this.FavouriteBtn.Name = "FavouriteBtn";
            this.FavouriteBtn.Size = new System.Drawing.Size(237, 63);
            this.FavouriteBtn.TabIndex = 7;
            this.FavouriteBtn.Text = "FavouriteMe";
            this.FavouriteBtn.UseVisualStyleBackColor = true;
            this.FavouriteBtn.Click += new System.EventHandler(this.FavouriteBtn_Click);
            // 
            // RemoveMeBtn
            // 
            this.RemoveMeBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMeBtn.Location = new System.Drawing.Point(840, 559);
            this.RemoveMeBtn.Name = "RemoveMeBtn";
            this.RemoveMeBtn.Size = new System.Drawing.Size(237, 63);
            this.RemoveMeBtn.TabIndex = 8;
            this.RemoveMeBtn.Text = "RemoveMe";
            this.RemoveMeBtn.UseVisualStyleBackColor = true;
            this.RemoveMeBtn.Click += new System.EventHandler(this.RemoveMeBtn_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 634);
            this.Controls.Add(this.FavouriteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RemoveMeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfo";
            this.Load += new System.EventHandler(this.BookInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FavouriteBtn;
        private System.Windows.Forms.Button RemoveMeBtn;
    }
}