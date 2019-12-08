using System;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using System.Windows.Forms;

namespace ControlEscolarApp
{
    public partial class Grupos : Form
    {
        GruposManejador _gruposManejador;
        Entidades.ControlEscolarApp.Grupos _grupos;
        Carreras _carreras;
        CarrerasManejador _carrerasManejador;

        private int GetSomething;
        public Grupos()
        {
            InitializeComponent();
            _gruposManejador = new GruposManejador();
            _grupos = new Entidades.ControlEscolarApp.Grupos();
            _carreras = new Carreras();
            _carrerasManejador = new CarrerasManejador();
            CargarGrupos();
            LlenarCombos();
        }
        private void CargarGrupos()
        {
            dgvGrupos.DataSource = _gruposManejador.ObtenerAlumnos();
        }

        private void Eliminar(int nControl)
        {
            _gruposManejador.Eliminar(nControl);
        }

        private void Guardar(Entidades.ControlEscolarApp.Grupos grupos)
        {
            _gruposManejador.Guardar(grupos);
        }

        private void LlenarCombos()
        {
            cmbCarrera.DataSource = _carrerasManejador.ObtenerAlumnos();
            cmbCarrera.DisplayMember = "nombre";
            cmbCarrera.ValueMember = "idCarrera";
        }
        private void SplitHeads(string str)
        {
            string[] stringList = str.Split(new[] { " - " }, StringSplitOptions.None);
            int recount = 0;
            foreach (string s in stringList)
            {
                if (recount == 0)
                {
                    txtcicloI.Text = s;
                    recount++;
                }
                else
                {
                    txtcicloF.Text = s;
                }
            }
        }
        private void TagGrupo()
        {
            _grupos.IdGrupo = Convert.ToInt32((dgvGrupos.CurrentRow.Cells["idGrupo"].Value).ToString());
            txtsemestre.Text = ((dgvGrupos.CurrentRow.Cells["semestre"].Value).ToString());
            SplitHeads(((dgvGrupos.CurrentRow.Cells["ciclo"].Value).ToString()));
            cmbCarrera.SelectedValue = Convert.ToInt32((dgvGrupos.CurrentRow.Cells["fkCarrera"].Value).ToString());
            GetSomething = _grupos.IdGrupo;
        }

        private void BindGrupo()
        {
            _grupos.Semestre = txtsemestre.Text;
            _grupos.Ciclo = (txtcicloI.Text + " - " + txtcicloF.Text);
            _grupos.FkCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
        }
        private void Grupos_Load(object sender, EventArgs e)
        {

        }

        private void dgvGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TagGrupo();
        }

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TagGrupo();
        }

        private void dgvGrupos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TagGrupo();
            BindGrupo();
            GruposModal gr = new GruposModal(_grupos);
            gr.ShowDialog();
            CargarGrupos();
        }

        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            BindGrupo();
            Guardar(_grupos);
            CargarGrupos();
        }
    }
}
