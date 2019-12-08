using System;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using System.Windows.Forms;

namespace ControlEscolarApp
{
    public partial class CarrerasBusq : Form
    {
        CarrerasManejador _carrerasManejador;
        Carreras _carreras;
        public CarrerasBusq()
        {
            InitializeComponent();
            _carrerasManejador = new CarrerasManejador();
            _carreras = new Carreras();
            BuscarCarreras();
            _carreras.IdCarrera = 0;
        }
        public void BuscarCarreras()
        {
            dgvCarreras.DataSource = _carrerasManejador.ObtenerAlumnos();
        }
        private void Eliminar(int nControl)
        {
            _carrerasManejador.Eliminar(nControl);
        }

        private void Guardar(Carreras carreras)
        {
            _carreras.Nombre = txtnombre.Text;
            _carrerasManejador.Guardar(carreras);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Guardar(_carreras);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Favor de confirmar", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar(_carreras.IdCarrera);
                    BuscarCarreras();
                }
                catch (Exception)
                {
                    MessageBox.Show("No eliminado");
                }
            }
            
        }
        private void BindAlumno()
        {
            _carreras.IdCarrera = Convert.ToInt32((dgvCarreras.CurrentRow.Cells["idCarrera"].Value).ToString());
            _carreras.Nombre = ((dgvCarreras.CurrentRow.Cells["nombre"].Value).ToString());
        }

        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindAlumno();
        }

        private void dgvCarreras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindAlumno();
            CarreasModal alumnos = new CarreasModal(_carreras);
            alumnos.ShowDialog();
            BuscarCarreras();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarrerasBusq_Load(object sender, EventArgs e)
        {

        }
    }
}
