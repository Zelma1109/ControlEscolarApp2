using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;

namespace LogicaNegocio.ControlEscolarApp
{
    public class AlumnoManejador
    {
        private AlumnosAccesoDatos _alumnoAccesoDatos;

        public AlumnoManejador()
        {
            _alumnoAccesoDatos = new AlumnosAccesoDatos();
        }

        public void Eliminar(string nControl)
        {
            _alumnoAccesoDatos.Eliminar(nControl);
        }

        public void Guardar(Alumnos alumnos)
        {
            _alumnoAccesoDatos.Guardar(alumnos);
        }

        public List<Alumnos> ObtenerAlumnos(string filtro)
        {
            var list = new List<Alumnos>();
            list = _alumnoAccesoDatos.ObtenerLista(filtro);
            return list;
        }

        public int ObtenerNumControl(string nControl)
        {
            return _alumnoAccesoDatos.ObtenerNumControl(nControl);
        }

       //Validacion nombre XD
        private bool NombreValido(string nombre)
        {
            var regex = new Regex(@"^[A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ]+( [A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ]+)*$");
            var match = regex.Match(nombre);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        //Aqui se comprueba el combre
        public Tuple<bool, string> ComprobarNombre(Alumnos alumno)
        {
            string mensaje = "";
            bool valido = true;
            if (alumno.Nombre.Length == 0)
            {
                mensaje = "El nombre no es correcto, XD";
                valido = false;
            }
            else if (!NombreValido(alumno.Nombre))
            {
                mensaje = "Por favor, Verifica el nombre";
                valido = false;
            }
            else if (alumno.Nombre.Length > 100)
            {
                mensaje = "Se exede del tamaño ";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
        

        private bool CorreoValido(string correo)
        {
            var regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$");
            var match = regex.Match(correo);

            if (match.Success)
            {
                return true;
            }

            return false;
        }

       //Validacion para numero de Telefono
        private bool TelValido(string tel)
        {
            var regex = new Regex(@"^[0-9][10]");
            var match = regex.Match(tel);

            if (match.Success)
            {
                return true;
            }

            return false;
        }

        public Tuple<bool, string> ComprobarTelefono(Alumnos alumnos)
        {
            string mensaje = "";
            bool valido = true;

            if (alumnos.TelefonodeContacto.Length == 0)
            {
                mensaje = "Telefono Vacio XD";
                valido = false;
            }
            else if (!TelValido(alumnos.TelefonodeContacto))
            {
                mensaje = "Ingresa  correctamente el numero de telefono";
                valido = false;
            }
            else if (alumnos.TelefonodeContacto.Length > 10)
            {
                mensaje = "Se exedio la cantidad de numeros :3";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
    }
}
