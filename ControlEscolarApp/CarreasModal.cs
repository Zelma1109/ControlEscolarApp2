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

namespace ControlEscolarApp
{
    public partial class CarreasModal : Form
    {
        Carreras _carreras;
        MateriasManejador _materiasManejador;
        Materias _materias;

        private bool _isEnabledBinding = false;
        public CarreasModal(Carreras carreras)
        {
            InitializeComponent();
            _carreras = carreras;
            _materiasManejador = new MateriasManejador();
            _materias = new Materias();
            _isEnabledBinding = true;
            CargarDatos(_carreras.IdCarrera);
            LlenarCombos();

        }

        public CarreasModal()
        {
            InitializeComponent();
        }

        private void LlenarCombos()
        {
            cmbMateriaAn.DataSource = _materiasManejador.ObtenerAlumnos(_carreras.IdCarrera);
            cmbMateriaAn.DisplayMember = "nombre";
            cmbMateriaAn.ValueMember = "matMateria";

            cmbMateriaIn.DataSource = _materiasManejador.ObtenerAlumnos(_carreras.IdCarrera);
            cmbMateriaIn.DisplayMember = "nombre";
            cmbMateriaIn.ValueMember = "matMateria";
        }
        private void CargarDatos(int filtro)
        {
            DtgMaterias.DataSource = _materiasManejador.ObtenerAlumnos(filtro);
        }
        private void Eliminar(string nuControl)
        {
            _materiasManejador.Eliminar(nuControl);
        }

        private void Guardar()
        {
            BindAlumno();
            _materiasManejador.Guardar(_materias);
        }

        private void BindAlumno()
        {
            if (_isEnabledBinding)
            {
                if (_materias.MatMateria == "")
                {
                    _materias.MatMateria = "";
                }
                _materias.MatMateria = txtMatricula.Text;
                _materias.Nombre = txtNombre.Text;
                _materias.Horas = Convert.ToInt32(txtHoras.Text);
                _materias.Creditos = Convert.ToInt32(txtCreditos.Text);
                _materias.FkAntecesor = cmbMateriaAn.SelectedValue.ToString();
                _materias.FkPredecesor = (cmbMateriaIn.SelectedValue.ToString());
                _materias.FkCarrera = _carreras.IdCarrera;
                if (cbAntecesor.Checked == true)
                {
                    _materias.FkAntecesor = null;
                }
                if (cbpredecesor.Checked == true)
                {
                    _materias.FkPredecesor = null;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarDatos(_carreras.IdCarrera);
        }

        private void CarreasModal_Load(object sender, EventArgs e)
        {

        }

        private void DtgMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindAlumno();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Favor de confirmar", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar(_materias.MatMateria);
                    CargarDatos(_carreras.IdCarrera);
                }
                catch (Exception)
                {
                    MessageBox.Show("No we");
                }
            }
        }
    }
}
