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
    public partial class Reclamaciones : Form
    {
        public Reclamaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reclamaciones = Inicio.Polimorfismo();
            reclamaciones = new ClassReclamaciones();
            reclamaciones.ValidarTxt(this, errorProvider1);
            if (reclamaciones.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                reclamaciones.vacio = false;
            }
            else
            {
                try
                {
                    reclamaciones.Asignar(txtCedulaReclamacion.Text, txtFechaReclamacion.Value, txtReclamacion.Text);
                    reclamaciones.Insertar();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void Reclamaciones_Load(object sender, EventArgs e)
        {
            try
            {
                var reclamaciones = Inicio.Polimorfismo();
                reclamaciones = new ClassPagos();
                reclamaciones.LLenarCedula(txtCedulaReclamacion);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void txtCedulaReclamacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var reclamaciones = Inicio.Polimorfismo();
                reclamaciones = new ClassPagos();
                reclamaciones.LLenarTxt(txtNombreReclamaciones, txtEmailReclamaciones, txtTelefonoReclamaciones, txtCedulaReclamacion.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void Reclamaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
