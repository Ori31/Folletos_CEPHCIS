namespace SoftwareFolletosCEPHCIS
{
    partial class AddPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPage));
            this.MainTitle = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.AutorBox = new System.Windows.Forms.TextBox();
            this.KeywordBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.Label();
            this.AutorText = new System.Windows.Forms.Label();
            this.KeywordText = new System.Windows.Forms.Label();
            this.LocationText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(375, 57);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(235, 36);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Agregar Folleto";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameBox.Location = new System.Drawing.Point(381, 146);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(229, 22);
            this.NameBox.TabIndex = 1;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DescriptionBox.Location = new System.Drawing.Point(381, 174);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(229, 185);
            this.DescriptionBox.TabIndex = 2;
            // 
            // AutorBox
            // 
            this.AutorBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutorBox.BackColor = System.Drawing.SystemColors.Control;
            this.AutorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutorBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AutorBox.Location = new System.Drawing.Point(381, 365);
            this.AutorBox.Multiline = true;
            this.AutorBox.Name = "AutorBox";
            this.AutorBox.Size = new System.Drawing.Size(229, 22);
            this.AutorBox.TabIndex = 3;
            // 
            // KeywordBox
            // 
            this.KeywordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeywordBox.BackColor = System.Drawing.SystemColors.Control;
            this.KeywordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeywordBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeywordBox.Location = new System.Drawing.Point(381, 393);
            this.KeywordBox.Multiline = true;
            this.KeywordBox.Name = "KeywordBox";
            this.KeywordBox.Size = new System.Drawing.Size(229, 46);
            this.KeywordBox.TabIndex = 4;
            // 
            // LocationBox
            // 
            this.LocationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationBox.BackColor = System.Drawing.SystemColors.Control;
            this.LocationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationBox.Location = new System.Drawing.Point(383, 480);
            this.LocationBox.Multiline = true;
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(227, 49);
            this.LocationBox.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(383, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Seleccionar Archivo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(381, 556);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 37);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.Location = new System.Drawing.Point(510, 556);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 37);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(243, 149);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(122, 16);
            this.NameText.TabIndex = 9;
            this.NameText.Text = "Nombre del Folleto";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionText.AutoSize = true;
            this.DescriptionText.Location = new System.Drawing.Point(220, 250);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(145, 16);
            this.DescriptionText.TabIndex = 10;
            this.DescriptionText.Text = "Descripción del Folleto";
            this.DescriptionText.Click += new System.EventHandler(this.label1_Click);
            // 
            // AutorText
            // 
            this.AutorText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutorText.AutoSize = true;
            this.AutorText.Location = new System.Drawing.Point(327, 368);
            this.AutorText.Name = "AutorText";
            this.AutorText.Size = new System.Drawing.Size(38, 16);
            this.AutorText.TabIndex = 11;
            this.AutorText.Text = "Autor";
            // 
            // KeywordText
            // 
            this.KeywordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeywordText.AutoSize = true;
            this.KeywordText.Location = new System.Drawing.Point(275, 408);
            this.KeywordText.Name = "KeywordText";
            this.KeywordText.Size = new System.Drawing.Size(100, 16);
            this.KeywordText.TabIndex = 12;
            this.KeywordText.Text = "Palabras Clave";
            // 
            // LocationText
            // 
            this.LocationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationText.AutoSize = true;
            this.LocationText.Location = new System.Drawing.Point(243, 496);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(134, 16);
            this.LocationText.TabIndex = 13;
            this.LocationText.Text = "Ubicación del Folleto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(850, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KeywordText);
            this.Controls.Add(this.AutorText);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.KeywordBox);
            this.Controls.Add(this.AutorBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.LocationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Folleto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPage_FormClosing);
            this.Load += new System.EventHandler(this.AddPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox AutorBox;
        private System.Windows.Forms.TextBox KeywordBox;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label DescriptionText;
        private System.Windows.Forms.Label AutorText;
        private System.Windows.Forms.Label KeywordText;
        private System.Windows.Forms.Label LocationText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}