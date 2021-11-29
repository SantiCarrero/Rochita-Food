
namespace Proyecto.Interfaces
{
    partial class Usuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.tipodeusuario = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administracion de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(179, 225);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(136, 20);
            this.txt_correo.TabIndex = 3;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(178, 181);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(103, 20);
            this.txt_usuario.TabIndex = 4;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_nombreproducto_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(60, 271);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(85, 18);
            this.contraseña.TabIndex = 7;
            this.contraseña.Text = "Contraseña";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.correo.Location = new System.Drawing.Point(41, 224);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(132, 18);
            this.correo.TabIndex = 8;
            this.correo.Text = "Correo electronico";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usuario.Location = new System.Drawing.Point(77, 180);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(60, 18);
            this.usuario.TabIndex = 9;
            this.usuario.Text = "Usuario";
            // 
            // tipodeusuario
            // 
            this.tipodeusuario.AutoSize = true;
            this.tipodeusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tipodeusuario.Location = new System.Drawing.Point(60, 136);
            this.tipodeusuario.Name = "tipodeusuario";
            this.tipodeusuario.Size = new System.Drawing.Size(113, 18);
            this.tipodeusuario.TabIndex = 10;
            this.tipodeusuario.Text = "Tipo de Usuario";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Usuario General",
            "Moderador",
            "Administrador"});
            this.comboBox2.Location = new System.Drawing.Point(186, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(170, 272);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(143, 20);
            this.txt_contraseña.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 291);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ID.Location = new System.Drawing.Point(96, 93);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 18);
            this.ID.TabIndex = 25;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(179, 94);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(53, 20);
            this.txt_codigo.TabIndex = 24;
            this.txt_codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 341);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tipodeusuario);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rochita Food";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label tipodeusuario;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}