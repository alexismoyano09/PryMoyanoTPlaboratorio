using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMoyanoTPlaboratorio
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void lbldatetime_Click(object sender, EventArgs e)
        {

        }

        private void lbldatetime_Click_1(object sender, EventArgs e)
        {
           
        }
        
        private void Frmmain_Load(object sender, EventArgs e)
        {
            empleados objEstado = new empleados();

            lbldatetime.Text = Convert.ToString(DateTime.Now);
            lblestado.Text = objEstado.estadoConexion; 
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmusuario Ventana = new Frmusuario();
            Ventana.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlistado Ventana = new Frmlistado();
            Ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
