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
    public partial class Apartamento : Form
    {
        ClassApartamentos apartamento = new ClassApartamentos();
        
        public void Limpiar()
        {
            txtNumeroApart.Clear();
            txtApartamentosID.Text = "";
            txtApartamentoEdif.Text = "";
        }
        public Apartamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apartamento.ValidarTxt(this, errorProvider1);
            if (apartamento.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                apartamento.vacio = false;
            }
            else
            {
                try
                {
                    apartamento.Asignar(txtNumeroApart.Text, txtApartamentoEdif.Text);
                    apartamento.Insertar();
                    apartamento.LlenarDataGrid(ApartamentosTabla);
                    apartamento.CargarID(txtApartamentosID);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    apartamento.Error();
                    MessageBox.Show(exception.Message, "Error al insertar el apartamento");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                apartamento.Asignar(txtNumeroApart.Text, txtApartamentoEdif.Text);
                apartamento.Editar(txtApartamentosID.Text);
                apartamento.LlenarDataGrid(ApartamentosTabla);
                apartamento.CargarID(txtApartamentosID);
                Limpiar();
            }
            catch (Exception exception)
            {
                apartamento.Error();
                MessageBox.Show(exception.Message, "Error al editar el apartamento");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                apartamento.Borrar(txtApartamentosID.Text);
                apartamento.LlenarDataGrid(ApartamentosTabla);
                apartamento.CargarID(txtApartamentosID);
                Limpiar();
            }
            catch (Exception exception)
            {
                apartamento.Error();
                MessageBox.Show(exception.Message, "Error al eliminar el apartamento");
            }
        }

        private void Apartamento_Load(object sender, EventArgs e)
        {
            try
            {
                apartamento.LlenarDataGrid(ApartamentosTabla);
                apartamento.CargarID(txtApartamentosID);
                apartamento.CargarEdificios(txtApartamentoEdif, "");
            }
            catch (Exception exception)
            {
                apartamento.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void txtApartamentosID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                apartamento.LLenarTxt(txtNumeroApart, txtApartamentoEdif, txtApartamentosID.Text);
            }
            catch (Exception exception)
            {
                apartamento.Error();
                MessageBox.Show(exception.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void Apartamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
