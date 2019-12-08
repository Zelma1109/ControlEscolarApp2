using System;
using System.Windows.Forms;

namespace ControlEscolarApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void AlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosBusq frmalumnos = new AlumnosBusq();
            frmalumnos.ShowDialog();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaestrosBusq frmmaestros = new MaestrosBusq();
            frmmaestros.ShowDialog();
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escuela frmescuela = new Escuela();
            frmescuela.ShowDialog();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void escuelaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Escuela frmescuela = new Escuela();
            frmescuela.ShowDialog();
        }

        private void maestrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaestrosBusq frmmaestros = new MaestrosBusq();
            frmmaestros.ShowDialog();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlumnosBusq frmalumnos = new AlumnosBusq();
            frmalumnos.ShowDialog();
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGO LOG = new LOGO();
            LOG.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CarrerasBusq carrerasBusq = new CarrerasBusq();
            //carrerasBusq.ShowDialog();
        }

        private void respaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Respaldo rs = new Respaldo();
            rs.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos gp = new Grupos();
            gp.ShowDialog();
        }

        private void gruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void respaldoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Respaldo rs = new Respaldo();
            rs.ShowDialog();
        }


        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruposModal z = new GruposModal();
            z.ShowDialog();
        }

        private void altaCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarrerasBusq carrerasBusq = new CarrerasBusq();
            carrerasBusq.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarreasModal cm = new CarreasModal();
                cm.ShowDialog();
        }

        private void altaGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos gp = new Grupos();
            gp.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruposModal gm = new GruposModal();
            gm.ShowDialog();
        }
    }
}
