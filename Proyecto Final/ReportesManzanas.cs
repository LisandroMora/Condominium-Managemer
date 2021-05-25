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
    public partial class ReportesManzanas : Form
    {
        ClassManzanas manzanas = new ClassManzanas();
        public string Consulta;
        public string Filtro = "NombreManzana";

        public ReportesManzanas()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.ReportSource = manzanas.CrearReporte(Filtro, Consulta);
            }
            catch (Exception E)
            {
                manzanas.Error();
                MessageBox.Show(E.ToString());
            }
        }
    }
}
