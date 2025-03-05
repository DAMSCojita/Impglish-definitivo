using ProyectoAprenderIngles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wirframe
{
    public partial class FormMenu : System.Windows.Forms.Form
    {

        private int clickX, clickY;
        public FormMenu()
        {
            InitializeComponent();
            panelMenuTopButtons.MouseMove += pictureBox1_MouseMove;
            this.StartPosition = FormStartPosition.CenterScreen; // Esto hace que la ventana principal quede en el centro de la pantalla al ejecutar el programa

        }

        // Mensaje de advertencia que sale si pulsas el boton de cerrar (por si quieres salir del programa)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Esto hace que la ventana principal de la aplicación se pueda maximizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Esto hace que la ventana principal de la aplicación se pueda minimizar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void buttonWriting_Click(object sender, EventArgs e)
        {
            // Writing Quiz
            FormWriting writting = new FormWriting();
            AbrirFormhijo(writting);
        }

        private void buttonVocabulary_Click(object sender, EventArgs e)
        {
            // Vocabulary Quiz
            FormVocabulary vocabulary = new FormVocabulary();
            AbrirFormhijo(vocabulary);
        }

        private void buttonGrammar_Click(object sender, EventArgs e)
        {
            // Grammar Quiz
            FormGrammar grammar = new FormGrammar();
            AbrirFormhijo(grammar);
        }

        private void buttonListening_Click(object sender, EventArgs e)
        { 
            // Listening Quiz
            FormListening listening = new FormListening();
            AbrirFormhijo(listening);
        }

        private void buttonReading_Click(object sender, EventArgs e)
        {
            // Reading Quiz
            FormReading reading = new FormReading();
            AbrirFormhijo(reading);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                clickX = e.X;
                clickY = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - clickX);
                this.Top = this.Top + (e.Y - clickY);
            }
        }
        private void AbrirFormhijo(object formhijo)
        {
            if (this.panelFormulary.Controls.Count > 0)
                this.panelFormulary.Controls.RemoveAt(0);
            System.Windows.Forms.Form fh = formhijo as System.Windows.Forms.Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelFormulary.Controls.Add(fh);
            this.panelFormulary.Tag = fh;
            fh.Show();
        }

    }
}
