using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class ConsultasCondomines : Form
    {
        ClassCondomines condomines = new ClassCondomines();
        public ConsultasCondomines()
        {
            InitializeComponent();
            txtFiltroCond.DropDownStyle = ComboBoxStyle.DropDownList;
            if (txtFiltroCond.Text == "") txtConsultaCond.Enabled = false;
            lblConsulta.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                condomines.Consulta(txtFiltroCond.Text, txtConsultaCond.Text, TablaConsultasCond);
            }
            catch (Exception exception)
            {
                condomines.Error();
                MessageBox.Show(exception.Message, "Verifique los campos");
            }
        }

        private void txtFiltroCond_TextChanged(object sender, EventArgs e)
        {
            txtConsultaCond.Enabled = true;
            lblConsulta.Text = txtFiltroCond.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteCondomines reporte = new ReporteCondomines();
                reporte.filtro = txtFiltroCond.Text;
                reporte.consult = txtConsultaCond.Text;
                reporte.ShowDialog();
            }
            catch (Exception exception)
            {
                condomines.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void ConsultasCondomines_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
