
namespace Proyecto.Interfaces
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.Logeo_panel = new System.Windows.Forms.Panel();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.btn_verContraSup = new System.Windows.Forms.Button();
            this.btn_verContra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkRegistro = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.login_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.Logeo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_logo
            // 
            this.login_logo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login_logo.Controls.Add(this.label3);
            this.login_logo.Controls.Add(this.pictureBox1);
            this.login_logo.Controls.Add(this.img_logo);
            this.login_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_logo.Location = new System.Drawing.Point(0, 0);
            this.login_logo.Name = "login_logo";
            this.login_logo.Size = new System.Drawing.Size(334, 499);
            this.login_logo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Software creado por";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // img_logo
            // 
            this.img_logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.img_logo.Image = ((System.Drawing.Image)(resources.GetObject("img_logo.Image")));
            this.img_logo.Location = new System.Drawing.Point(0, 220);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(334, 279);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // Logeo_panel
            // 
            this.Logeo_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logeo_panel.Controls.Add(this.comboBoxUsuario);
            this.Logeo_panel.Controls.Add(this.btn_iniciarSesion);
            this.Logeo_panel.Controls.Add(this.btn_verContraSup);
            this.Logeo_panel.Controls.Add(this.btn_verContra);
            this.Logeo_panel.Controls.Add(this.label5);
            this.Logeo_panel.Controls.Add(this.linkLabel1);
            this.Logeo_panel.Controls.Add(this.linkRegistro);
            this.Logeo_panel.Controls.Add(this.label4);
            this.Logeo_panel.Controls.Add(this.btn_Salir);
            this.Logeo_panel.Controls.Add(this.label2);
            this.Logeo_panel.Controls.Add(this.textBox_Password);
            this.Logeo_panel.Controls.Add(this.textBox_Usuario);
            this.Logeo_panel.Controls.Add(this.label_password);
            this.Logeo_panel.Controls.Add(this.label1);
            this.Logeo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logeo_panel.Location = new System.Drawing.Point(334, 0);
            this.Logeo_panel.Name = "Logeo_panel";
            this.Logeo_panel.Size = new System.Drawing.Size(672, 499);
            this.Logeo_panel.TabIndex = 1;
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.Location = new System.Drawing.Point(264, 310);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(131, 32);
            this.btn_iniciarSesion.TabIndex = 30;
            this.btn_iniciarSesion.Text = "Iniciar Sesión";
            this.btn_iniciarSesion.UseVisualStyleBackColor = true;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // btn_verContraSup
            // 
            this.btn_verContraSup.FlatAppearance.BorderSize = 0;
            this.btn_verContraSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verContraSup.Image = ((System.Drawing.Image)(resources.GetObject("btn_verContraSup.Image")));
            this.btn_verContraSup.Location = new System.Drawing.Point(438, 210);
            this.btn_verContraSup.Name = "btn_verContraSup";
            this.btn_verContraSup.Size = new System.Drawing.Size(44, 43);
            this.btn_verContraSup.TabIndex = 29;
            this.btn_verContraSup.UseVisualStyleBackColor = true;
            this.btn_verContraSup.Visible = false;
            this.btn_verContraSup.Click += new System.EventHandler(this.btn_verContraSup_Click);
            // 
            // btn_verContra
            // 
            this.btn_verContra.FlatAppearance.BorderSize = 0;
            this.btn_verContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verContra.Image = ((System.Drawing.Image)(resources.GetObject("btn_verContra.Image")));
            this.btn_verContra.Location = new System.Drawing.Point(438, 212);
            this.btn_verContra.Name = "btn_verContra";
            this.btn_verContra.Size = new System.Drawing.Size(44, 41);
            this.btn_verContra.TabIndex = 28;
            this.btn_verContra.UseVisualStyleBackColor = true;
            this.btn_verContra.Click += new System.EventHandler(this.btn_verContra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "¿Se olvido de la contraseña?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(263, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Restablecer contraseña... ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkRegistro
            // 
            this.linkRegistro.AutoSize = true;
            this.linkRegistro.Location = new System.Drawing.Point(298, 386);
            this.linkRegistro.Name = "linkRegistro";
            this.linkRegistro.Size = new System.Drawing.Size(64, 13);
            this.linkRegistro.TabIndex = 8;
            this.linkRegistro.TabStop = true;
            this.linkRegistro.Text = "Registrate...";
            this.linkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistro_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.Location = new System.Drawing.Point(597, 430);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(63, 57);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(244, 220);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(188, 23);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Password_KeyPress);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Usuario.Location = new System.Drawing.Point(244, 156);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(188, 23);
            this.textBox_Usuario.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(241, 197);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(81, 17);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Contraseña";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Items.AddRange(new object[] {
            "Usuario General",
            "Moderador",
            "Administrador"});
            this.comboBoxUsuario.Location = new System.Drawing.Point(274, 419);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsuario.TabIndex = 31;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 499);
            this.Controls.Add(this.Logeo_panel);
            this.Controls.Add(this.login_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.login_logo.ResumeLayout(false);
            this.login_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.Logeo_panel.ResumeLayout(false);
            this.Logeo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_logo;
        private System.Windows.Forms.Panel Logeo_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.Button btn_verContraSup;
        private System.Windows.Forms.Button btn_verContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
    }
}