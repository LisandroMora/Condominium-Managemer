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
    public partial class Edificios : Form
    {
        ClassEdificios edificios = new ClassEdificios();
        public Edificios()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtEdficiosManzana.Text = "";
            txtEdicioID.Text = "";
            txtEdificioNombre.Clear();
            txtNumeroApartamentos.Clear();
            txtNumeroPisos.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edificios.ValidarTxt(this, errorProvider1);
            if (edificios.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                edificios.vacio = false;
            }
            else
            {
                try
                {
                    edificios.Asignar(txtEdificioNombre.Text, int.Parse(txtNumeroPisos.Text), int.Parse(txtNumeroApartamentos.Text), txtEdficiosManzana.Text);
                    edificios.Insertar();
                    edificios.LlenarDataGrid(EdificiosTabla);
                    edificios.CargarID(txtEdicioID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    edificios.Error();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edificios.ValidarTxt(this, errorProvider1);
            if (edificios.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                edificios.vacio = false;
            }
            else
            {
                try
                {
                    edificios.Asignar(txtEdificioNombre.Text, int.Parse(txtNumeroPisos.Text), int.Parse(txtNumeroApartamentos.Text), txtEdficiosManzana.Text);
                    edificios.Editar(txtEdicioID.Text);
                    edificios.LlenarDataGrid(EdificiosTabla);
                    edificios.CargarID(txtEdicioID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    edificios.Error();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edificios.ValidarTxt(this, errorProvider1);
            if (edificios.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                edificios.vacio = false;
            }
            else
            {
                try
                {
                    edificios.Borrar(txtEdicioID.Text);
                    edificios.LlenarDataGrid(EdificiosTabla);
                    edificios.CargarID(txtEdicioID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    edificios.Error();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Edificios_Load(object sender, EventArgs e)
        {
            try
            {
                edificios.LlenarDataGrid(EdificiosTabla);
                edificios.CargarID(txtEdicioID);
                edificios.CargarManzanas(txtEdficiosManzana);
            }
            catch (Exception exception)
            {
                edificios.Error();
                MessageBox.Show(exception.Message);
            }
        }

        private void txtEdicioID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                edificios.LlenarTxt(txtEdificioNombre, txtNumeroPisos, txtNumeroApartamentos, txtEdficiosManzana, txtEdicioID.Text);
            }
            catch (Exception exception)
            {
                edificios.Error();
                MessageBox.Show(exception.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void Edificios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
