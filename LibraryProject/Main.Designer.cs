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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 634);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "User";
            // 
            // WTRLabelMain
            // 
            this.WTRLabelMain.AutoSize = true;
            this.WTRLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTRLabelMain.Location = new System.Drawing.Point(49, 124);
            this.WTRLabelMain.Name = "WTRLabelMain";
            this.WTRLabelMain.Size = new System.Drawing.Size(116, 18);
            this.WTRLabelMain.TabIndex = 1;
            this.WTRLabelMain.Text = "Want to read";
            this.WTRLabelMain.Click += new System.EventHandler(this.WTRLabelMain_Click);
            // 
            // TSRLabelMain
            // 
            this.TSRLabelMain.AutoSize = true;
            this.TSRLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSRLabelMain.Location = new System.Drawing.Point(26, 64);
            this.TSRLabelMain.Name = "TSRLabelMain";
            this.TSRLabelMain.Size = new System.Drawing.Size(167, 18);
            this.TSRLabelMain.TabIndex = 1;
            this.TSRLabelMain.Text = "Time spent reading";
            this.TSRLabelMain.Click += new System.EventHandler(this.TSRLabelMain_Click);
            // 
            // LibraryLabelMain
            // 
            this.LibraryLabelMain.AutoSize = true;
            this.LibraryLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryLabelMain.Location = new System.Drawing.Point(74, 155);
            this.LibraryLabelMain.Name = "LibraryLabelMain";
            this.LibraryLabelMain.Size = new System.Drawing.Size(63, 18);
            this.LibraryLabelMain.TabIndex = 1;
            this.LibraryLabelMain.Text = "Library";
            this.LibraryLabelMain.Click += new System.EventHandler(this.LibraryLabelMain_Click);
            // 
            // FavouriteLabelMain
            // 
            this.FavouriteLabelMain.AutoSize = true;
            this.FavouriteLabelMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteLabelMain.Location = new System.Drawing.Point(37, 95);
            this.FavouriteLabelMain.Name = "FavouriteLabelMain";
            this.FavouriteLabelMain.Size = new System.Drawing.Size(137, 18);
            this.FavouriteLabelMain.TabIndex = 1;
            this.FavouriteLabelMain.Text = "Favourite books";
            this.FavouriteLabelMain.Click += new System.EventHandler(this.FavouriteLabelMain_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(242, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 179);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome (Welcoming Image)";
            // 
            // LibraryBtn
            // 
            this.LibraryBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.LibraryBtn.Location = new System.Drawing.Point(334, 453);
            this.LibraryBtn.Name = "LibraryBtn";
            this.LibraryBtn.Size = new System.Drawing.Size(264, 111);
            this.LibraryBtn.TabIndex = 1;
            this.LibraryBtn.Text = "Library";
            this.LibraryBtn.UseVisualStyleBackColor = true;
            this.LibraryBtn.Click += new System.EventHandler(this.LibraryBtn_Click);
            // 
            // Favourite
            // 
            this.Favourite.Font = new System.Drawing.Font("Verdana", 12F);
            this.Favourite.Location = new System.Drawing.Point(334, 316);
            this.Favourite.Name = "Favourite";
            this.Favourite.Size = new System.Drawing.Size(264, 111);
            this.Favourite.TabIndex = 4;
            this.Favourite.Text = "Favourite books";
            this.Favourite.UseVisualStyleBackColor = true;
            this.Favourite.Click += new System.EventHandler(this.Favourite_Click);
            // 
            // TSR
            // 
            this.TSR.Font = new System.Drawing.Font("Verdana", 12F);
            this.TSR.Location = new System.Drawing.Point(702, 316);
            this.TSR.Name = "TSR";
            this.TSR.Size = new System.Drawing.Size(264, 111);
            this.TSR.TabIndex = 5;
            this.TSR.Text = "Time spent reading";
            this.TSR.UseVisualStyleBackColor = true;
            this.TSR.Click += new System.EventHandler(this.TSR_Click);
            // 
            // WTR
            // 
            this.WTR.Font = new System.Drawing.Font("Verdana", 12F);
            this.WTR.Location = new System.Drawing.Point(702, 453);
            this.WTR.Name = "WTR";
            this.WTR.Size = new System.Drawing.Size(264, 111);
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
            this.CloseButton.Location = new System.Drawing.Point(1042, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 634);
            this.Controls.Add(this.WTR);
            this.Controls.Add(this.TSR);
            this.Controls.Add(this.Favourite);
            this.Controls.Add(this.LibraryBtn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

