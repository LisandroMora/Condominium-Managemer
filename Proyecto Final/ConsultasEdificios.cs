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
    public partial class ConsultasEdificios : Form
    {
        ClassEdificios edificios = new ClassEdificios();
        public ConsultasEdificios()
        {
            InitializeComponent();
        }

        private void txtFiltroEdificios_TextChanged(object sender, EventArgs e)
        {
            txtConsultaEdificios.Enabled = true;
            lblConsultasEdificios.Text = txtFiltroEdificios.Text;
        }

        private void txtConsultaEdificios_TextChanged(object sender, EventArgs e)
        {
            try
            {
                edificios.Consulta(txtFiltroEdificios.Text, txtConsultaEdificios.Text, TablaEdificios);
            }
            catch (Exception exception)
            {
                edificios.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void ConsultasEdificios_Load(object sender, EventArgs e)
        {
            try
            {
                edificios.LlenarDataGrid(TablaEdificios);
                txtFiltroEdificios.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception exception)
            {
                edificios.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteEdificios reporte = new ReporteEdificios();
                reporte.filtro = txtFiltroEdificios.Text;
                reporte.consult = txtConsultaEdificios.Text;
                reporte.ShowDialog();
            }
            catch (Exception exception)
            {
                edificios.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void ConsultasEdificios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
