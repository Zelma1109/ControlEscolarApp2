using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using Extentions.ControlEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class EscuelapruebaManejador
    {
        private EscuelapruebaAccesoDatos _escuelapruebaAccesoDatos = new EscuelapruebaAccesoDatos();
        private RutasManager _rutasManager;

        public EscuelapruebaManejador(RutasManager rutasManager)
        {
            _rutasManager = rutasManager;

        }

        public void Guardar(Escuelaprueba escuela)
        {
            _escuelapruebaAccesoDatos.Guardar(escuela);
        }

        public Escuelaprueba GetEscuela()
        {
            return _escuelapruebaAccesoDatos.GetEscuela();
        }

        public string GetNombreLogo(string fileName)
        {
            var archivoNombre = new FileInfo(fileName);
            return archivoNombre.Name;
        }

        public void LimpiarDocumento(int escuelaId, string tipoDocumento)
        {
            string rutaRepositorio = "";
            string extension = "";

            switch (tipoDocumento)
            {
                case "png":
                    rutaRepositorio = _rutasManager.RutasRepositoritoriosLogos;
                    extension = "*.png";
                    break;
                case "jpg":
                    rutaRepositorio = _rutasManager.RutasRepositoritoriosLogos;
                    extension = "*.jpg";
                    break;

            }

            string ruta = Path.Combine(rutaRepositorio, escuelaId.ToString());
            if (Directory.Exists(ruta))
            {
                var obtenerArchivos = Directory.GetFiles(ruta, extension);
                FileInfo archivoAnterior;
                if (obtenerArchivos.Length != 0)
                {
                    archivoAnterior = new FileInfo(obtenerArchivos[0]);

                    if (archivoAnterior.Exists)
                    {
                        archivoAnterior.Delete();
                    }
                }
            }
        }

        public bool CargarLogo(string filename)
        {
            var archivosnombre = new FileInfo(filename);
            {
                if (archivosnombre.Length > 5000000)
                    return false;
            }
            return true;
        }

        public void GuardarLogo(string fileName, int escuelaId)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                var archivoDocument = new FileInfo(fileName);
                string ruta = Path.Combine(_rutasManager.RutasRepositoritoriosLogos, escuelaId.ToString());
                if (Directory.Exists(ruta))
                {
                    var obtenerArchivos = Directory.GetFiles(ruta);
                    FileInfo archivoAnterior;

                    if (obtenerArchivos.Length != 0)
                    {
                        archivoAnterior = new FileInfo(obtenerArchivos[0]);

                        if (archivoAnterior.Exists)
                        {
                            archivoAnterior.Delete();
                            archivoDocument.CopyTo(Path.Combine(ruta, archivoDocument.Name));
                        }
                    }
                    else
                    {
                        archivoDocument.CopyTo(Path.Combine(ruta, archivoDocument.Name));
                    }
                }
                else
                {
                    _rutasManager.CrearRepositorioLogosEscuela(escuelaId);
                    archivoDocument.CopyTo(Path.Combine(ruta, archivoDocument.Name));
                }
            }
        }
    }
}
