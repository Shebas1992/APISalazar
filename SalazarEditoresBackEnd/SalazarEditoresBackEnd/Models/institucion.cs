using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalazarEditoresBackEnd.Models
{
    public class institucion
    {
        private int idinstitucion;
        private string nombre;
        private string provincia;
        private string ciudad;

        public int Idinstitucion { get => idinstitucion; set => idinstitucion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}