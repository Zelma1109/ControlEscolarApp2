namespace Entidades.ControlEscolarApp
{
    public class Usuarios
    {
        private int _idUsuario;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
    }
}
