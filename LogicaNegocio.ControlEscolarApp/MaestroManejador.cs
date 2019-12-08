using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;


namespace LogicaNegocio.ControlEscolarApp
{
    public class MaestroManejador
    {
        private MaestrosAccesoDatos _maestrosAccesoDatos;
        public MaestroManejador()
        {
            _maestrosAccesoDatos = new MaestrosAccesoDatos();
        }

        public void Eliminar(string nControlM)
        {
            _maestrosAccesoDatos.Eliminar(nControlM);
        }

        public void Guardar(Maestros maestros)
        {
            _maestrosAccesoDatos.Guardar(maestros);
        }

        public List<Maestros> ObtenerAlumnos(string filtro)
        {
            var list = new List<Maestros>();
            list = _maestrosAccesoDatos.ObtenerLista(filtro);
            return list;
        }

        public int ObtenerNumControl(string nControlM)
        {
            return _maestrosAccesoDatos.ObtenerNumControlM(nControlM);
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
        public Tuple<bool, string> ComprobarNombre(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;
            if (maestros.Nombre.Length == 0)
            {
                mensaje = "El nombre no es correcto, XD";
                valido = false;
            }
            else if (!NombreValido(maestros.Nombre))
            {
                mensaje = "Por favor, Verifica el nombre";
                valido = false;
            }
            else if (maestros.Nombre.Length > 100)
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

        public Tuple<bool, string> ComprobarTelefono(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.TelefonodeContacto.Length == 0)
            {
                mensaje = "Telefono Vacio XD";
                valido = false;
            }
            else if (!TelValido(maestros.TelefonodeContacto))
            {
                mensaje = "Ingresa  correctamente el numero de telefono";
                valido = false;
            }
            else if (maestros.TelefonodeContacto.Length > 10)
            {
                mensaje = "Se exedio la cantidad de numeros :3";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public object EsUsuarioValido(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.Nombre.Length == 0)
            {
                mensaje = "El nombre del Maestro es necesario";
                valido = false;
            }
            else if (!NombreValido(maestros.Nombre))
            {
                mensaje = "Escribe un fomato valido para el nombre";
                valido = false;
            }
            else if (maestros.Nombre.Length > 100)
            {
                mensaje = "La longitud para nombre no debe exceder 100 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        

       
        public Tuple<bool, string> EsTarjetaValida(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.nocuenta.Length >= 15)
            {
                mensaje = "El numero de tarjeta no puede ser mayor a 15 digitos";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
    }
}
