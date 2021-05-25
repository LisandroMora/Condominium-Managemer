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
    public partial class ReportesReclamaciones : Form
    {
        ClassReclamaciones reclamacion = new ClassReclamaciones();
        public string Consulta;
        public ReportesReclamaciones()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.ReportSource = reclamacion.CrearReporte("NombreEdificio", Consulta);
            }
            catch (Exception E)
            {
                reclamacion.Error();
                MessageBox.Show(E.ToString());
            }
        }
    }
}
