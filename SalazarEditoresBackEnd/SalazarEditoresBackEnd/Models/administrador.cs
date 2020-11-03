using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalazarEditoresBackEnd.Models
{
    public class administrador
    {
        private int idadministrador;
        private string nombres;
        private string apellidos;
        private string correo;
        private string contrasena;

        public int Idadministrador { get => idadministrador; set => idadministrador = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}