using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioAppTeoria
{
    using System;
    using System.Collections.Generic;

    public class HistorialMovimientos
    {
        private Stack<string> movimientos; 

        public HistorialMovimientos()
        {
            movimientos = new Stack<string>(); 
        }

       
        public void AgregarMovimiento(string movimiento)
        {
            movimientos.Push(movimiento);
        }

        
        public string DeshacerMovimiento()
        {
            if (movimientos.Count > 0)
            {
                return movimientos.Pop();
            }
            else
            {
                return "No hay movimientos para deshacer."; 
            }
        }

        public List<string> ObtenerMovimientos()
        {
            return new List<string>(movimientos);
        }
    }
}