namespace InventarioAppTeoria
{
    partial class frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(110, 182);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(82, 35);
            this.btn_inicio.TabIndex = 9;
            this.btn_inicio.Text = "INICIAR SESION";
            this.btn_inicio.UseVisualStyleBackColor = true;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(68, 112);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(81, 13);
            this.lbl_contraseña.TabIndex = 8;
            this.lbl_contraseña.Text = "CONTRASEÑA";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(68, 50);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(56, 13);
            this.lbl_user.TabIndex = 5;
            this.lbl_user.Text = "USUARIO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

