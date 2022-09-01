namespace CapaPresentacion
{
    partial class FrProductos
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
            this.lblProductoTitulo = new System.Windows.Forms.Label();
            this.groupbxGestionPro = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlModificarPro = new System.Windows.Forms.Panel();
            this.txtModCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConsultModificarPro = new System.Windows.Forms.ComboBox();
            this.txtCantModificarPro = new System.Windows.Forms.TextBox();
            this.txtValModificarPro = new System.Windows.Forms.TextBox();
            this.txtDescripModificarPro = new System.Windows.Forms.TextBox();
            this.btnConsultModificarPro = new System.Windows.Forms.Button();
            this.btnSaveModificarPro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlConsultarPro = new System.Windows.Forms.Panel();
            this.txtConsultarPro = new System.Windows.Forms.ComboBox();
            this.GridConsultarPro = new System.Windows.Forms.DataGridView();
            this.btnConsultarPro = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PnlEliminarPro = new System.Windows.Forms.Panel();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.txtEliminarPro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlIngresarPro = new System.Windows.Forms.Panel();
            this.txtInProCodigo = new System.Windows.Forms.NumericUpDown();
            this.txtInProCantidad = new System.Windows.Forms.TextBox();
            this.txtInProValor = new System.Windows.Forms.TextBox();
            this.txtInProDescripcion = new System.Windows.Forms.TextBox();
            this.btnInProLimpiar = new System.Windows.Forms.Button();
            this.btnInProGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInProCodigo = new System.Windows.Forms.Label();
            this.btnProSalir = new System.Windows.Forms.Button();
            this.groupbxGestionPro.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PnlModificarPro.SuspendLayout();
            this.PnlConsultarPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultarPro)).BeginInit();
            this.PnlEliminarPro.SuspendLayout();
            this.PnlIngresarPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInProCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoTitulo
            // 
            this.lblProductoTitulo.AutoSize = true;
            this.lblProductoTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductoTitulo.Location = new System.Drawing.Point(294, 32);
            this.lblProductoTitulo.Name = "lblProductoTitulo";
            this.lblProductoTitulo.Size = new System.Drawing.Size(225, 32);
            this.lblProductoTitulo.TabIndex = 0;
            this.lblProductoTitulo.Text = "Gestión Productos";
            // 
            // groupbxGestionPro
            // 
            this.groupbxGestionPro.Controls.Add(this.menuStrip1);
            this.groupbxGestionPro.Controls.Add(this.PnlIngresarPro);
            this.groupbxGestionPro.Controls.Add(this.PnlModificarPro);
            this.groupbxGestionPro.Controls.Add(this.PnlConsultarPro);
            this.groupbxGestionPro.Controls.Add(this.PnlEliminarPro);
            this.groupbxGestionPro.Location = new System.Drawing.Point(12, 84);
            this.groupbxGestionPro.Name = "groupbxGestionPro";
            this.groupbxGestionPro.Size = new System.Drawing.Size(776, 354);
            this.groupbxGestionPro.TabIndex = 1;
            this.groupbxGestionPro.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar Producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // PnlModificarPro
            // 
            this.PnlModificarPro.Controls.Add(this.txtModCodigo);
            this.PnlModificarPro.Controls.Add(this.label9);
            this.PnlModificarPro.Controls.Add(this.txtConsultModificarPro);
            this.PnlModificarPro.Controls.Add(this.txtCantModificarPro);
            this.PnlModificarPro.Controls.Add(this.txtValModificarPro);
            this.PnlModificarPro.Controls.Add(this.txtDescripModificarPro);
            this.PnlModificarPro.Controls.Add(this.btnConsultModificarPro);
            this.PnlModificarPro.Controls.Add(this.btnSaveModificarPro);
            this.PnlModificarPro.Controls.Add(this.label5);
            this.PnlModificarPro.Controls.Add(this.label6);
            this.PnlModificarPro.Controls.Add(this.label7);
            this.PnlModificarPro.Controls.Add(this.label8);
            this.PnlModificarPro.Location = new System.Drawing.Point(17, 46);
            this.PnlModificarPro.Name = "PnlModificarPro";
            this.PnlModificarPro.Size = new System.Drawing.Size(743, 286);
            this.PnlModificarPro.TabIndex = 7;
            this.PnlModificarPro.Visible = false;
            // 
            // txtModCodigo
            // 
            this.txtModCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModCodigo.Location = new System.Drawing.Point(353, 69);
            this.txtModCodigo.Name = "txtModCodigo";
            this.txtModCodigo.Size = new System.Drawing.Size(200, 29);
            this.txtModCodigo.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(192, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Código";
            // 
            // txtConsultModificarPro
            // 
            this.txtConsultModificarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConsultModificarPro.FormattingEnabled = true;
            this.txtConsultModificarPro.Location = new System.Drawing.Point(286, 16);
            this.txtConsultModificarPro.Name = "txtConsultModificarPro";
            this.txtConsultModificarPro.Size = new System.Drawing.Size(200, 29);
            this.txtConsultModificarPro.TabIndex = 11;
            // 
            // txtCantModificarPro
            // 
            this.txtCantModificarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantModificarPro.Location = new System.Drawing.Point(353, 202);
            this.txtCantModificarPro.Name = "txtCantModificarPro";
            this.txtCantModificarPro.Size = new System.Drawing.Size(200, 29);
            this.txtCantModificarPro.TabIndex = 10;
            // 
            // txtValModificarPro
            // 
            this.txtValModificarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValModificarPro.Location = new System.Drawing.Point(353, 157);
            this.txtValModificarPro.Name = "txtValModificarPro";
            this.txtValModificarPro.Size = new System.Drawing.Size(200, 29);
            this.txtValModificarPro.TabIndex = 9;
            // 
            // txtDescripModificarPro
            // 
            this.txtDescripModificarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripModificarPro.Location = new System.Drawing.Point(353, 111);
            this.txtDescripModificarPro.Name = "txtDescripModificarPro";
            this.txtDescripModificarPro.Size = new System.Drawing.Size(200, 29);
            this.txtDescripModificarPro.TabIndex = 8;
            // 
            // btnConsultModificarPro
            // 
            this.btnConsultModificarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultModificarPro.Location = new System.Drawing.Point(509, 14);
            this.btnConsultModificarPro.Name = "btnConsultModificarPro";
            this.btnConsultModificarPro.Size = new System.Drawing.Size(123, 36);
            this.btnConsultModificarPro.TabIndex = 6;
            this.btnConsultModificarPro.Text = "Consultar";
            this.btnConsultModificarPro.UseVisualStyleBackColor = true;
            this.btnConsultModificarPro.Click += new System.EventHandler(this.btnConsultModificarPro_Click);
            // 
            // btnSaveModificarPro
            // 
            this.btnSaveModificarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveModificarPro.Location = new System.Drawing.Point(321, 241);
            this.btnSaveModificarPro.Name = "btnSaveModificarPro";
            this.btnSaveModificarPro.Size = new System.Drawing.Size(123, 36);
            this.btnSaveModificarPro.TabIndex = 4;
            this.btnSaveModificarPro.Text = "Guardar";
            this.btnSaveModificarPro.UseVisualStyleBackColor = true;
            this.btnSaveModificarPro.Click += new System.EventHandler(this.btnSaveModificarPro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(192, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(192, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(191, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(125, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto:";
            // 
            // PnlConsultarPro
            // 
            this.PnlConsultarPro.Controls.Add(this.txtConsultarPro);
            this.PnlConsultarPro.Controls.Add(this.GridConsultarPro);
            this.PnlConsultarPro.Controls.Add(this.btnConsultarPro);
            this.PnlConsultarPro.Controls.Add(this.label12);
            this.PnlConsultarPro.Location = new System.Drawing.Point(17, 46);
            this.PnlConsultarPro.Name = "PnlConsultarPro";
            this.PnlConsultarPro.Size = new System.Drawing.Size(743, 286);
            this.PnlConsultarPro.TabIndex = 2;
            this.PnlConsultarPro.Visible = false;
            // 
            // txtConsultarPro
            // 
            this.txtConsultarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConsultarPro.FormattingEnabled = true;
            this.txtConsultarPro.Location = new System.Drawing.Point(234, 16);
            this.txtConsultarPro.Name = "txtConsultarPro";
            this.txtConsultarPro.Size = new System.Drawing.Size(406, 29);
            this.txtConsultarPro.TabIndex = 9;
            // 
            // GridConsultarPro
            // 
            this.GridConsultarPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultarPro.Location = new System.Drawing.Point(180, 124);
            this.GridConsultarPro.Name = "GridConsultarPro";
            this.GridConsultarPro.RowTemplate.Height = 25;
            this.GridConsultarPro.Size = new System.Drawing.Size(386, 133);
            this.GridConsultarPro.TabIndex = 8;
            // 
            // btnConsultarPro
            // 
            this.btnConsultarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarPro.Location = new System.Drawing.Point(315, 72);
            this.btnConsultarPro.Name = "btnConsultarPro";
            this.btnConsultarPro.Size = new System.Drawing.Size(109, 36);
            this.btnConsultarPro.TabIndex = 4;
            this.btnConsultarPro.Text = "Consultar";
            this.btnConsultarPro.UseVisualStyleBackColor = true;
            this.btnConsultarPro.Click += new System.EventHandler(this.btnConsultarPro_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(107, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Consultar:";
            // 
            // PnlEliminarPro
            // 
            this.PnlEliminarPro.Controls.Add(this.btnEliminarPro);
            this.PnlEliminarPro.Controls.Add(this.txtEliminarPro);
            this.PnlEliminarPro.Controls.Add(this.label4);
            this.PnlEliminarPro.Location = new System.Drawing.Point(17, 46);
            this.PnlEliminarPro.Name = "PnlEliminarPro";
            this.PnlEliminarPro.Size = new System.Drawing.Size(743, 286);
            this.PnlEliminarPro.TabIndex = 12;
            this.PnlEliminarPro.Visible = false;
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPro.Location = new System.Drawing.Point(281, 129);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(164, 41);
            this.btnEliminarPro.TabIndex = 2;
            this.btnEliminarPro.Text = "Eliminar";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
            // 
            // txtEliminarPro
            // 
            this.txtEliminarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEliminarPro.FormattingEnabled = true;
            this.txtEliminarPro.Location = new System.Drawing.Point(315, 72);
            this.txtEliminarPro.Name = "txtEliminarPro";
            this.txtEliminarPro.Size = new System.Drawing.Size(275, 29);
            this.txtEliminarPro.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Producto:";
            // 
            // PnlIngresarPro
            // 
            this.PnlIngresarPro.Controls.Add(this.txtInProCodigo);
            this.PnlIngresarPro.Controls.Add(this.txtInProCantidad);
            this.PnlIngresarPro.Controls.Add(this.txtInProValor);
            this.PnlIngresarPro.Controls.Add(this.txtInProDescripcion);
            this.PnlIngresarPro.Controls.Add(this.btnInProLimpiar);
            this.PnlIngresarPro.Controls.Add(this.btnInProGuardar);
            this.PnlIngresarPro.Controls.Add(this.label3);
            this.PnlIngresarPro.Controls.Add(this.label2);
            this.PnlIngresarPro.Controls.Add(this.label1);
            this.PnlIngresarPro.Controls.Add(this.lblInProCodigo);
            this.PnlIngresarPro.Location = new System.Drawing.Point(17, 46);
            this.PnlIngresarPro.Name = "PnlIngresarPro";
            this.PnlIngresarPro.Size = new System.Drawing.Size(743, 286);
            this.PnlIngresarPro.TabIndex = 1;
            this.PnlIngresarPro.Visible = false;
            // 
            // txtInProCodigo
            // 
            this.txtInProCodigo.Enabled = false;
            this.txtInProCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInProCodigo.Location = new System.Drawing.Point(375, 36);
            this.txtInProCodigo.Name = "txtInProCodigo";
            this.txtInProCodigo.Size = new System.Drawing.Size(179, 29);
            this.txtInProCodigo.TabIndex = 18;
            // 
            // txtInProCantidad
            // 
            this.txtInProCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInProCantidad.Location = new System.Drawing.Point(375, 166);
            this.txtInProCantidad.Name = "txtInProCantidad";
            this.txtInProCantidad.Size = new System.Drawing.Size(179, 29);
            this.txtInProCantidad.TabIndex = 17;
            // 
            // txtInProValor
            // 
            this.txtInProValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInProValor.Location = new System.Drawing.Point(375, 121);
            this.txtInProValor.Name = "txtInProValor";
            this.txtInProValor.Size = new System.Drawing.Size(179, 29);
            this.txtInProValor.TabIndex = 16;
            // 
            // txtInProDescripcion
            // 
            this.txtInProDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInProDescripcion.Location = new System.Drawing.Point(375, 79);
            this.txtInProDescripcion.Name = "txtInProDescripcion";
            this.txtInProDescripcion.Size = new System.Drawing.Size(179, 29);
            this.txtInProDescripcion.TabIndex = 8;
            // 
            // btnInProLimpiar
            // 
            this.btnInProLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInProLimpiar.Location = new System.Drawing.Point(281, 232);
            this.btnInProLimpiar.Name = "btnInProLimpiar";
            this.btnInProLimpiar.Size = new System.Drawing.Size(76, 36);
            this.btnInProLimpiar.TabIndex = 6;
            this.btnInProLimpiar.Text = "Limpiar";
            this.btnInProLimpiar.UseVisualStyleBackColor = true;
            this.btnInProLimpiar.Click += new System.EventHandler(this.btnInProLimpiar_Click);
            // 
            // btnInProGuardar
            // 
            this.btnInProGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInProGuardar.Location = new System.Drawing.Point(416, 230);
            this.btnInProGuardar.Name = "btnInProGuardar";
            this.btnInProGuardar.Size = new System.Drawing.Size(76, 36);
            this.btnInProGuardar.TabIndex = 4;
            this.btnInProGuardar.Text = "Guardar";
            this.btnInProGuardar.UseVisualStyleBackColor = true;
            this.btnInProGuardar.Click += new System.EventHandler(this.btnInProGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(234, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción:";
            // 
            // lblInProCodigo
            // 
            this.lblInProCodigo.AutoSize = true;
            this.lblInProCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInProCodigo.Location = new System.Drawing.Point(234, 38);
            this.lblInProCodigo.Name = "lblInProCodigo";
            this.lblInProCodigo.Size = new System.Drawing.Size(63, 21);
            this.lblInProCodigo.TabIndex = 0;
            this.lblInProCodigo.Text = "Código:";
            // 
            // btnProSalir
            // 
            this.btnProSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProSalir.Location = new System.Drawing.Point(12, 31);
            this.btnProSalir.Name = "btnProSalir";
            this.btnProSalir.Size = new System.Drawing.Size(88, 41);
            this.btnProSalir.TabIndex = 3;
            this.btnProSalir.Text = "Salir";
            this.btnProSalir.UseVisualStyleBackColor = true;
            this.btnProSalir.Click += new System.EventHandler(this.btnProSalir_Click);
            // 
            // FrProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProSalir);
            this.Controls.Add(this.groupbxGestionPro);
            this.Controls.Add(this.lblProductoTitulo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrProductos_Load);
            this.groupbxGestionPro.ResumeLayout(false);
            this.groupbxGestionPro.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlModificarPro.ResumeLayout(false);
            this.PnlModificarPro.PerformLayout();
            this.PnlConsultarPro.ResumeLayout(false);
            this.PnlConsultarPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultarPro)).EndInit();
            this.PnlEliminarPro.ResumeLayout(false);
            this.PnlEliminarPro.PerformLayout();
            this.PnlIngresarPro.ResumeLayout(false);
            this.PnlIngresarPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInProCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductoTitulo;
        private GroupBox groupbxGestionPro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private ToolStripMenuItem consultarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private Panel PnlIngresarPro;
        private TextBox txtInProDescripcion;
        private Button btnInProLimpiar;
        private Button btnInProGuardar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblInProCodigo;
        private Panel PnlModificarPro;
        private ComboBox txtConsultModificarPro;
        private TextBox txtCantModificarPro;
        private TextBox txtValModificarPro;
        private TextBox txtDescripModificarPro;
        private Button btnConsultModificarPro;
        private Button btnSaveModificarPro;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel PnlConsultarPro;
        private ComboBox txtConsultarPro;
        private DataGridView GridConsultarPro;
        private Button btnConsultarPro;
        private Label label12;
        private Panel PnlEliminarPro;
        private Button btnEliminarPro;
        private ComboBox txtEliminarPro;
        private Label label4;
        private Button btnProSalir;
        private TextBox txtInProCantidad;
        private TextBox txtInProValor;
        private NumericUpDown txtInProCodigo;
        private TextBox txtModCodigo;
        private Label label9;
    }
}