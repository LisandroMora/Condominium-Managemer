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
    public partial class ModCondomine : Form
    {
        ClassCondomines objeto = new ClassCondomines();
        public ModCondomine()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtCedulaCondominesMod.Clear();
            txtNombreCondominesMod.Clear();
            txtEmailCondominesMod.Clear();
            txtTelefonoCondominesMod.Clear();
            txtManzanaCondominesMod.Text = "";
            txtEdificioCondominesMod.Text = "";
            txtApartamentoCondominesMod.Text = "";
            txtCondomineIdMod.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
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
                    objeto.Asignar(txtCedulaCondominesMod.Text, txtNombreCondominesMod.Text, txtEmailCondominesMod.Text, txtTelefonoCondominesMod.Text, txtManzanaCondominesMod.Text, txtEdificioCondominesMod.Text, txtApartamentoCondominesMod.Text);
                    objeto.Editar(txtCondomineIdMod.Text);
                    objeto.LlenarDataGrid(TablaCondominesMod);
                    objeto.CargarID(txtCondomineIdMod);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    objeto.Error();
                    MessageBox.Show(exception.Message, "Debe llenar todos los campos");
                }
            }
        }

        private void ModCondomine_Load(object sender, EventArgs e)
        {
            try
            {
                objeto.LlenarDataGrid(TablaCondominesMod);
                objeto.CargarID(txtCondomineIdMod);
                objeto.CargarManzanas(txtManzanaCondominesMod);
                objeto.CargarEdificios(txtEdificioCondominesMod, txtManzanaCondominesMod.Text);
                objeto.CargarApartamentos(txtApartamentoCondominesMod, txtEdificioCondominesMod.Text);
            }
            catch (Exception exception)
            {
                objeto.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                    objeto.Borrar(txtCondomineIdMod.Text);
                    objeto.LlenarDataGrid(TablaCondominesMod);
                    objeto.CargarID(txtCondomineIdMod);
                    Limpiar();
                }
                catch (Exception exception)
                {
                    objeto.Error();
                    MessageBox.Show(exception.Message, "Debe llenar todos los campos");
                }
            }
        }

        private void txtCondomineIdMod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objeto.LlenarTxt(txtCedulaCondominesMod, txtNombreCondominesMod, txtEmailCondominesMod, txtTelefonoCondominesMod, txtCondomineIdMod.Text);
            }
            catch (Exception exception)
            {
                objeto.Error();
                MessageBox.Show(exception.Message, "Error a cargar los ID");
            }
        }

        private void txtManzanaCondominesMod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                objeto.CargarEdificios(txtEdificioCondominesMod, txtManzanaCondominesMod.Text);
            }
            catch (Exception exception)
            {
                objeto.Error();
                MessageBox.Show(exception.ToString());
            }
        }

        private void txtEdificioCondominesMod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                objeto.CargarApartamentos(txtApartamentoCondominesMod, txtEdificioCondominesMod.Text);
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

        private void ModCondomine_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
