namespace SoftwareFolletosCEPHCIS
{
    partial class EditPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPage));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeywordText = new System.Windows.Forms.Label();
            this.AutorText = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.txt_ubi = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.Nomfolleto = new System.Windows.Forms.TextBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.LocationText = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(850, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // KeywordText
            // 
            this.KeywordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeywordText.AutoSize = true;
            this.KeywordText.Location = new System.Drawing.Point(178, 390);
            this.KeywordText.Name = "KeywordText";
            this.KeywordText.Size = new System.Drawing.Size(100, 16);
            this.KeywordText.TabIndex = 29;
            this.KeywordText.Text = "Palabras Clave";
            // 
            // AutorText
            // 
            this.AutorText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutorText.AutoSize = true;
            this.AutorText.Location = new System.Drawing.Point(230, 350);
            this.AutorText.Name = "AutorText";
            this.AutorText.Size = new System.Drawing.Size(38, 16);
            this.AutorText.TabIndex = 28;
            this.AutorText.Text = "Autor";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionText.AutoSize = true;
            this.DescriptionText.Location = new System.Drawing.Point(123, 232);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(145, 16);
            this.DescriptionText.TabIndex = 27;
            this.DescriptionText.Text = "Descripción del Folleto";
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(146, 131);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(122, 16);
            this.NameText.TabIndex = 26;
            this.NameText.Text = "Nombre del Folleto";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.Location = new System.Drawing.Point(413, 538);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 37);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(284, 538);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 37);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UploadButton.BackColor = System.Drawing.Color.Navy;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.UploadButton.ForeColor = System.Drawing.Color.White;
            this.UploadButton.Location = new System.Drawing.Point(322, 427);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(151, 29);
            this.UploadButton.TabIndex = 23;
            this.UploadButton.Text = "Editar Archivo";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // txt_ubi
            // 
            this.txt_ubi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ubi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ubi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ubi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ubi.Location = new System.Drawing.Point(286, 462);
            this.txt_ubi.Multiline = true;
            this.txt_ubi.Name = "txt_ubi";
            this.txt_ubi.Size = new System.Drawing.Size(227, 49);
            this.txt_ubi.TabIndex = 22;
            this.txt_ubi.TextChanged += new System.EventHandler(this.txt_ubi_TextChanged);
            // 
            // txt_clave
            // 
            this.txt_clave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_clave.BackColor = System.Drawing.SystemColors.Control;
            this.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_clave.Location = new System.Drawing.Point(284, 375);
            this.txt_clave.Multiline = true;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(229, 46);
            this.txt_clave.TabIndex = 21;
            this.txt_clave.TextChanged += new System.EventHandler(this.txt_clave_TextChanged);
            // 
            // Autor
            // 
            this.Autor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Autor.BackColor = System.Drawing.SystemColors.Control;
            this.Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Autor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Autor.Location = new System.Drawing.Point(284, 347);
            this.Autor.Multiline = true;
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(229, 22);
            this.Autor.TabIndex = 20;
            this.Autor.TextChanged += new System.EventHandler(this.Autor_TextChanged);
            // 
            // txt_des
            // 
            this.txt_des.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_des.BackColor = System.Drawing.SystemColors.Control;
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_des.Location = new System.Drawing.Point(284, 156);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(229, 185);
            this.txt_des.TabIndex = 19;
            this.txt_des.TextChanged += new System.EventHandler(this.txt_des_TextChanged);
            // 
            // Nomfolleto
            // 
            this.Nomfolleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nomfolleto.BackColor = System.Drawing.SystemColors.Control;
            this.Nomfolleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nomfolleto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nomfolleto.Location = new System.Drawing.Point(284, 128);
            this.Nomfolleto.Multiline = true;
            this.Nomfolleto.Name = "Nomfolleto";
            this.Nomfolleto.Size = new System.Drawing.Size(229, 22);
            this.Nomfolleto.TabIndex = 18;
            this.Nomfolleto.TextChanged += new System.EventHandler(this.Nomfolleto_TextChanged);
            // 
            // MainTitle
            // 
            this.MainTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(390, 58);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(205, 36);
            this.MainTitle.TabIndex = 17;
            this.MainTitle.Text = "Editar Folleto";
            // 
            // LocationText
            // 
            this.LocationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationText.AutoSize = true;
            this.LocationText.Location = new System.Drawing.Point(146, 478);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(134, 16);
            this.LocationText.TabIndex = 30;
            this.LocationText.Text = "Ubicación del Folleto";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteButton.Location = new System.Drawing.Point(322, 594);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(151, 36);
            this.DeleteButton.TabIndex = 33;
            this.DeleteButton.Text = "Eliminar Folleto";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UploadDialog
            // 
            this.UploadDialog.FileName = "Subir Folleto";
            this.UploadDialog.Title = "Seleccionar Folleto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(579, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(201, 380);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.BackColor = System.Drawing.SystemColors.Control;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_id.Location = new System.Drawing.Point(284, 100);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(229, 22);
            this.txt_id.TabIndex = 35;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KeywordText);
            this.Controls.Add(this.AutorText);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.txt_ubi);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.Nomfolleto);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.LocationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Folleto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPage_FormClosing);
            this.Load += new System.EventHandler(this.EditPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label KeywordText;
        private System.Windows.Forms.Label AutorText;
        private System.Windows.Forms.Label DescriptionText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox txt_ubi;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox Nomfolleto;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label LocationText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.OpenFileDialog UploadDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
    }
}