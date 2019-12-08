namespace Entidades.ControlEscolarApp
{
    public class Maestros
    {
        private string _noControlM;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _genero;
        private string _fechadeNacimiento;
        private string _correoElectronico;
        private string _telefonodeContacto;
        private string _estado;
        private int _municipio;
        private string _nocuenta;
        private string _licenciatura;
        private string _maestria;
        private string _doctorado;

        public string NoControlM { get => _noControlM; set => _noControlM = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string FechadeNacimiento { get => _fechadeNacimiento; set => _fechadeNacimiento = value; }
        public string CorreoElectronico { get => _correoElectronico; set => _correoElectronico = value; }
        public string TelefonodeContacto { get => _telefonodeContacto; set => _telefonodeContacto = value; }
        public string nocuenta { get => _nocuenta; set => _nocuenta = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Municipio { get => _municipio; set => _municipio = value; }
        public string Licenciatura { get => _licenciatura; set => _licenciatura = value; }
        public string Maestria { get => _maestria; set => _maestria = value; }
        public string Doctorado { get => _doctorado; set => _doctorado = value; }

    }
}
