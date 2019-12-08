using System.Collections.Generic;
using AccesoDatos.ContolEscolarApp;
using Entidades.ControlEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class MunicipiosManejador
    {
        private MunicipiosAccesoDatos _municipiosAccesoDatos;

        public MunicipiosManejador()
        {
            _municipiosAccesoDatos = new MunicipiosAccesoDatos();
        }

        public List<Municipios> ObtenerLista(string estado)
        {
            var list = new List<Municipios>();
            list = _municipiosAccesoDatos.ObtenerLista(estado);
            return list;
        }
    }
}
