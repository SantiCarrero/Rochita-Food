
namespace Proyecto.Interfaces
{
    partial class AppGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppGeneral));
            this.menuIzquierdo = new System.Windows.Forms.Panel();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_auditoria = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.menuSuperior = new System.Windows.Forms.Panel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.TipoUserLab = new System.Windows.Forms.Label();
            this.menuIzquierdo.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuIzquierdo
            // 
            this.menuIzquierdo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuIzquierdo.Controls.Add(this.btn_cerrarSesion);
            this.menuIzquierdo.Controls.Add(this.btn_auditoria);
            this.menuIzquierdo.Controls.Add(this.btn_usuarios);
            this.menuIzquierdo.Controls.Add(this.btn_inventario);
            this.menuIzquierdo.Controls.Add(this.btn_ventas);
            this.menuIzquierdo.Controls.Add(this.btn_clientes);
            this.menuIzquierdo.Controls.Add(this.btn_Inicio);
            this.menuIzquierdo.Controls.Add(this.panel_logo);
            this.menuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.menuIzquierdo.Name = "menuIzquierdo";
            this.menuIzquierdo.Size = new System.Drawing.Size(323, 612);
            this.menuIzquierdo.TabIndex = 0;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarSesion.Image")));
            this.btn_cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(0, 490);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(323, 65);
            this.btn_cerrarSesion.TabIndex = 8;
            this.btn_cerrarSesion.Text = "Cerrar sesión";
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click_1);
            // 
            // btn_auditoria
            // 
            this.btn_auditoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_auditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_auditoria.FlatAppearance.BorderSize = 0;
            this.btn_auditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auditoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_auditoria.Image")));
            this.btn_auditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_auditoria.Location = new System.Drawing.Point(0, 425);
            this.btn_auditoria.Name = "btn_auditoria";
            this.btn_auditoria.Size = new System.Drawing.Size(323, 65);
            this.btn_auditoria.TabIndex = 7;
            this.btn_auditoria.Text = "Registro de auditoria";
            this.btn_auditoria.UseVisualStyleBackColor = true;
            this.btn_auditoria.Click += new System.EventHandler(this.btn_auditoria_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuarios.Image")));
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 360);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(323, 65);
            this.btn_usuarios.TabIndex = 6;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventario.Image")));
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.Location = new System.Drawing.Point(0, 295);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(323, 65);
            this.btn_inventario.TabIndex = 4;
            this.btn_inventario.Text = "Gestion de inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ventas.Image")));
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(0, 230);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(323, 65);
            this.btn_ventas.TabIndex = 3;
            this.btn_ventas.Text = "Gestion de ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_clientes.Image")));
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(0, 165);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(323, 65);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "Gestion de clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_MiCuenta_Click);
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inicio.Image")));
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 100);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(323, 65);
            this.btn_Inicio.TabIndex = 1;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.Logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(323, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(323, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuSuperior.Controls.Add(this.TipoUserLab);
            this.menuSuperior.Controls.Add(this.lbl_nombreUsuario);
            this.menuSuperior.Controls.Add(this.pictureBox1);
            this.menuSuperior.Controls.Add(this.nombreUsuario);
            this.menuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSuperior.Location = new System.Drawing.Point(323, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(705, 100);
            this.menuSuperior.TabIndex = 1;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(568, 25);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(0, 20);
            this.lbl_nombreUsuario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.Location = new System.Drawing.Point(702, 46);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(0, 20);
            this.nombreUsuario.TabIndex = 0;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(323, 100);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(705, 512);
            this.Contenedor.TabIndex = 2;
            // 
            // TipoUserLab
            // 
            this.TipoUserLab.AutoSize = true;
            this.TipoUserLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoUserLab.Location = new System.Drawing.Point(568, 55);
            this.TipoUserLab.Name = "TipoUserLab";
            this.TipoUserLab.Size = new System.Drawing.Size(0, 20);
            this.TipoUserLab.TabIndex = 3;
            // 
            // AppGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 612);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuSuperior);
            this.Controls.Add(this.menuIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rochita Food";
            this.menuIzquierdo.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuIzquierdo;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel menuSuperior;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Button btn_auditoria;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label TipoUserLab;
    }
}