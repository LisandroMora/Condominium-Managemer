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
    public partial class Condomines : Form
    {
        public Condomines()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCondomines addcondomines = new AddCondomines();
            this.Hide();
            addcondomines.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ModCondomine mod = new ModCondomine();
            this.Hide();
            mod.ShowDialog();
        }
    }
}
