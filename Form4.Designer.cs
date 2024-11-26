namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.nFolleto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nomfolleto = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_ubi = new System.Windows.Forms.TextBox();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Folletos";
            // 
            // nFolleto
            // 
            this.nFolleto.AutoSize = true;
            this.nFolleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nFolleto.Location = new System.Drawing.Point(234, 129);
            this.nFolleto.Name = "nFolleto";
            this.nFolleto.Size = new System.Drawing.Size(123, 17);
            this.nFolleto.TabIndex = 1;
            this.nFolleto.Text = "Nombre del folleto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Palabras clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ubicacion del folleto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion del folleto";
            // 
            // Nomfolleto
            // 
            this.Nomfolleto.Location = new System.Drawing.Point(458, 127);
            this.Nomfolleto.Name = "Nomfolleto";
            this.Nomfolleto.Size = new System.Drawing.Size(278, 22);
            this.Nomfolleto.TabIndex = 6;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(458, 167);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(281, 22);
            this.Autor.TabIndex = 7;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(458, 206);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(280, 22);
            this.txt_clave.TabIndex = 8;
            // 
            // txt_ubi
            // 
            this.txt_ubi.Location = new System.Drawing.Point(458, 249);
            this.txt_ubi.Name = "txt_ubi";
            this.txt_ubi.Size = new System.Drawing.Size(279, 22);
            this.txt_ubi.TabIndex = 9;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(458, 286);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(278, 22);
            this.txt_des.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar folleto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.loggo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "Centro Peninsular en Humanidades y Ciencias Sociales";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_ubi);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Nomfolleto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nFolleto);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nFolleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nomfolleto;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_ubi;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}