namespace GestionPedidos
{
    partial class frmGestionPedidos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstPedidosEspera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.Panel panelSiguiente;
        private System.Windows.Forms.Label lblTituloSiguiente;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSiguiente = new System.Windows.Forms.Panel();
            this.lblTituloSiguiente = new System.Windows.Forms.Label();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.lstPedidosEspera = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.panelSiguiente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(16, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(420, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE PEDIDOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSiguiente
            // 
            this.panelSiguiente.BackColor = System.Drawing.Color.LightYellow;
            this.panelSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSiguiente.Controls.Add(this.lblTituloSiguiente);
            this.panelSiguiente.Controls.Add(this.lblSiguiente);
            this.panelSiguiente.Location = new System.Drawing.Point(15, 57);
            this.panelSiguiente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSiguiente.Name = "panelSiguiente";
            this.panelSiguiente.Size = new System.Drawing.Size(421, 66);
            this.panelSiguiente.TabIndex = 1;
            // 
            // lblTituloSiguiente
            // 
            this.lblTituloSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloSiguiente.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTituloSiguiente.Location = new System.Drawing.Point(7, 8);
            this.lblTituloSiguiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloSiguiente.Name = "lblTituloSiguiente";
            this.lblTituloSiguiente.Size = new System.Drawing.Size(405, 31);
            this.lblTituloSiguiente.TabIndex = 0;
            this.lblTituloSiguiente.Text = "🎯 SIGUIENTE EN LA COLA:";
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSiguiente.ForeColor = System.Drawing.Color.Gray;
            this.lblSiguiente.Location = new System.Drawing.Point(3, 39);
            this.lblSiguiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(405, 25);
            this.lblSiguiente.TabIndex = 1;
            this.lblSiguiente.Text = "No hay pedidos en espera";
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContador.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContador.Location = new System.Drawing.Point(15, 134);
            this.lblContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(154, 38);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Total en cola: 0";
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloLista.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTituloLista.Location = new System.Drawing.Point(23, 172);
            this.lblTituloLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.Size = new System.Drawing.Size(157, 33);
            this.lblTituloLista.TabIndex = 3;
            this.lblTituloLista.Text = "📋 Pedidos en Espera:";
            // 
            // lstPedidosEspera
            // 
            this.lstPedidosEspera.BackColor = System.Drawing.Color.White;
            this.lstPedidosEspera.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstPedidosEspera.FormattingEnabled = true;
            this.lstPedidosEspera.ItemHeight = 23;
            this.lstPedidosEspera.Location = new System.Drawing.Point(11, 222);
            this.lstPedidosEspera.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstPedidosEspera.Name = "lstPedidosEspera";
            this.lstPedidosEspera.Size = new System.Drawing.Size(421, 96);
            this.lstPedidosEspera.TabIndex = 4;
            this.lstPedidosEspera.SelectedIndexChanged += new System.EventHandler(this.lstPedidosEspera_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(7, 340);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(203, 40);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "➕ Agregar Pedido";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDespachar
            // 
            this.btnDespachar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnDespachar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespachar.Enabled = false;
            this.btnDespachar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespachar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDespachar.ForeColor = System.Drawing.Color.White;
            this.btnDespachar.Location = new System.Drawing.Point(233, 340);
            this.btnDespachar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(203, 40);
            this.btnDespachar.TabIndex = 6;
            this.btnDespachar.Text = "🚀 Despachar Siguiente";
            this.btnDespachar.UseVisualStyleBackColor = false;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // frmGestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(834, 406);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelSiguiente);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblTituloLista);
            this.Controls.Add(this.lstPedidosEspera);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDespachar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmGestionPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Pedidos - Sistema de Cola";
            this.panelSiguiente.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}