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

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("categoria", "Categoría");
            dataGridView1.Columns.Add("precio", "Precio");
            dataGridView1.Columns.Add("estado", "Estado");

            dataGridView1.Rows.Add("1", "Leche", "Lácteos", "25", "ACTIVO");
            dataGridView1.Rows.Add("2", "Pollo", "Carnes", "80", "ACTIVO");
            dataGridView1.Rows.Add("3", "Res", "Carnes", "120", "ACTIVO");
            dataGridView1.Rows.Add("4", "Escoba", "Limpieza", "45", "ACTIVO");
            dataGridView1.Rows.Add("5", "Lampazo", "Limpieza", "60", "ACTIVO");
            dataGridView1.Rows.Add("6", "Jugo Naranja", "Bebidas", "35", "ACTIVO");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form2 ventanaNuevo = new Form2();
            ventanaNuevo.ShowDialog();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



