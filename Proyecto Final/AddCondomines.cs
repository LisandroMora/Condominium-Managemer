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
    public partial class AddCondomines : Form
    {
        public AddCondomines()
        {
            InitializeComponent();
        }
        ClassCondomines objeto = new ClassCondomines();
        public void Limpiar()
        {
            txtCedulaCondominesAdd.Clear();
            txtNombreCondomineAdd.Clear();
            txtEmailCondomineAdd.Clear();
            txtTelefonoCondominesAdd.Clear();
            txtManzanaCondomineAdd.Text = "";
            txtEdificioCondomineAdd.Text = "";
            txtApartamentoCondomineAdd.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objeto.ValidarTxt(this, errorProvider1);
            if (objeto.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                objeto.vacio = false;
            }
            else
            {
                try
                {
                    objeto.Asignar(txtCedulaCondominesAdd.Text, txtNombreCondomineAdd.Text, txtEmailCondomineAdd.Text, txtTelefonoCondominesAdd.Text, txtManzanaCondomineAdd.Text, txtEdificioCondomineAdd.Text, txtApartamentoCondomineAdd.Text);
                    objeto.Insertar();
                    objeto.CargarApartamentos(txtApartamentoCondomineAdd, txtEdificioCondomineAdd.Text);
                    objeto.CargarEdificios(txtEdificioCondomineAdd, txtManzanaCondomineAdd.Text);
                    objeto.CargarManzanas(txtManzanaCondomineAdd);
                    Limpiar();
                }
                catch (Exception ex)
                {
                    objeto.Error();
                    MessageBox.Show(ex.Message, "Verifique llenar todos los campos");
                }
            }           
        }
        
        private void AddCondomines_Load(object sender, EventArgs e)
        {
            try
            {
                objeto.CargarApartamentos(txtApartamentoCondomineAdd, txtEdificioCondomineAdd.Text);
                objeto.CargarEdificios(txtEdificioCondomineAdd, txtManzanaCondomineAdd.Text);
                objeto.CargarManzanas(txtManzanaCondomineAdd);
                objeto.CargarManzanas(txtManzanaCondomineAdd);
            }
            catch (Exception exception)
            {
                objeto.Error();
                MessageBox.Show(exception.Message, "Error al conectarse con la base de datos");
            }
        }

        private void txtManzanaCondomineAdd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEdificioCondomineAdd.Enabled = true;
                objeto.CargarApartamentos(txtApartamentoCondomineAdd, txtEdificioCondomineAdd.Text);
                objeto.CargarEdificios(txtEdificioCondomineAdd, txtManzanaCondomineAdd.Text);
            }
            catch (Exception exception)
            {
                objeto.Error();
                MessageBox.Show(exception.Message, "Ocurrio un error al cargar los edificios y apartamentos");
            }
        }

        private void txtEdificioCondomineAdd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtApartamentoCondomineAdd.Enabled = true;
                objeto.CargarApartamentos(txtApartamentoCondomineAdd, txtEdificioCondomineAdd.Text);
            }
            catch (Exception exception)
            {
                objeto.Error();
                MessageBox.Show(exception.Message, "Error al cargar los apartamentos");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.Show();
        }

        private void AddCondomines_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
