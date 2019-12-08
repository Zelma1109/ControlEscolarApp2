using System.Collections.Generic;

namespace AccesoDatos.ContolEscolarApp
{
    interface IaccesoDatos
    {
        void Guardar();
        void Eliminar();
        List<object> ObtenerLista();
    }
}
