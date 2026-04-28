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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void numStock_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string desc = txtDescripcion.Text;
            decimal precioVenta = numPrecioVenta.Value;
            decimal stock = numStock.Value;
            string unidad = cmbUnidadMedida.Text;
            string cat = boxCategoria.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(" escribir el nombre del producto");
                return;
            }

      MessageBox.Show("¡Listo! ingresar el producto " + nombre + "\nCategoría: " + cat + "\nUnidad: " + unidad + "\nStock: " + stock, "bodega maxi pali");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria ventana = new FrmCategoria();
            ventana.ShowDialog();
           
        }
    }
}
