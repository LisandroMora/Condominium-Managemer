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
    public partial class Pagos : Form
    {
       
        public Pagos()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtMesPagos.Text = "";
            txtCedulaPagos.Text = "";
            txtMesPagos.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pago = Inicio.Polimorfismo();
            pago = new ClassPagos();
            pago.ValidarTxt(this, errorProvider1);
            if(pago.vacio == true)
            {
                MessageBox.Show("Debe llenar todos los campos");
                pago.vacio = false;
            }
            else
            {
                try
                {
                    pago.Asignar(txtCedulaPagos.Text, txtFechaPagos.Value, txtMesPagos.Text);
                    pago.Insertar();
                    Limpiar();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            try
            {
                txtMesPagos.DropDownStyle = ComboBoxStyle.DropDownList;
                var pago = Inicio.Polimorfismo();
                pago = new ClassPagos();
                pago.LLenarCedula(txtCedulaPagos);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void txtCedulaPagos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var pago = Inicio.Polimorfismo();
                pago = new ClassPagos();
                pago.LLenarTxt(txtNombrePagos, txtEmailPagos, txtTelefonoPagos, txtCedulaPagos.Text);
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

        private void Pagos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
