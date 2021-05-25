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
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
        }

        public static ModuloProcesos Polimorfismo()
        {
            ModuloProcesos procesos = null;
            return procesos;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Condomines condomines = new Condomines();
            Hide();
            condomines.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manzanas manzanas = new Manzanas();
            Hide();
            manzanas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edificios edificios = new Edificios();
            Hide();
            edificios.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apartamento apartamento = new Apartamento();
            Hide();
            apartamento.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos();
            Hide();
            pagos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            Hide();
            consultas.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reclamaciones reclamaciones = new Reclamaciones();
            Hide();
            reclamaciones.ShowDialog();
        }
    }
}
