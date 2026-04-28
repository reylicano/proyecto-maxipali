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
    public partial class FormRecuperacion : MaterialForm // Se cambió Form por MaterialForm
    {
        public FormRecuperacion()
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

        private void FormRecuperacion_Load(object sender, EventArgs e)
        {

        }

        // Lógica para el botón ENVIAR (Haz doble clic en tu botón de diseño y pega esto adentro)
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si el correo existe, te enviaremos las instrucciones.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cierra esta ventana y vuelve al login
        }

        // Lógica para el botón VOLVER (Haz doble clic en tu botón de diseño y pega esto adentro)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra esta ventana y vuelve al login sin hacer nada
        }
    }
}