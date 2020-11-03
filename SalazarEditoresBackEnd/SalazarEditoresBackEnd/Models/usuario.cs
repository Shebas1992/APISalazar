using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalazarEditoresBackEnd.Models
{
    public class usuario
    {
        private int idusuario;
        private string nombres;
        private string apellidos;
        private string correo;
        private string contrasena;
        private string direccion;
        private string telefono;
        private DateTime fechanacimiento;
        private string tipo;
        private bool habilitado;
        private List<servicio> listaservicios;

        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public List<servicio> Listaservicios { get => listaservicios; set => listaservicios = value; }
    }
}