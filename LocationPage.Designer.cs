namespace SoftwareFolletosCEPHCIS
{
    partial class LocationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationPage));
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPageTitle = new System.Windows.Forms.Label();
            this.FolletoIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameText = new System.Windows.Forms.Label();
            this.LocationPanel = new System.Windows.Forms.Panel();
            this.LocationText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolletoIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.LocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.Location = new System.Drawing.Point(658, 53);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(22, 22);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 11;
            this.SearchIcon.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Location = new System.Drawing.Point(683, 53);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(259, 22);
            this.SearchBox.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainPageTitle
            // 
            this.MainPageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPageTitle.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MainPageTitle.ForeColor = System.Drawing.Color.Navy;
            this.MainPageTitle.Location = new System.Drawing.Point(184, 12);
            this.MainPageTitle.Name = "MainPageTitle";
            this.MainPageTitle.Size = new System.Drawing.Size(302, 80);
            this.MainPageTitle.TabIndex = 7;
            this.MainPageTitle.Text = "Biblioteca del Centro Peninsular en Humanidades y Ciencias Sociales";
            this.MainPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FolletoIcon
            // 
            this.FolletoIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolletoIcon.Image = ((System.Drawing.Image)(resources.GetObject("FolletoIcon.Image")));
            this.FolletoIcon.Location = new System.Drawing.Point(341, 156);
            this.FolletoIcon.Name = "FolletoIcon";
            this.FolletoIcon.Size = new System.Drawing.Size(80, 80);
            this.FolletoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FolletoIcon.TabIndex = 12;
            this.FolletoIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Location = new System.Drawing.Point(341, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 80);
            this.panel1.TabIndex = 13;
            // 
            // NameText
            // 
            this.NameText.AutoEllipsis = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.NameText.Location = new System.Drawing.Point(85, 0);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(189, 78);
            this.NameText.TabIndex = 14;
            this.NameText.Text = "Nombre del Folleto";
            this.NameText.Click += new System.EventHandler(this.NameText_Click);
            // 
            // LocationPanel
            // 
            this.LocationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LocationPanel.Controls.Add(this.label1);
            this.LocationPanel.Controls.Add(this.LocationText);
            this.LocationPanel.Location = new System.Drawing.Point(285, 262);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(395, 192);
            this.LocationPanel.TabIndex = 14;
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = true;
            this.LocationText.Location = new System.Drawing.Point(130, 85);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(134, 16);
            this.LocationText.TabIndex = 0;
            this.LocationText.Text = "Ubicación del Folleto";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(418, 495);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(123, 47);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "Regresar";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 186);
            this.label1.TabIndex = 1;
            // 
            // LocationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LocationPanel);
            this.Controls.Add(this.FolletoIcon);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainPageTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LocationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicación del Folleto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationPage_FormClosing);
            this.Load += new System.EventHandler(this.LocationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolletoIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.LocationPanel.ResumeLayout(false);
            this.LocationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainPageTitle;
        private System.Windows.Forms.PictureBox FolletoIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Panel LocationPanel;
        private System.Windows.Forms.Label LocationText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
    }
}