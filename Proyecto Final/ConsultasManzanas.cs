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
    public partial class ConsultasManzanas : Form
    {
        ClassManzanas manzanas = new ClassManzanas();
        public ConsultasManzanas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                manzanas.Consulta(txtManzanaConsultas.Text, TablaManzanas);
            }
            catch (Exception exception)
            {
                manzanas.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReportesManzanas reporte = new ReportesManzanas();
                reporte.Consulta = txtManzanaConsultas.Text;
                reporte.ShowDialog();
            }
            catch (Exception exception)
            {
                manzanas.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void ConsultasManzanas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
