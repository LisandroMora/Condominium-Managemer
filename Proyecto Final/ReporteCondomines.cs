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
    public partial class ReporteCondomines : Form
    {
        ClassCondomines condomine = new ClassCondomines();
        public string filtro;
        public string consult;
        public ReporteCondomines()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.ReportSource = condomine.CrearReporte(filtro, consult);
            }
            catch (Exception E)
            {
                condomine.Error();
                MessageBox.Show(E.ToString());
            }
        }
    }
}
