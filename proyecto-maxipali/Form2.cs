using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proyecto_maxipali
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string estado = checkBox1.Checked ? "ACTIVO" : "INACTIVO";
            MessageBox.Show("¡Producto actualizado!\nEstado: " + estado, "MaxiPali");
            this.Close();
        }

        private void lblPrecioCompra_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }

