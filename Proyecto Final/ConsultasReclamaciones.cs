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
    public partial class ConsultasReclamaciones : Form
    {
        ClassReclamaciones reclamacion = new ClassReclamaciones();
        public ConsultasReclamaciones()
        {
            InitializeComponent();
            txtReclamacionConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                reclamacion.CargarEdificios(txtReclamacionConsulta);
            }
            catch (Exception exception)
            {
                reclamacion.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                reclamacion.Consulta(txtReclamacionConsulta.Text, TablaReclamaciones);
            }
            catch (Exception exception)
            {
                reclamacion.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReportesReclamaciones reporte = new ReportesReclamaciones();
                reporte.Consulta = txtReclamacionConsulta.Text;
                reporte.ShowDialog();
            }
            catch (Exception exception)
            {
                reclamacion.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void ConsultasReclamaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
