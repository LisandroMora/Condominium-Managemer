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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultasCondomines Ccondomines = new ConsultasCondomines();
            Hide();
            Ccondomines.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultasManzanas CManzanas = new ConsultasManzanas();
            Hide();
            CManzanas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultasEdificios CEdificios = new ConsultasEdificios();
            Hide();
            CEdificios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultasPagos CPagos = new ConsultasPagos();
            Hide();
            CPagos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultasReclamaciones CReclamaciones = new ConsultasReclamaciones();
            Hide();
            CReclamaciones.ShowDialog();
        }
    }
}
