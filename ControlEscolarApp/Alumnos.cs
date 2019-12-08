using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;

namespace ControlEscolarApp
{
    public partial class Alumnos : Form
    {
        EstadosManejador _estadosManejador;
        Estados _estados;
        MunicipiosManejador _municipioManejador;
        Municipios _municipios;
        AlumnoManejador _alumnoManejador;
        Entidades.ControlEscolarApp.Alumnos _alumnos;
        string z = "";

        private bool _isEnabledBinding = false;
        private bool XD = true;
        public Alumnos()
        {
            InitializeComponent();
            _estados = new Estados();
            _estadosManejador = new EstadosManejador();
            _municipioManejador = new MunicipiosManejador();
            _municipios = new Municipios();
            _alumnoManejador = new AlumnoManejador();
            _alumnos = new Entidades.ControlEscolarApp.Alumnos();
            LlenarCombos();
            _isEnabledBinding = true;
            BindAlumno();
        }

        public Alumnos(Entidades.ControlEscolarApp.Alumnos alumnos)
        {
            InitializeComponent();
            _estados = new Estados();
            _estadosManejador = new EstadosManejador();
            _municipioManejador = new MunicipiosManejador();
            _municipios = new Municipios();
            _alumnoManejador = new AlumnoManejador();
            _alumnos = alumnos;
            LlenarCombos();
            BindAlumnoTry2();
            _isEnabledBinding = true;
            XD = false;
        }

        private void LlenarCombos()
        {
            cmbEstado.DataSource = _estadosManejador.ObtenerLista();
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.ValueMember = "codigo";

            cmbMunicipio.DataSource = _municipioManejador.ObtenerLista(cmbEstado.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "nombre";
            cmbMunicipio.ValueMember = "idMunicipio";
        }

        private void Guardar()
        {
            _alumnoManejador.Guardar(_alumnos);
        }

        private void BindAlumno()
        {
            if (_isEnabledBinding)
            {
                if (_alumnos.NoControl == "")
                {
                    _alumnos.NoControl = "";
                }
                _alumnos.Nombre = txtNombre.Text;
                _alumnos.ApellidoPaterno = txtAP.Text;
                _alumnos.ApellidoMaterno = txtAM.Text;
                _alumnos.Genero = cmbGenero.Text;
                _alumnos.FechadeNacimiento = Fecha.Value.ToString("yyyy/MM/dd");
                _alumnos.CorreoElectronico = txtCorreo.Text;
                _alumnos.TelefonodeContacto = txtTelefono.Text;
                _alumnos.Estado = cmbEstado.SelectedValue.ToString();
                _alumnos.Municipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
                _alumnos.Domicilio = txtDomicilio.Text;
                if (XD)
                {
                    _alumnos.NoControl = Generar(Fecha.Value.ToString("yyyy")); 
                }
                else
                {
                    _alumnos.NoControl = z;
                }
            }
        }

        private void BindAlumnoTry2()
        {
            z = _alumnos.NoControl;
            txtNombre.Text = _alumnos.Nombre;
            txtAP.Text = _alumnos.ApellidoPaterno;
            txtAM.Text = _alumnos.ApellidoMaterno;
            cmbGenero.SelectedItem = _alumnos.Genero;
            Fecha.Text = _alumnos.FechadeNacimiento.ToString();
            txtCorreo.Text = _alumnos.CorreoElectronico;
            txtTelefono.Text = (_alumnos.TelefonodeContacto);
            cmbEstado.SelectedValue = _alumnos.Estado;
            cmbMunicipio.SelectedValue = Convert.ToString(_alumnos.Municipio);
            txtDomicilio.Text = _alumnos.Domicilio;
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = _municipioManejador.ObtenerLista(cmbEstado.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "nombre";
            cmbMunicipio.ValueMember = "idMunicipio";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BindAlumno();
                if (ValidarTo())
                {
                    _alumnoManejador.Guardar(_alumnos);
                    this.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private string Generar(string año)
        {
            string cadena = "";
            if (XD)
            {
                NoControl n = new NoControl();
               cadena = n.Generate(año, 4, "19");
            }
            return cadena;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Aqui validamos lo que falta

        private bool ValidarTo()
        {
            if (ValidarNombre()/* && ValidarTelefono()*/)
            {
                return true;
            }
            return false;
        }

        private bool ValidarNombre()
        {
            var res = _alumnoManejador.ComprobarNombre(_alumnos);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
        }

       private bool ValidarPhonne()
        {
            var res = _alumnoManejador.ComprobarTelefono(_alumnos);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
        }

        private void TxtNoControl_Click(object sender, EventArgs e)
        {

        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
