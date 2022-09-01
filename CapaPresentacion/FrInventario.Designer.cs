namespace CapaPresentacion
{
    partial class FrInventario
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProInventario = new System.Windows.Forms.ComboBox();
            this.btnConsultarInventario = new System.Windows.Forms.Button();
            this.GridInventario = new System.Windows.Forms.DataGridView();
            this.btnInSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(163, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto:";
            // 
            // cbxProInventario
            // 
            this.cbxProInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxProInventario.FormattingEnabled = true;
            this.cbxProInventario.Location = new System.Drawing.Point(293, 106);
            this.cbxProInventario.Name = "cbxProInventario";
            this.cbxProInventario.Size = new System.Drawing.Size(361, 29);
            this.cbxProInventario.TabIndex = 2;
            // 
            // btnConsultarInventario
            // 
            this.btnConsultarInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarInventario.Location = new System.Drawing.Point(293, 157);
            this.btnConsultarInventario.Name = "btnConsultarInventario";
            this.btnConsultarInventario.Size = new System.Drawing.Size(216, 35);
            this.btnConsultarInventario.TabIndex = 3;
            this.btnConsultarInventario.Text = "Consultar";
            this.btnConsultarInventario.UseVisualStyleBackColor = true;
            // 
            // GridInventario
            // 
            this.GridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInventario.Location = new System.Drawing.Point(163, 216);
            this.GridInventario.Name = "GridInventario";
            this.GridInventario.RowTemplate.Height = 25;
            this.GridInventario.Size = new System.Drawing.Size(491, 168);
            this.GridInventario.TabIndex = 4;
            // 
            // btnInSalir
            // 
            this.btnInSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInSalir.Location = new System.Drawing.Point(23, 38);
            this.btnInSalir.Name = "btnInSalir";
            this.btnInSalir.Size = new System.Drawing.Size(82, 35);
            this.btnInSalir.TabIndex = 5;
            this.btnInSalir.Text = "Salir";
            this.btnInSalir.UseVisualStyleBackColor = true;
            this.btnInSalir.Click += new System.EventHandler(this.btnInSalir_Click);
            // 
            // FrInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInSalir);
            this.Controls.Add(this.GridInventario);
            this.Controls.Add(this.btnConsultarInventario);
            this.Controls.Add(this.cbxProInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrInventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.GridInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxProInventario;
        private Button btnConsultarInventario;
        private DataGridView GridInventario;
        private Button btnInSalir;
    }
}