namespace LibraryProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.WTRLabelMain = new System.Windows.Forms.Label();
            this.TSRLabelMain = new System.Windows.Forms.Label();
            this.LibraryLabelMain = new System.Windows.Forms.Label();
            this.FavouriteLabelMain = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LibraryBtn = new System.Windows.Forms.Button();
            this.Favourite = new System.Windows.Forms.Button();
            this.TSR = new System.Windows.Forms.Button();
            this.WTR = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.WTRLabelMain);
            this.panel1.Controls.Add(this.TSRLabelMain);
            this.panel1.Controls.Add(this.LibraryLabelMain);
            this.panel1.Controls.Add(this.FavouriteLabelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 780);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 708);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "User";
            this.label10.Click += new System.EventHandler(this.UserPanel_Click);
            // 
            // WTRLabelMain
            // 
            this.WTRLabelMain.AutoSize = true;
            this.WTRLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTRLabelMain.Location = new System.Drawing.Point(65, 153);
            this.WTRLabelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WTRLabelMain.Name = "WTRLabelMain";
            this.WTRLabelMain.Size = new System.Drawing.Size(143, 25);
            this.WTRLabelMain.TabIndex = 1;
            this.WTRLabelMain.Text = "Want to read";
            this.WTRLabelMain.Click += new System.EventHandler(this.WTRLabelMain_Click);
            // 
            // TSRLabelMain
            // 
            this.TSRLabelMain.AutoSize = true;
            this.TSRLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSRLabelMain.Location = new System.Drawing.Point(35, 79);
            this.TSRLabelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TSRLabelMain.Name = "TSRLabelMain";
            this.TSRLabelMain.Size = new System.Drawing.Size(206, 25);
            this.TSRLabelMain.TabIndex = 1;
            this.TSRLabelMain.Text = "Time spent reading";
            this.TSRLabelMain.Click += new System.EventHandler(this.TSRLabelMain_Click);
            // 
            // LibraryLabelMain
            // 
            this.LibraryLabelMain.AutoSize = true;
            this.LibraryLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryLabelMain.Location = new System.Drawing.Point(99, 191);
            this.LibraryLabelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LibraryLabelMain.Name = "LibraryLabelMain";
            this.LibraryLabelMain.Size = new System.Drawing.Size(83, 25);
            this.LibraryLabelMain.TabIndex = 1;
            this.LibraryLabelMain.Text = "Library";
            this.LibraryLabelMain.Click += new System.EventHandler(this.LibraryLabelMain_Click);
            // 
            // FavouriteLabelMain
            // 
            this.FavouriteLabelMain.AutoSize = true;
            this.FavouriteLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteLabelMain.Location = new System.Drawing.Point(49, 117);
            this.FavouriteLabelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FavouriteLabelMain.Name = "FavouriteLabelMain";
            this.FavouriteLabelMain.Size = new System.Drawing.Size(172, 25);
            this.FavouriteLabelMain.TabIndex = 1;
            this.FavouriteLabelMain.Text = "Favourite books";
            this.FavouriteLabelMain.Click += new System.EventHandler(this.FavouriteLabelMain_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(323, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 220);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome (Welcoming Image)";
            // 
            // LibraryBtn
            // 
            this.LibraryBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.LibraryBtn.Location = new System.Drawing.Point(445, 481);
            this.LibraryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibraryBtn.Name = "LibraryBtn";
            this.LibraryBtn.Size = new System.Drawing.Size(352, 137);
            this.LibraryBtn.TabIndex = 1;
            this.LibraryBtn.Text = "Library";
            this.LibraryBtn.UseVisualStyleBackColor = true;
            this.LibraryBtn.Click += new System.EventHandler(this.LibraryBtn_Click);
            // 
            // Favourite
            // 
            this.Favourite.Font = new System.Drawing.Font("Verdana", 12F);
            this.Favourite.Location = new System.Drawing.Point(445, 303);
            this.Favourite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Favourite.Name = "Favourite";
            this.Favourite.Size = new System.Drawing.Size(352, 137);
            this.Favourite.TabIndex = 4;
            this.Favourite.Text = "Favourite books";
            this.Favourite.UseVisualStyleBackColor = true;
            this.Favourite.Click += new System.EventHandler(this.Favourite_Click);
            // 
            // TSR
            // 
            this.TSR.Font = new System.Drawing.Font("Verdana", 12F);
            this.TSR.Location = new System.Drawing.Point(936, 389);
            this.TSR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TSR.Name = "TSR";
            this.TSR.Size = new System.Drawing.Size(352, 137);
            this.TSR.TabIndex = 5;
            this.TSR.Text = "Time spent reading";
            this.TSR.UseVisualStyleBackColor = true;
            this.TSR.Click += new System.EventHandler(this.TSR_Click);
            // 
            // WTR
            // 
            this.WTR.Font = new System.Drawing.Font("Verdana", 12F);
            this.WTR.Location = new System.Drawing.Point(936, 558);
            this.WTR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WTR.Name = "WTR";
            this.WTR.Size = new System.Drawing.Size(352, 137);
            this.WTR.TabIndex = 2;
            this.WTR.Text = "Want to read";
            this.WTR.UseVisualStyleBackColor = true;
            this.WTR.Click += new System.EventHandler(this.WTR_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = global::LibraryProject.Properties.Resources.CloseProgramm;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(1389, 6);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 43);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1449, 764);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WTR);
            this.Controls.Add(this.TSR);
            this.Controls.Add(this.Favourite);
            this.Controls.Add(this.LibraryBtn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label WTRLabelMain;
        private System.Windows.Forms.Label TSRLabelMain;
        private System.Windows.Forms.Label LibraryLabelMain;
        private System.Windows.Forms.Label FavouriteLabelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LibraryBtn;
        private System.Windows.Forms.Button Favourite;
        private System.Windows.Forms.Button TSR;
        private System.Windows.Forms.Button WTR;
        private System.Windows.Forms.Label label1;
    }
}

