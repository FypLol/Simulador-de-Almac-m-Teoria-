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
            this.listBoxMovimientos = new System.Windows.Forms.ListBox();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.btnDeshacerMovimiento = new System.Windows.Forms.Button();
            this.btnVerMasMovimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMovimientos
            // 
            this.listBoxMovimientos.FormattingEnabled = true;
            this.listBoxMovimientos.Location = new System.Drawing.Point(41, 11);
            this.listBoxMovimientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMovimientos.Name = "listBoxMovimientos";
            this.listBoxMovimientos.Size = new System.Drawing.Size(607, 303);
            this.listBoxMovimientos.TabIndex = 0;
            this.listBoxMovimientos.SelectedIndexChanged += new System.EventHandler(this.listBoxMovimientos_SelectedIndexChanged);
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(41, 46);
            this.btnAgregarMovimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(154, 32);
            this.btnAgregarMovimiento.TabIndex = 1;
            this.btnAgregarMovimiento.Text = "Agregar Movimiento";
            this.btnAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // btnDeshacerMovimiento
            // 
            this.btnDeshacerMovimiento.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeshacerMovimiento.Location = new System.Drawing.Point(231, 41);
            this.btnDeshacerMovimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeshacerMovimiento.Name = "btnDeshacerMovimiento";
            this.btnDeshacerMovimiento.Size = new System.Drawing.Size(154, 37);
            this.btnDeshacerMovimiento.TabIndex = 2;
            this.btnDeshacerMovimiento.Text = "Deshacer Movimiento";
            this.btnDeshacerMovimiento.UseVisualStyleBackColor = true;
            this.btnDeshacerMovimiento.Click += new System.EventHandler(this.btnDeshacerMovimiento_Click);
            // 
            // btnVerMasMovimientos
            // 
            this.btnVerMasMovimientos.Location = new System.Drawing.Point(441, 50);
            this.btnVerMasMovimientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerMasMovimientos.Name = "btnVerMasMovimientos";
            this.btnVerMasMovimientos.Size = new System.Drawing.Size(154, 28);
            this.btnVerMasMovimientos.TabIndex = 3;
            this.btnVerMasMovimientos.Text = "Ver Más Movimientos";
            this.btnVerMasMovimientos.UseVisualStyleBackColor = true;
            // 
            // frmHistorialMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerMasMovimientos);
            this.Controls.Add(this.btnDeshacerMovimiento);
            this.Controls.Add(this.btnAgregarMovimiento);
            this.Controls.Add(this.listBoxMovimientos);
            this.Name = "frmHistorialMovimientos";
            this.Text = "Historial de Movimientos";
            this.Load += new System.EventHandler(this.frmHistorialMovimientos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMovimientos;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.Button btnDeshacerMovimiento;
        private System.Windows.Forms.Button btnVerMasMovimientos;
    }
}