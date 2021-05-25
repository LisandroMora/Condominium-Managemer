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
    public partial class Manzanas : Form
    {
        ClassManzanas manzanas = new ClassManzanas();
        public Manzanas()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtManzanaNombre.Clear();
            txtManzanasID.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            manzanas.ValidarTxt(this, errorProvider1);
            if (manzanas.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                manzanas.vacio = false;
            }
            else
            {
                try
                {
                    manzanas.Asignar(txtManzanaNombre.Text);
                    manzanas.Insertar();
                    manzanas.LlenarDataGrid(ManzanasTabla);
                    manzanas.CargarID(txtManzanasID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    manzanas.Error();
                    MessageBox.Show(exception.Message, "Ocurrio un error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manzanas.ValidarTxt(this, errorProvider1);
            if (manzanas.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                manzanas.vacio = false;
            }
            else
            {
                try
                {
                    manzanas.Asignar(txtManzanaNombre.Text);
                    manzanas.Editar(txtManzanasID.Text);
                    manzanas.LlenarDataGrid(ManzanasTabla);
                    manzanas.CargarID(txtManzanasID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    manzanas.Error();
                    MessageBox.Show(exception.Message, "Error al insertar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manzanas.ValidarTxt(this, errorProvider1);
            if (manzanas.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                manzanas.vacio = false;
            }
            else
            {
                try
                {
                    manzanas.Borrar(txtManzanasID.Text);
                    manzanas.LlenarDataGrid(ManzanasTabla);
                    manzanas.CargarID(txtManzanasID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    manzanas.Error();
                    MessageBox.Show(exception.Message, "Error al insertar");
                }
            }
        }

        private void Manzanas_Load(object sender, EventArgs e)
        {
            try
            {
                manzanas.LlenarDataGrid(ManzanasTabla);
                manzanas.CargarID(txtManzanasID);
            }
            catch (Exception exception)
            {
                manzanas.Error();
                MessageBox.Show(exception.Message);
            }
        }

        private void txtManzanasID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                manzanas.LlenarTxt(txtManzanaNombre, txtManzanasID.Text);
            }
            catch (Exception exception)
            {
                manzanas.Error();
                MessageBox.Show(exception.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void Manzanas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
