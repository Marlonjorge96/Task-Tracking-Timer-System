using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracking_Timer_System
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (tarea.Text != null && codtarea.Text != null)
            {
                ObtenerUsuario usuario = new ObtenerUsuario();

                var mensaje = usuario.Insertar(tarea.Text, codtarea.Text);
                MessageBox.Show(mensaje);
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("uno de los campos esta vacio por favor revice...");
            }
        }
    }
}
