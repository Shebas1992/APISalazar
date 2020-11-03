using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalazarEditoresBackEnd.Models
{
    public class ConexionDB
    {
        public MySqlConnection coneccion;
        //private string stringConeccion = "Server=servidorbasedatosmedicioagua.eastus.cloudapp.azure.com; Port=3306; Database=medidortesis; Uid=sebastian@servidortesissebas; Pwd=Admin!1234; SslMode=Preferred;";
        private string stringConeccion = "Server=localhost; Port=3306; Database=bdsalazareditores; Uid=root; Pwd= ;";
        public ConexionDB()
        {
            inicializar();
        }
        private void inicializar()
        {
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            coneccion = new MySqlConnection(stringConeccion);
        }
        public bool abrirConeccion()
        {
            try
            {
                coneccion.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("No abri la coneccion");
            }
            return false;
        }
        public bool cerrarConeccion()
        {
            try
            {
                coneccion.Close();
                return true;
            }
            catch (MySqlException ex)
            {

            }
            return false;
        }
    }
}