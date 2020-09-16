using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracking_Timer_System
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDataSet.tareas' table. You can move, or remove it, as needed.
            this.tareasTableAdapter.Fill(this.sistemaDataSet.tareas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {
            
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.Show();
            this.Hide();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1) {
                var id= int.Parse(dataGridView1.CurrentRow.Cells["idtarea"].Value.ToString());
                ObtenerUsuario Eliminar = new ObtenerUsuario();
                var eliminar = Eliminar.Eliminar(id);
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Hide();
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataTable ta = new DataTable();
            dataGridView1.DataSource = ta;
            string s1 = busca.Text;
            string s2 = busca.Text;
            bool b = s1.Contains(s2);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                {
                    ObtenerUsuario buscar = new ObtenerUsuario();
                    var eliminar = buscar.Buscar(busca.Text = busca.Text, index);
                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();
                    dataGridView1.Refresh();
                    this.Hide();
                }
            }         
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Form1 salir = new Form1();
            salir.Show();
            this.Hide();
        }
    }
}
