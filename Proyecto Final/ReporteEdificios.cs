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
    public partial class ReporteEdificios : Form
    {
        public ReporteEdificios()
        {
            InitializeComponent();
        }
        ClassEdificios edificio = new ClassEdificios();
        public string filtro;
        public string consult;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.ReportSource = edificio.CrearReporte(filtro, consult);
            }
            catch (Exception E)
            {
                edificio.Error();
                MessageBox.Show(E.ToString());
            }
        }
    }
}
