
namespace Proyecto.Interfaces
{
    partial class GestionDeInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeInventario));
            this.label_stock = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_BuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_domicilio = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_usuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TipouserLab = new System.Windows.Forms.Label();
            this.label_stock.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_stock
            // 
            this.label_stock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_stock.Controls.Add(this.groupBox3);
            this.label_stock.Controls.Add(this.groupBox2);
            this.label_stock.Controls.Add(this.groupBox1);
            this.label_stock.Controls.Add(this.menuStrip1);
            this.label_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_stock.Location = new System.Drawing.Point(323, 100);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(761, 520);
            this.label_stock.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(373, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 364);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(376, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox_codigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_BuscarNombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(376, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(283, 61);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Restablecer";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(122, 29);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(99, 26);
            this.textBox_codigo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Codigo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_BuscarNombre
            // 
            this.textBox_BuscarNombre.Location = new System.Drawing.Point(122, 61);
            this.textBox_BuscarNombre.Name = "textBox_BuscarNombre";
            this.textBox_BuscarNombre.Size = new System.Drawing.Size(145, 26);
            this.textBox_BuscarNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_telefono);
            this.groupBox1.Controls.Add(this.textBox_domicilio);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(66, 154);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(103, 26);
            this.textBox_telefono.TabIndex = 7;
            // 
            // textBox_domicilio
            // 
            this.textBox_domicilio.Location = new System.Drawing.Point(69, 196);
            this.textBox_domicilio.Name = "textBox_domicilio";
            this.textBox_domicilio.Size = new System.Drawing.Size(100, 26);
            this.textBox_domicilio.TabIndex = 6;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(149, 107);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(135, 26);
            this.textBox_Nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.TipouserLab);
            this.panel1.Controls.Add(this.lab_usuario);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.nombreUsuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(323, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lab_usuario
            // 
            this.lab_usuario.AutoSize = true;
            this.lab_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_usuario.Location = new System.Drawing.Point(562, 25);
            this.lab_usuario.Name = "lab_usuario";
            this.lab_usuario.Size = new System.Drawing.Size(0, 20);
            this.lab_usuario.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(465, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.Location = new System.Drawing.Point(729, 44);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(0, 20);
            this.nombreUsuario.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gestion de Inventario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_ventas);
            this.panel2.Controls.Add(this.btn_clientes);
            this.panel2.Controls.Add(this.btn_Inicio);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 620);
            this.panel2.TabIndex = 4;
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
            this.btn_ventas.TabIndex = 8;
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
            this.btn_clientes.TabIndex = 4;
            this.btn_clientes.Text = "Gestion de clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
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
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
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
            // TipouserLab
            // 
            this.TipouserLab.AutoSize = true;
            this.TipouserLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipouserLab.Location = new System.Drawing.Point(566, 61);
            this.TipouserLab.Name = "TipouserLab";
            this.TipouserLab.Size = new System.Drawing.Size(0, 20);
            this.TipouserLab.TabIndex = 12;
            // 
            // GestionDeInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 620);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionDeInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rochita Food";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GestionDeInventario_KeyPress);
            this.label_stock.ResumeLayout(false);
            this.label_stock.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel label_stock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_BuscarNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_domicilio;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label lab_usuario;
        private System.Windows.Forms.Label TipouserLab;
    }
}