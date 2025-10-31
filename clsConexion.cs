using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventarioAppTeoria
{
    internal class clsConexion
    {
        SqlConnection conex = new SqlConnection("server = DESKTOP-HBB5D0V\\SQLEXPRESS ; database = master; integrated security= true");
        static string servidor= "localhost";
        static string bD ="pp";
        static string usuario = "sJoseth";
        static string contraseña = "Joseth07";
        static string puerto= "0";
        string cadenaConexion = "Data Source=" + servidor+ "," + puerto +";"+ "user id="+usuario +";"+ "password=" + contraseña + ";" + "Initial Catalog=" + bD+ ";"+"Persist Security Info=true";

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Conexión exitosa a la base de datos ");
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexión: " + e.Message);
                return null;
            }
            return conex;
        }

    }

   




}
