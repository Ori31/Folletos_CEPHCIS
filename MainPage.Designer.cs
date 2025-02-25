namespace SoftwareFolletosCEPHCIS
{
    partial class MainPage
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.MainPageTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.GuestLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPageTitle
            // 
            this.MainPageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPageTitle.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MainPageTitle.ForeColor = System.Drawing.Color.Navy;
            this.MainPageTitle.Location = new System.Drawing.Point(335, 12);
            this.MainPageTitle.Name = "MainPageTitle";
            this.MainPageTitle.Size = new System.Drawing.Size(302, 63);
            this.MainPageTitle.TabIndex = 0;
            this.MainPageTitle.Text = "Biblioteca del Centro Peninsular en Humanidades y Ciencias Sociales";
            this.MainPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(850, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // UsernameText
            // 
            this.UsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameText.ForeColor = System.Drawing.Color.White;
            this.UsernameText.Location = new System.Drawing.Point(21, 4);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(90, 23);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.UsernameText);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(421, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 29);
            this.panel1.TabIndex = 4;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordText.ForeColor = System.Drawing.Color.White;
            this.PasswordText.Location = new System.Drawing.Point(3, 5);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(108, 23);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.Text = "Contraseña";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.PasswordText);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(421, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 31);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // User
            // 
            this.User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User.BackColor = System.Drawing.SystemColors.Control;
            this.User.Location = new System.Drawing.Point(390, 285);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(173, 22);
            this.User.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.Location = new System.Drawing.Point(390, 374);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(173, 22);
            this.Password.TabIndex = 7;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(308, 434);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(149, 53);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Acceder como Administrador";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // GuestLoginButton
            // 
            this.GuestLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuestLoginButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.GuestLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestLoginButton.ForeColor = System.Drawing.Color.White;
            this.GuestLoginButton.Location = new System.Drawing.Point(515, 434);
            this.GuestLoginButton.Name = "GuestLoginButton";
            this.GuestLoginButton.Size = new System.Drawing.Size(146, 53);
            this.GuestLoginButton.TabIndex = 9;
            this.GuestLoginButton.Text = "Acceder como Invitado";
            this.GuestLoginButton.UseVisualStyleBackColor = false;
            this.GuestLoginButton.Click += new System.EventHandler(this.GuestLoginButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(310, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consulta de Folletos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuestLoginButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainPageTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainPageTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button GuestLoginButton;
        private System.Windows.Forms.Label label1;
    }
}

