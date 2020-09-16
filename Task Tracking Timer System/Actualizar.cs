using System;
using System.Windows.Forms;

namespace Task_Tracking_Timer_System
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textpass1.Text == textpass.Text)
            {
                ObtenerUsuario modificar = new ObtenerUsuario();
                modificar.UpdateUser(textnombre.Text, textpass.Text);
                MessageBox.Show("updated password");
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Passwords do not match");
            }          
            
        }
    }
}
