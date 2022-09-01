namespace CapaPresentacion
{
    partial class FrCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRegistrar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.btnConsultarCli = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConsultarCli = new System.Windows.Forms.ComboBox();
            this.GridConsultar = new System.Windows.Forms.DataGridView();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.txtGuardarEditar = new System.Windows.Forms.Button();
            this.btnConsultarEditar = new System.Windows.Forms.Button();
            this.txtEditarEmail = new System.Windows.Forms.TextBox();
            this.txtEditarTelefono = new System.Windows.Forms.TextBox();
            this.txtEditarDireccion = new System.Windows.Forms.TextBox();
            this.txtEditarNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtConsultarEditar = new System.Windows.Forms.ComboBox();
            this.txtEditarNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.txtEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultar)).BeginInit();
            this.pnlModificar.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.pnlModificar);
            this.groupBox1.Controls.Add(this.pnlRegistrar);
            this.groupBox1.Controls.Add(this.pnlEliminar);
            this.groupBox1.Controls.Add(this.pnlConsultar);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarClientesToolStripMenuItem,
            this.editarClientesToolStripMenuItem,
            this.eliminarClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.registrarToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // editarClientesToolStripMenuItem
            // 
            this.editarClientesToolStripMenuItem.Name = "editarClientesToolStripMenuItem";
            this.editarClientesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.editarClientesToolStripMenuItem.Text = "Editar Clientes";
            this.editarClientesToolStripMenuItem.Click += new System.EventHandler(this.editarClientesToolStripMenuItem_Click);
            // 
            // eliminarClientesToolStripMenuItem
            // 
            this.eliminarClientesToolStripMenuItem.Name = "eliminarClientesToolStripMenuItem";
            this.eliminarClientesToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.eliminarClientesToolStripMenuItem.Text = "Eliminar Clientes";
            this.eliminarClientesToolStripMenuItem.Click += new System.EventHandler(this.eliminarClientesToolStripMenuItem_Click);
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.Controls.Add(this.btnGuardar);
            this.pnlRegistrar.Controls.Add(this.btnLimpiar);
            this.pnlRegistrar.Controls.Add(this.txtCorreo);
            this.pnlRegistrar.Controls.Add(this.txtTelefono);
            this.pnlRegistrar.Controls.Add(this.txtDireccion);
            this.pnlRegistrar.Controls.Add(this.txtNombre);
            this.pnlRegistrar.Controls.Add(this.txtNumero);
            this.pnlRegistrar.Controls.Add(this.label6);
            this.pnlRegistrar.Controls.Add(this.label5);
            this.pnlRegistrar.Controls.Add(this.label4);
            this.pnlRegistrar.Controls.Add(this.label3);
            this.pnlRegistrar.Controls.Add(this.label2);
            this.pnlRegistrar.Location = new System.Drawing.Point(6, 57);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(764, 315);
            this.pnlRegistrar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(392, 23);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(392, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(392, 107);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(392, 152);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(392, 196);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 23);
            this.txtCorreo.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(282, 265);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(417, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.Controls.Add(this.GridConsultar);
            this.pnlConsultar.Controls.Add(this.txtConsultarCli);
            this.pnlConsultar.Controls.Add(this.btnConsultarCli);
            this.pnlConsultar.Controls.Add(this.label11);
            this.pnlConsultar.Location = new System.Drawing.Point(6, 57);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(764, 315);
            this.pnlConsultar.TabIndex = 12;
            // 
            // btnConsultarCli
            // 
            this.btnConsultarCli.Location = new System.Drawing.Point(352, 69);
            this.btnConsultarCli.Name = "btnConsultarCli";
            this.btnConsultarCli.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCli.TabIndex = 11;
            this.btnConsultarCli.Text = "Consultar";
            this.btnConsultarCli.UseVisualStyleBackColor = true;
            this.btnConsultarCli.Click += new System.EventHandler(this.btnConsultarCli_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Consultar";
            // 
            // txtConsultarCli
            // 
            this.txtConsultarCli.FormattingEnabled = true;
            this.txtConsultarCli.Location = new System.Drawing.Point(392, 23);
            this.txtConsultarCli.Name = "txtConsultarCli";
            this.txtConsultarCli.Size = new System.Drawing.Size(121, 23);
            this.txtConsultarCli.TabIndex = 12;
            // 
            // GridConsultar
            // 
            this.GridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultar.Location = new System.Drawing.Point(160, 110);
            this.GridConsultar.Name = "GridConsultar";
            this.GridConsultar.RowTemplate.Height = 25;
            this.GridConsultar.Size = new System.Drawing.Size(465, 178);
            this.GridConsultar.TabIndex = 13;
            // 
            // pnlModificar
            // 
            this.pnlModificar.Controls.Add(this.txtEditarNum);
            this.pnlModificar.Controls.Add(this.label13);
            this.pnlModificar.Controls.Add(this.txtConsultarEditar);
            this.pnlModificar.Controls.Add(this.txtGuardarEditar);
            this.pnlModificar.Controls.Add(this.btnConsultarEditar);
            this.pnlModificar.Controls.Add(this.txtEditarEmail);
            this.pnlModificar.Controls.Add(this.txtEditarTelefono);
            this.pnlModificar.Controls.Add(this.txtEditarDireccion);
            this.pnlModificar.Controls.Add(this.txtEditarNombre);
            this.pnlModificar.Controls.Add(this.label7);
            this.pnlModificar.Controls.Add(this.label8);
            this.pnlModificar.Controls.Add(this.label9);
            this.pnlModificar.Controls.Add(this.label10);
            this.pnlModificar.Controls.Add(this.label12);
            this.pnlModificar.Location = new System.Drawing.Point(6, 57);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(764, 315);
            this.pnlModificar.TabIndex = 12;
            // 
            // txtGuardarEditar
            // 
            this.txtGuardarEditar.Location = new System.Drawing.Point(352, 275);
            this.txtGuardarEditar.Name = "txtGuardarEditar";
            this.txtGuardarEditar.Size = new System.Drawing.Size(75, 23);
            this.txtGuardarEditar.TabIndex = 11;
            this.txtGuardarEditar.Text = "Guardar";
            this.txtGuardarEditar.UseVisualStyleBackColor = true;
            this.txtGuardarEditar.Click += new System.EventHandler(this.txtGuardarEditar_Click);
            // 
            // btnConsultarEditar
            // 
            this.btnConsultarEditar.Location = new System.Drawing.Point(478, 22);
            this.btnConsultarEditar.Name = "btnConsultarEditar";
            this.btnConsultarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEditar.TabIndex = 10;
            this.btnConsultarEditar.Text = "Consultar";
            this.btnConsultarEditar.UseVisualStyleBackColor = true;
            this.btnConsultarEditar.Click += new System.EventHandler(this.btnConsultarEditar_Click);
            // 
            // txtEditarEmail
            // 
            this.txtEditarEmail.Location = new System.Drawing.Point(393, 237);
            this.txtEditarEmail.Name = "txtEditarEmail";
            this.txtEditarEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEditarEmail.TabIndex = 9;
            // 
            // txtEditarTelefono
            // 
            this.txtEditarTelefono.Location = new System.Drawing.Point(393, 193);
            this.txtEditarTelefono.Name = "txtEditarTelefono";
            this.txtEditarTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtEditarTelefono.TabIndex = 8;
            // 
            // txtEditarDireccion
            // 
            this.txtEditarDireccion.Location = new System.Drawing.Point(393, 148);
            this.txtEditarDireccion.Name = "txtEditarDireccion";
            this.txtEditarDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtEditarDireccion.TabIndex = 7;
            // 
            // txtEditarNombre
            // 
            this.txtEditarNombre.Location = new System.Drawing.Point(393, 107);
            this.txtEditarNombre.Name = "txtEditarNombre";
            this.txtEditarNombre.Size = new System.Drawing.Size(100, 23);
            this.txtEditarNombre.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Documento:";
            // 
            // txtConsultarEditar
            // 
            this.txtConsultarEditar.FormattingEnabled = true;
            this.txtConsultarEditar.Location = new System.Drawing.Point(360, 23);
            this.txtConsultarEditar.Name = "txtConsultarEditar";
            this.txtConsultarEditar.Size = new System.Drawing.Size(100, 23);
            this.txtConsultarEditar.TabIndex = 12;
            // 
            // txtEditarNum
            // 
            this.txtEditarNum.Location = new System.Drawing.Point(393, 69);
            this.txtEditarNum.Name = "txtEditarNum";
            this.txtEditarNum.Size = new System.Drawing.Size(100, 23);
            this.txtEditarNum.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Documento:";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.txtEliminar);
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.label14);
            this.pnlEliminar.Location = new System.Drawing.Point(6, 57);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(764, 315);
            this.pnlEliminar.TabIndex = 14;
            // 
            // txtEliminar
            // 
            this.txtEliminar.FormattingEnabled = true;
            this.txtEliminar.Location = new System.Drawing.Point(392, 23);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(121, 23);
            this.txtEliminar.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(352, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(282, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Consultar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(18, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrCliente";
            this.Text = "FrCliente";
            this.Load += new System.EventHandler(this.FrCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlRegistrar.PerformLayout();
            this.pnlConsultar.ResumeLayout(false);
            this.pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultar)).EndInit();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Panel pnlRegistrar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtNumero;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem consultarClientesToolStripMenuItem;
        private ToolStripMenuItem editarClientesToolStripMenuItem;
        private ToolStripMenuItem eliminarClientesToolStripMenuItem;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Panel pnlConsultar;
        private Button btnConsultarCli;
        private Label label11;
        private ComboBox txtConsultarCli;
        private DataGridView GridConsultar;
        private Panel pnlModificar;
        private Button txtGuardarEditar;
        private Button btnConsultarEditar;
        private TextBox txtEditarEmail;
        private TextBox txtEditarTelefono;
        private TextBox txtEditarDireccion;
        private TextBox txtEditarNombre;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private ComboBox txtConsultarEditar;
        private TextBox txtEditarNum;
        private Label label13;
        private Panel pnlEliminar;
        private ComboBox txtEliminar;
        private Button btnEliminar;
        private Label label14;
        private Button btnSalir;
    }
}