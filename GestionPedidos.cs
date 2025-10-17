using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionPedidos
{
    public partial class frmGestionPedidos : Form
    {
        private List<string> pedidos;
        private int contadorPedidos;

        public frmGestionPedidos()
        {
            InitializeComponent();
            pedidos = new List<string>();
            contadorPedidos = 0;
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (pedidos.Count > 0)
            {
                string pedidoDespachado = pedidos[0];
                pedidos.RemoveAt(0);
                lstPedidosEspera.Items.RemoveAt(0);
                ActualizarSiguiente();
                MessageBox.Show($"Pedido despachado:\n\n{pedidoDespachado}\n\nPedidos restantes: {pedidos.Count}",
                              "Pedido Despachado",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay pedidos en espera para despachar.",
                              "Advertencia",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
        }

        private void ActualizarSiguiente()
        {
            if (pedidos.Count > 0)
            {
                string siguiente = pedidos[0];
                lblSiguiente.Text = $"Siguiente: {siguiente}";
                lblSiguiente.ForeColor = System.Drawing.Color.DarkGreen;
                btnDespachar.Enabled = true;
            }
            else
            {
                lblSiguiente.Text = "No hay pedidos en espera";
                lblSiguiente.ForeColor = System.Drawing.Color.Gray;
                btnDespachar.Enabled = false;
            }
            lblContador.Text = $"Total en cola: {pedidos.Count}";
        }

        private void lstPedidosEspera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
