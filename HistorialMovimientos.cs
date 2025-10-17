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
    public partial class frmHistorialMovimientos : Form
    {
        private HistorialMovimientos historial;
        public frmHistorialMovimientos()
        {
            InitializeComponent();
            historial = new HistorialMovimientos();
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            string movimiento = "Producto A retirado";
        }

        private void listBoxMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmHistorialMovimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnDeshacerMovimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
