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
            this.listBoxMovimientos.ItemHeight = 16;
            this.listBoxMovimientos.Location = new System.Drawing.Point(25, 12);
            this.listBoxMovimientos.Name = "listBoxMovimientos";
            this.listBoxMovimientos.Size = new System.Drawing.Size(344, 260);
            this.listBoxMovimientos.TabIndex = 0;
            this.listBoxMovimientos.SelectedIndexChanged += new System.EventHandler(this.listBoxMovimientos_SelectedIndexChanged);
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(55, 56);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(206, 39);
            this.btnAgregarMovimiento.TabIndex = 1;
            this.btnAgregarMovimiento.Text = "Agregar Movimiento";
            this.btnAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // btnDeshacerMovimiento
            // 
            this.btnDeshacerMovimiento.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeshacerMovimiento.Location = new System.Drawing.Point(55, 101);
            this.btnDeshacerMovimiento.Name = "btnDeshacerMovimiento";
            this.btnDeshacerMovimiento.Size = new System.Drawing.Size(206, 45);
            this.btnDeshacerMovimiento.TabIndex = 2;
            this.btnDeshacerMovimiento.Text = "Deshacer Movimiento";
            this.btnDeshacerMovimiento.UseVisualStyleBackColor = true;
            this.btnDeshacerMovimiento.Click += new System.EventHandler(this.btnDeshacerMovimiento_Click);
            // 
            // btnVerMasMovimientos
            // 
            this.btnVerMasMovimientos.Location = new System.Drawing.Point(55, 152);
            this.btnVerMasMovimientos.Name = "btnVerMasMovimientos";
            this.btnVerMasMovimientos.Size = new System.Drawing.Size(206, 35);
            this.btnVerMasMovimientos.TabIndex = 3;
            this.btnVerMasMovimientos.Text = "Ver Más Movimientos";
            this.btnVerMasMovimientos.UseVisualStyleBackColor = true;
            // 
            // frmHistorialMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVerMasMovimientos);
            this.Controls.Add(this.btnDeshacerMovimiento);
            this.Controls.Add(this.btnAgregarMovimiento);
            this.Controls.Add(this.listBoxMovimientos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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