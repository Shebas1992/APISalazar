using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalazarEditoresBackEnd.Models
{
    public class libro
    {
        private int idlibro;
        private string titulo;
        private string autores;
        private string sinopsis;
        private string tipo;
        private float precio;
        private string urlimagen;
        private string urllibropdf;
        private string rangoedad;
        private string categoria;
        private string coleccion;
        private List<video> listavideos;

        public int Idlibro { get => idlibro; set => idlibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autores { get => autores; set => autores = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Urlimagen { get => urlimagen; set => urlimagen = value; }
        public string Urllibropdf { get => urllibropdf; set => urllibropdf = value; }
        public string Rangoedad { get => rangoedad; set => rangoedad = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Coleccion { get => coleccion; set => coleccion = value; }
        public List<video> Listavideos { get => listavideos; set => listavideos = value; }
    }
}