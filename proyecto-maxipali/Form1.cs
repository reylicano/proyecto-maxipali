using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            // Configuración del tema (Estilo Maxi Palí: Verde y Naranja)
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800, Primary.Green900, Primary.Green500,
                Accent.Orange400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        // Abre la ventana de recuperación al hacer clic en el link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperacion formRec = new FormRecuperacion();
            formRec.ShowDialog();
        }

        // Lógica del botón de Ingresar (Haz doble clic en tu botón de diseño para que se cree este evento y pega lo de adentro)
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Asegúrate de cambiar los nombres si tus TextBox se llaman diferente
            string usuario = txtUsuario.Text;

            if (usuario == "admin") // Ejemplo básico de validación
            {
                MessageBox.Show("¡Bienvenido al sistema MaxiPali!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }
    }
}