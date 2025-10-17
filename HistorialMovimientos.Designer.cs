namespace InventarioAppTeoria
{
    partial class frmHistorialMovimientos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUltimos = new System.Windows.Forms.Label();
            this.lblUltimoss = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Linen;
            this.lblTitulo.Location = new System.Drawing.Point(45, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(429, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📦   Historial de MovimientoS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblUltimos
            // 
            this.lblUltimos.AutoSize = true;
            this.lblUltimos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUltimos.Location = new System.Drawing.Point(46, 96);
            this.lblUltimos.Name = "lblUltimos";
            this.lblUltimos.Size = new System.Drawing.Size(139, 22);
            this.lblUltimos.TabIndex = 1;
            this.lblUltimos.Text = "Últimos Retiros:";
            // 
            // lblUltimoss
            // 
            this.lblUltimoss.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoss.FormattingEnabled = true;
            this.lblUltimoss.ItemHeight = 22;
            this.lblUltimoss.Location = new System.Drawing.Point(50, 137);
            this.lblUltimoss.Name = "lblUltimoss";
            this.lblUltimoss.Size = new System.Drawing.Size(217, 92);
            this.lblUltimoss.TabIndex = 2;
            // 
            // frmHistorialMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1334, 866);
            this.Controls.Add(this.lblUltimoss);
            this.Controls.Add(this.lblUltimos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmHistorialMovimientos";
            this.Text = "     Historial de Movimientos";
            this.Load += new System.EventHandler(this.frmHistorialMovimientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUltimos;
        private System.Windows.Forms.ListBox lblUltimoss;
    }
}