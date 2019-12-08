using System;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using System.Windows.Forms;

namespace ControlEscolarApp
{
    public partial class GruposModal : Form
    {
        Entidades.ControlEscolarApp.Grupos _grupos;
        UnionesManejador _unionesManejador;
        Unionga _unionGA;
        Uniongm _unionGM;

        AlumnoManejador _alumnoManejador;
        Alumnos _alumnos;

        MateriasManejador _materiasManejador;
        Materias _materias;
        public GruposModal(Entidades.ControlEscolarApp.Grupos grupos)
        {
            InitializeComponent();
            _grupos = grupos;
            _unionesManejador = new UnionesManejador();
            _unionGA = new Unionga();
            _unionGM = new Uniongm();
            _alumnoManejador = new AlumnoManejador();
            _alumnos = new Alumnos();
            _materiasManejador = new MateriasManejador();
            _materias = new Materias();
            cargarUnionGM(_grupos.Semestre);
            cargarUnionGA(_grupos.Semestre);
            LlenarCombos();
        }

        public GruposModal()
        {
            InitializeComponent();
        }

        private void LlenarCombos()
        {
            cmbMaterias.DataSource = _materiasManejador.ObtenerAlumnos("");
            cmbMaterias.DisplayMember = "nombre";
            cmbMaterias.ValueMember = "matMateria";

            cmbAlumnos.DataSource = _alumnoManejador.ObtenerAlumnos("");
            cmbAlumnos.DisplayMember = "nombre";
            cmbAlumnos.ValueMember = "noControl";

        }

        #region Union Grupos - Alumnos
        private void cargarUnionGA(string filtro)
        {
            dgvUnionGA.DataSource = _unionesManejador.CargarGA(filtro);
        }

        private void EliminarGA(int id)
        {
            _unionesManejador.EliminarGA(id);
        }

        private void TagGA()
        {
            _unionGA.IdUnion = Convert.ToInt32((dgvUnionGA.CurrentRow.Cells["idUnion"].Value).ToString());
            cmbAlumnos.SelectedValue = ((dgvUnionGM.CurrentRow.Cells["nombre"].Value).ToString());
        }

        private void BindGA()
        {
            _unionGA.FkGrupo = _grupos.IdGrupo;
            _unionGA.FkAlumno = cmbAlumnos.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Favor de confirmar", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    EliminarGA(_unionGM.IdUnion);
                    cargarUnionGA(_grupos.Semestre);
                }
                catch (Exception)
                {
                    MessageBox.Show("No we");
                }
            }
        }

        private void Btn_guardarA_Click(object sender, EventArgs e)
        {
            BindGA();
            _unionesManejador.GuardarGA(_unionGA);
            cargarUnionGA(_grupos.Semestre);
        }
        private void cargarUnionGM(string filtro)
        {
            dgvUnionGM.DataSource = _unionesManejador.CargarGM(filtro);
        }

        private void EliminarGM(int id)
        {
            _unionesManejador.EliminarGM(id);
        }

        private void TagGM()
        {
            _unionGM.IdUnion = Convert.ToInt32((dgvUnionGM.CurrentRow.Cells["idUnion"].Value).ToString());
            cmbMaterias.SelectedValue = ((dgvUnionGM.CurrentRow.Cells["nombre"].Value).ToString());
        }

        private void BindGM()
        {
            _unionGM.FkGrupo = _grupos.IdGrupo;
            _unionGM.FkMateria = cmbMaterias.SelectedValue.ToString();
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Favor de confirmar", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    EliminarGM(_unionGM.IdUnion);
                    cargarUnionGM(_grupos.Semestre);
                }
                catch (Exception)
                {
                    MessageBox.Show("No we");
                }
            }
        }
        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            BindGM();
            _unionesManejador.GuardarGM(_unionGM);
            cargarUnionGM(_grupos.Semestre);
        }


        #endregion

        private void dgvUnionGA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TagGA();
        }

        private void dgvUnionGM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TagGM();
        }

        private void GruposModal_Load(object sender, EventArgs e)
        {

        }

        private void dgvUnionGA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
