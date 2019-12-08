using System;

namespace Entidades.ControlEscolarApp
{
     public class Escuela
    {
        private int _idesc;
        private string _escuela;
        private string _domicilio;
        private string _noext;
        private string _estado;
        private int _municipio;
        private string _telefono;
        private string _pagweb;
        private string _correo;
        private string _director;
        private string _imagen;
        private string _rutaimagen;

        public int Idesc { get => _idesc; set => _idesc = value; }
        public string Escuelas { get => _escuela; set => _escuela = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Noext { get => _noext; set => _noext = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Municipio { get => _municipio; set => _municipio = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string PagWeb { get => _pagweb; set => _pagweb = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Director { get => _director; set => _director = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }
        public string Rutaimagen { get => _rutaimagen; set => _rutaimagen = value; }
    }
}
