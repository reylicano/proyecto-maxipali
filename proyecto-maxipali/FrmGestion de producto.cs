using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_maxipali
{
    public partial class FrmGestion_de_producto : Form
    {
        public FrmGestion_de_producto()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("producto maxi pali seleccionado");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form1 ventanaNuevo = new Form1();
            ventanaNuevo.ShowDialog();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}







