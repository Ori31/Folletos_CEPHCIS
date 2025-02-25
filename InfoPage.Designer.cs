namespace SoftwareFolletosCEPHCIS
{
    partial class InfoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPage));
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPageTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameText = new System.Windows.Forms.Label();
            this.AutorText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KeywordText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DescText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.LocationButton = new System.Windows.Forms.Button();
            this.VirtualButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.Location = new System.Drawing.Point(658, 53);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(22, 22);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 16;
            this.SearchIcon.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Location = new System.Drawing.Point(683, 53);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(259, 22);
            this.SearchBox.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainPageTitle
            // 
            this.MainPageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPageTitle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.MainPageTitle.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MainPageTitle.ForeColor = System.Drawing.Color.Navy;
            this.MainPageTitle.Location = new System.Drawing.Point(184, 12);
            this.MainPageTitle.Name = "MainPageTitle";
            this.MainPageTitle.Size = new System.Drawing.Size(302, 80);
            this.MainPageTitle.TabIndex = 12;
            this.MainPageTitle.Text = "Biblioteca del Centro Peninsular en Humanidades y Ciencias Sociales";
            this.MainPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.NameText);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 29);
            this.panel1.TabIndex = 17;
            // 
            // NameText
            // 
            this.NameText.AutoEllipsis = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameText.ForeColor = System.Drawing.Color.White;
            this.NameText.Location = new System.Drawing.Point(0, 4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(433, 23);
            this.NameText.TabIndex = 3;
            this.NameText.Text = "Nombre del Folleto";
            this.NameText.Click += new System.EventHandler(this.NameText_Click);
            // 
            // AutorText
            // 
            this.AutorText.AutoEllipsis = true;
            this.AutorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AutorText.ForeColor = System.Drawing.Color.White;
            this.AutorText.Location = new System.Drawing.Point(0, 4);
            this.AutorText.Name = "AutorText";
            this.AutorText.Size = new System.Drawing.Size(302, 23);
            this.AutorText.TabIndex = 3;
            this.AutorText.Text = "Autor";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.AutorText);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 29);
            this.panel2.TabIndex = 18;
            // 
            // KeywordText
            // 
            this.KeywordText.AutoEllipsis = true;
            this.KeywordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KeywordText.ForeColor = System.Drawing.Color.White;
            this.KeywordText.Location = new System.Drawing.Point(0, 4);
            this.KeywordText.Name = "KeywordText";
            this.KeywordText.Size = new System.Drawing.Size(385, 23);
            this.KeywordText.TabIndex = 3;
            this.KeywordText.Text = "Palabras Clave";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.KeywordText);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(12, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 29);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 250);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.DescText);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(405, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 29);
            this.panel5.TabIndex = 19;
            // 
            // DescText
            // 
            this.DescText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescText.ForeColor = System.Drawing.Color.White;
            this.DescText.Location = new System.Drawing.Point(21, 4);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(251, 23);
            this.DescText.TabIndex = 3;
            this.DescText.Text = "Breve Descripción";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(274, 295);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 243);
            this.panel6.TabIndex = 20;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(37, 559);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(122, 38);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Regresar";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LocationButton
            // 
            this.LocationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.LocationButton.ForeColor = System.Drawing.Color.White;
            this.LocationButton.Location = new System.Drawing.Point(274, 550);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(123, 47);
            this.LocationButton.TabIndex = 22;
            this.LocationButton.Text = "Ubicación";
            this.LocationButton.UseVisualStyleBackColor = false;
            this.LocationButton.Click += new System.EventHandler(this.LocationButton_Click);
            // 
            // VirtualButton
            // 
            this.VirtualButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VirtualButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.VirtualButton.ForeColor = System.Drawing.Color.White;
            this.VirtualButton.Location = new System.Drawing.Point(613, 550);
            this.VirtualButton.Name = "VirtualButton";
            this.VirtualButton.Size = new System.Drawing.Size(123, 47);
            this.VirtualButton.TabIndex = 23;
            this.VirtualButton.Text = "Ver Folleto Virtual";
            this.VirtualButton.UseVisualStyleBackColor = false;
            this.VirtualButton.Click += new System.EventHandler(this.VirtualButton_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 223);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.VirtualButton);
            this.Controls.Add(this.LocationButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainPageTitle);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InfoPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Folleto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoPage_FormClosing);
            this.Load += new System.EventHandler(this.InfoPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainPageTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label AutorText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label KeywordText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label DescText;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LocationButton;
        private System.Windows.Forms.Button VirtualButton;
        private System.Windows.Forms.Label label1;
    }
}