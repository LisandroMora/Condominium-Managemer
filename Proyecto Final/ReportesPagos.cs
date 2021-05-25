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
    public partial class ReportesPagos : Form
    {
        ClassPagos pago = new ClassPagos();
        public string desde;
        public string hasta;

        public ReportesPagos()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.ReportSource = pago.CrearReporte(desde, hasta);
            }
            catch (Exception E)
            {
                pago.Error();
                MessageBox.Show(E.ToString());
            }
        }
    }
}
