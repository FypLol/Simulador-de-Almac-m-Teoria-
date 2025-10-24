using GestionPedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventarioAppTeoria
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btn_hitorial_Click(object sender, EventArgs e)
        {
            frmHistorialMovimientos historialMovimientos = new frmHistorialMovimientos();
            historialMovimientos.Show();
        }

        private void btn_gestionInventario_Click(object sender, EventArgs e)
        {
            frmGestion_de_Inventario gestionInventario = new frmGestion_de_Inventario();
            gestionInventario.Show();
        }

        private void btn_gestionPedido_Click(object sender, EventArgs e)
        {
            frmGestionPedidos gestionPedidos = new frmGestionPedidos();
            gestionPedidos.Show();
        }
    }
}
