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
    public partial class FormRegisttro : Form
    {
        public FormRegisttro()
        {
            InitializeComponent();
        }

        private void Registrase_Click(object sender, EventArgs e)
        {
            ObtenerUsuario sign = new ObtenerUsuario();

           bool valida = sign.SignIn(Name.Text,LastName.Text,Email.Text,Pass.Text);

            if (valida == true)
            {
                FormPrincipal formPrin = new FormPrincipal();
                formPrin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("the gmail you want to use already exists.").ToString();
                Name.Text = "";
                LastName.Text = "";
                Email.Text = "";
                Pass.Text = "";
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form1 close = new Form1();
            close.Show();
            this.Hide();
        }
    }
}
