using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using System.IO;
using System.Drawing;
namespace ControlEscolarApp
{
    public partial class MaestrosModal : Form
    {
        EstadosManejador _estadosManejador;
        Estados _estados;
        MunicipiosManejador _municipioManejador;
        Municipios _municipios;
        MaestroManejador _maestroManejador;
        Entidades.ControlEscolarApp.Maestros _maestros;
        string z = "";

        private bool _isEnabledBinding = false;
        private bool XD = true;
        private bool _isANewElement = true;
        string Dir;

        public MaestrosModal()
        {
            InitializeComponent();
            _estados = new Estados();
            _estadosManejador = new EstadosManejador();
            _municipioManejador = new MunicipiosManejador();
            _municipios = new Municipios();
            _maestroManejador = new MaestroManejador();
            _maestros = new Entidades.ControlEscolarApp.Maestros();
            LlenarCombos();
            _isEnabledBinding = true;
            BindMaestro();
        }

        public MaestrosModal(Entidades.ControlEscolarApp.Maestros maestros)
        {
            InitializeComponent();
            _estados = new Estados();
            _estadosManejador = new EstadosManejador();
            _municipioManejador = new MunicipiosManejador();
            _municipios = new Municipios();
            _maestroManejador = new MaestroManejador();
            _maestros = new Entidades.ControlEscolarApp.Maestros();
            LlenarCombos();
            BindMaestroTry2();
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
            _maestroManejador.Guardar(_maestros);
        }
        private void BindMaestro()
        {
            if (_isEnabledBinding)
            {
                if (_maestros.NoControlM == "")
                {
                    _maestros.NoControlM = "";
                }
                _maestros.Nombre = txtNombre.Text;
                _maestros.ApellidoPaterno = txtAP.Text;
                _maestros.ApellidoMaterno = txtAM.Text;
                _maestros.Genero = cmbGenero.Text;
                _maestros.FechadeNacimiento = Fecha.Value.ToString("yyyy/MM/dd");
                _maestros.CorreoElectronico = txtCorreo.Text;
                _maestros.TelefonodeContacto = txtTelefono.Text;
                _maestros.Estado = cmbEstado.SelectedValue.ToString();
                _maestros.Municipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
                _maestros.nocuenta = txtnocuenta.Text;
                _maestros.Licenciatura = Txt_Licenciatura.Text;
                _maestros.Maestria = Txt_Maestria.Text;
                _maestros.Doctorado = Txt_Doctorado.Text;

                if (XD)
                {
                    _maestros.NoControlM = Generar(Fecha.Value.ToString("yyyy"));
                }
                else
                {
                    _maestros.NoControlM = z;
                }
            }
        }


        private void BindMaestroTry2()
        {
            z = _maestros.NoControlM;
            txtNombre.Text = _maestros.Nombre;
            txtAP.Text = _maestros.ApellidoPaterno;
            txtAM.Text = _maestros.ApellidoMaterno;
            cmbGenero.SelectedItem = _maestros.Genero;
            Fecha.Text = _maestros.FechadeNacimiento.ToString();
            txtCorreo.Text = _maestros.CorreoElectronico;
            txtTelefono.Text = (_maestros.TelefonodeContacto);
            cmbEstado.SelectedValue = _maestros.Estado;
            cmbMunicipio.SelectedValue = Convert.ToString(_maestros.Municipio);
            txtnocuenta.Text = _maestros.nocuenta;
            Txt_Licenciatura.Text = _maestros.Licenciatura;
            Txt_Maestria.Text = _maestros.Maestria;
            Txt_Doctorado.Text = _maestros.Doctorado;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BindMaestro();
                {
                    _maestroManejador.Guardar(_maestros);
                    this.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            /* string asd = "";
             if (_isANewElement)
             {
                 string date = DateTime.Now.ToString("yyyy");
                 string suma = "01";
                 asd = ("LD" + date + suma.ToString());
                 while (_maestroManejador.ObtenerNumControl(asd) == 1)
                 {
                     int cat = Convert.ToInt32(suma);
                     cat++;
                     suma = cat.ToString();
                     if (suma.Length < 2)
                     {
                         suma = ("0" + suma);
                     }
                     asd = ("LD" + date + suma.ToString());
                 }
             }
             return asd;*/
        }


        private bool ValidarNombre()
        {
            var res = _maestroManejador.ComprobarNombre(_maestros);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
        }

        private bool ValidarPhonne()
        {
            var res = _maestroManejador.ComprobarTelefono(_maestros);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = _municipioManejador.ObtenerLista(cmbEstado.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "nombre";
            cmbMunicipio.ValueMember = "idMunicipio";
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = _municipioManejador.ObtenerLista(cmbEstado.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "nombre";
            cmbMunicipio.ValueMember = "idMunicipio";
        }

        private void Btn_rutaD_Click(object sender, EventArgs e)
        {
            OpenFileDialog getarchivo = new OpenFileDialog();
            getarchivo.InitialDirectory = "C:\\";
            getarchivo.Filter = "Archivos (*.pdf)(*.docx)|*.pdf; *.docx";

            if (getarchivo.ShowDialog() == DialogResult.OK)
            {
                Txt_Doctorado.Text = getarchivo.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado el archivo deceado", "Sin seleccion",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_rutaM_Click(object sender, EventArgs e)
        {
            OpenFileDialog getarchivo = new OpenFileDialog();
            getarchivo.InitialDirectory = "C:\\";
            getarchivo.Filter = "Archivos (*.pdf)(*.docx)|*.pdf; *.docx";

            if (getarchivo.ShowDialog() == DialogResult.OK)
            {
                Txt_Maestria.Text = getarchivo.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado el archivo deceado", "Sin seleccion",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_rutaL_Click(object sender, EventArgs e)
        {
            OpenFileDialog getarchivo = new OpenFileDialog();
            getarchivo.InitialDirectory = "C:\\";
            getarchivo.Filter = "Archivos (*.pdf)(*.docx)|*.pdf; *.docx";

            if (getarchivo.ShowDialog() == DialogResult.OK)
            {
                Txt_Licenciatura.Text = getarchivo.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado el archivo deceado", "Sin seleccion",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string ruta = "";
            ruta = (@"/Esc/" + txtNombre.Text.Trim());
            bool exist;

            exist = (Directory.Exists(ruta));
            if (!exist)
            {
                Directory.CreateDirectory(ruta);
                MessageBox.Show("se ha Creado ");
                try
                {
                    BindMaestro();
                    if (ValidarTo())
                    {
                        _maestroManejador.Guardar(_maestros);
                        this.Close();
                    }

                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("No se ha creado, sorry :C");
            }
                    
        }
        private bool ValidarTo()
        {
            if (ValidarNombre()/* && ValidarTelefono()*/)
            {
                return true;
            }
            return false;
        }

    }
}
