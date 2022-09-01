namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblLoginContraseña = new System.Windows.Forms.Label();
            this.bntLoginIngresar = new System.Windows.Forms.Button();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginContraseña = new System.Windows.Forms.TextBox();
            this.btnLogSalir = new System.Windows.Forms.Button();
            this.btnLogConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoginTitulo.Location = new System.Drawing.Point(234, 66);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(342, 60);
            this.lblLoginTitulo.TabIndex = 0;
            this.lblLoginTitulo.Text = "SISTEMA DE INFORMACION\r\nTIENDA NATURISTA NATURVIDA";
            this.lblLoginTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginUsuario.Location = new System.Drawing.Point(234, 182);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(83, 30);
            this.lblLoginUsuario.TabIndex = 1;
            this.lblLoginUsuario.Text = "Usuario";
            // 
            // lblLoginContraseña
            // 
            this.lblLoginContraseña.AutoSize = true;
            this.lblLoginContraseña.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginContraseña.Location = new System.Drawing.Point(234, 242);
            this.lblLoginContraseña.Name = "lblLoginContraseña";
            this.lblLoginContraseña.Size = new System.Drawing.Size(118, 30);
            this.lblLoginContraseña.TabIndex = 2;
            this.lblLoginContraseña.Text = "Contraseña";
            // 
            // bntLoginIngresar
            // 
            this.bntLoginIngresar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntLoginIngresar.Location = new System.Drawing.Point(449, 335);
            this.bntLoginIngresar.Name = "bntLoginIngresar";
            this.bntLoginIngresar.Size = new System.Drawing.Size(127, 40);
            this.bntLoginIngresar.TabIndex = 3;
            this.bntLoginIngresar.Text = "Ingresar";
            this.bntLoginIngresar.UseVisualStyleBackColor = true;
            this.bntLoginIngresar.Click += new System.EventHandler(this.bntIngresar_Click);
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginUsuario.Location = new System.Drawing.Point(414, 179);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(162, 35);
            this.txtLoginUsuario.TabIndex = 4;
            // 
            // txtLoginContraseña
            // 
            this.txtLoginContraseña.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginContraseña.Location = new System.Drawing.Point(414, 239);
            this.txtLoginContraseña.Name = "txtLoginContraseña";
            this.txtLoginContraseña.PasswordChar = '*';
            this.txtLoginContraseña.Size = new System.Drawing.Size(162, 35);
            this.txtLoginContraseña.TabIndex = 5;
            // 
            // btnLogSalir
            // 
            this.btnLogSalir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogSalir.Location = new System.Drawing.Point(234, 335);
            this.btnLogSalir.Name = "btnLogSalir";
            this.btnLogSalir.Size = new System.Drawing.Size(127, 40);
            this.btnLogSalir.TabIndex = 6;
            this.btnLogSalir.Text = "Salir";
            this.btnLogSalir.UseVisualStyleBackColor = true;
            this.btnLogSalir.Click += new System.EventHandler(this.btnLogSalir_Click);
            // 
            // btnLogConexion
            // 
            this.btnLogConexion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogConexion.Location = new System.Drawing.Point(661, 398);
            this.btnLogConexion.Name = "btnLogConexion";
            this.btnLogConexion.Size = new System.Drawing.Size(127, 40);
            this.btnLogConexion.TabIndex = 7;
            this.btnLogConexion.Text = "Probar";
            this.btnLogConexion.UseVisualStyleBackColor = true;
            this.btnLogConexion.Click += new System.EventHandler(this.btnLogConexion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogConexion);
            this.Controls.Add(this.btnLogSalir);
            this.Controls.Add(this.txtLoginContraseña);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.bntLoginIngresar);
            this.Controls.Add(this.lblLoginContraseña);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.lblLoginTitulo);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLoginTitulo;
        private Label lblLoginUsuario;
        private Label lblLoginContraseña;
        private Button bntLoginIngresar;
        private TextBox txtLoginUsuario;
        private TextBox txtLoginContraseña;
        private Button btnLogSalir;
        private Button btnLogConexion;
    }
}