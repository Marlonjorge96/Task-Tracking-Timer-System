using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Task_Tracking_Timer_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ObtenerUsuario usuario = new ObtenerUsuario();

            var valida = usuario.login(users.Text, password.Text);

            if (valida == true)
            {
                //MessageBox.Show("Bienvenido sr"  + users.Text).ToString();
                users.Text = "";
                password.Text = "";
                FormPrincipal formPrin = new FormPrincipal();
                formPrin.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Datos incorrectos").ToString();
                users.Text = "";
                password.Text = "";
            }
        }

        private void recuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Actualizar actualizar = new Actualizar();
            actualizar.Show();
            this.Hide();
        }

        private void registro_Click(object sender, EventArgs e)
        {
            FormRegisttro formReg = new FormRegisttro();
            formReg.Show();
        }

        //private void users_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
