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
            this.button1 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
    }
}