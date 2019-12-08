namespace Entidades.ControlEscolarApp
{
    public class Alumnos
    {
        private string _noControl;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _genero;
        private string _fechadeNacimiento;
        private string _correoElectronico;
        private string _telefonodeContacto;
        private string _estado;
        private int _municipio;
        private string _domicilio;

        public string NoControl { get => _noControl; set => _noControl = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string FechadeNacimiento { get => _fechadeNacimiento; set => _fechadeNacimiento = value; }
        public string CorreoElectronico { get => _correoElectronico; set => _correoElectronico = value; }
        public string TelefonodeContacto { get => _telefonodeContacto; set => _telefonodeContacto = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Municipio { get => _municipio; set => _municipio = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }

    }
}
