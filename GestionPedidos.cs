using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionPedidos
{
    public partial class frmGestionPedidos : Form
    {
        private Queue<string> colaPedidos;
        private int contadorPedidos;

        public frmGestionPedidos()
        {
            InitializeComponent();
            colaPedidos = new Queue<string>();
            contadorPedidos = 0;
        }

       /* private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Solicitar el nombre del pedido al usuario
            string nombrePedido = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la descripción del pedido:",
                "Nuevo Pedido por confirmar",
                "");

            if (!string.IsNullOrWhiteSpace(nombrePedido))
            {
                contadorPedidos++;
                string pedido = $"Pedido #{contadorPedidos} - {nombrePedido}";

                // Agregar a la cola
                colaPedidos.Enqueue(pedido);

                // Agregar a la lista visual
                lstPedidosEspera.Items.Add(pedido);

                // Actualizar interfaz
                ActualizarSiguiente();

                MessageBox.Show($"Pedido agregado exitosamente!\nTotal en cola: {colaPedidos.Count}",
                              "Éxito",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }
       */
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (colaPedidos.Count > 0)
            {
                // Despachar el siguiente pedido (FIFO)
                string pedidoDespachado = colaPedidos.Dequeue();

                // Remover de la lista visual
                lstPedidosEspera.Items.RemoveAt(0);

                // Actualizar interfaz
                ActualizarSiguiente();

                MessageBox.Show($"Pedido despachado:\n\n{pedidoDespachado}\n\nPedidos restantes: {colaPedidos.Count}",
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
            if (colaPedidos.Count > 0)
            {
                // Mostrar el siguiente sin sacarlo de la cola (Peek)
                string siguiente = colaPedidos.Peek();
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

            // Actualizar contador total
            lblContador.Text = $"Total en cola: {colaPedidos.Count}";
        }

        private void lstPedidosEspera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
