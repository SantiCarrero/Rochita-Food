
namespace Proyecto.Interfaces
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_MiCuenta = new System.Windows.Forms.Button();
            this.btn_Carrito = new System.Windows.Forms.Button();
            this.btn_Historial = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_Historial);
            this.panel2.Controls.Add(this.btn_Carrito);
            this.panel2.Controls.Add(this.btn_MiCuenta);
            this.panel2.Controls.Add(this.btn_Inicio);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 605);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(323, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(323, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 505);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 100);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btn_Inicio.TabIndex = 2;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            // 
            // btn_MiCuenta
            // 
            this.btn_MiCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MiCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MiCuenta.FlatAppearance.BorderSize = 0;
            this.btn_MiCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MiCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MiCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_MiCuenta.Image")));
            this.btn_MiCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MiCuenta.Location = new System.Drawing.Point(0, 165);
            this.btn_MiCuenta.Name = "btn_MiCuenta";
            this.btn_MiCuenta.Size = new System.Drawing.Size(323, 65);
            this.btn_MiCuenta.TabIndex = 3;
            this.btn_MiCuenta.Text = "Gestion de clientes";
            this.btn_MiCuenta.UseVisualStyleBackColor = true;
            // 
            // btn_Carrito
            // 
            this.btn_Carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Carrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Carrito.FlatAppearance.BorderSize = 0;
            this.btn_Carrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Carrito.Image = ((System.Drawing.Image)(resources.GetObject("btn_Carrito.Image")));
            this.btn_Carrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Carrito.Location = new System.Drawing.Point(0, 230);
            this.btn_Carrito.Name = "btn_Carrito";
            this.btn_Carrito.Size = new System.Drawing.Size(323, 65);
            this.btn_Carrito.TabIndex = 4;
            this.btn_Carrito.Text = "Gestion de ventas";
            this.btn_Carrito.UseVisualStyleBackColor = true;
            // 
            // btn_Historial
            // 
            this.btn_Historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Historial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Historial.FlatAppearance.BorderSize = 0;
            this.btn_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historial.Image = ((System.Drawing.Image)(resources.GetObject("btn_Historial.Image")));
            this.btn_Historial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Historial.Location = new System.Drawing.Point(0, 295);
            this.btn_Historial.Name = "btn_Historial";
            this.btn_Historial.Size = new System.Drawing.Size(323, 65);
            this.btn_Historial.TabIndex = 5;
            this.btn_Historial.Text = "Gestion de inventarios";
            this.btn_Historial.UseVisualStyleBackColor = true;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_MiCuenta;
        private System.Windows.Forms.Button btn_Carrito;
        private System.Windows.Forms.Button btn_Historial;
    }
}