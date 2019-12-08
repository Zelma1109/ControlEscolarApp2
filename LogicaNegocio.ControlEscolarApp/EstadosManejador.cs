using AccesoDatos.ContolEscolarApp;
using Entidades.ControlEscolarApp;
using System.Collections.Generic;

namespace LogicaNegocio.ControlEscolarApp
{
    public class EstadosManejador
    {
        private EstadosAccesoDatos _estadosAccesoDatos;

        public EstadosManejador()
        {
            _estadosAccesoDatos = new EstadosAccesoDatos();
        }

        public List<Estados> ObtenerLista()
        {
            var list = new List<Estados>();
            list = _estadosAccesoDatos.ObtenerLista();
            return list;
        }
    }
}
