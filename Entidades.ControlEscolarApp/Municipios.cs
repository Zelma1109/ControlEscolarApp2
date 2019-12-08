namespace Entidades.ControlEscolarApp
{
    public class Municipios
    {
        private int _idMunicipio;
        private string _nombre;
        private string _fkEstado;

        public int IdMunicipio { get => _idMunicipio; set => _idMunicipio = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string FkEstado { get => _fkEstado; set => _fkEstado = value; }

    }
}
