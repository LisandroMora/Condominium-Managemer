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
    public partial class ConsultasPagos : Form
    {
        ClassPagos pago = new ClassPagos();
        public ConsultasPagos()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                pago.Consultas(Convert.ToString(dtDesde.Value), Convert.ToString(dtHasta.Value), TablaPagos);
            }
            catch (Exception exception)
            {
                pago.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                pago.Consultas(Convert.ToString(dtDesde.Value), Convert.ToString(dtHasta.Value), TablaPagos);
            }
            catch (Exception exception)
            {
                pago.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReportesPagos reportes = new ReportesPagos();
                reportes.desde = Convert.ToString(dtDesde.Value);
                reportes.hasta = Convert.ToString(dtHasta.Value);
                reportes.ShowDialog();
            }
            catch (Exception exception)
            {
                pago.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void ConsultasPagos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
