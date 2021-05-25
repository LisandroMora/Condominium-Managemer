using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Proyecto_Final
{
    public abstract class ModuloProcesos
    {
        public string Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public string Proceso { get; set; }
        protected string CommandInsertar { get; set; }
        protected string Tabla { get; set; }
        public bool vacio { get; set; }

        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public void Error()
        {
            connection.Close();
        }
        public virtual void ValidarTxt(Form form, ErrorProvider error)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text) || control is MaskedTextBox && string.IsNullOrEmpty(control.Text.Trim()))
                {
                    error.SetError(control, "Campo Obligatorio");
                    this.vacio = true;
                }
            }
        }
        public void Asignar(string TCedula, DateTime TFecha, string TProceso)
        {
            this.Cedula = TCedula;
            this.Fecha = TFecha;
            this.Proceso = TProceso;
        }

        public void Insertar()
        {
            connection.Open();
            SqlCommand comando = new SqlCommand(this.CommandInsertar, connection);
            comando.Parameters.AddWithValue("@Cedula", this.Cedula);
            comando.Parameters.AddWithValue("@Fecha", this.Fecha);
            comando.Parameters.AddWithValue("@Proceso", this.Proceso);
            comando.ExecuteNonQuery();
            MessageBox.Show("PROCESO REALIZADO CON EXITO");
            connection.Close();
        }

        public void LLenarCedula(ComboBox cb1)
        {
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            connection.Open();
            SqlCommand comando = new SqlCommand("Select Cedula from Condomines", connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader["Cedula"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        public void LLenarTxt(TextBox text1, TextBox text2, TextBox text3, string txt)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand($"Select Nombre from Condomines where Condomines.Cedula = '{txt}'", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()) text1.Text = (reader["Nombre"].ToString());
            reader.Close();
            SqlCommand comando2 = new SqlCommand($"Select CorreoElectronico from Condomines where Condomines.Cedula = '{txt}'", connection);
            SqlDataReader reader2 = comando2.ExecuteReader();
            if (reader2.Read()) text2.Text = (reader2["CorreoElectronico"].ToString());
            reader2.Close();
            SqlCommand comando3 = new SqlCommand($"Select Telefono from Condomines where Condomines.Cedula = '{txt}'", connection);
            SqlDataReader reader3 = comando3.ExecuteReader();
            if (reader3.Read()) text3.Text = (reader3["Telefono"].ToString());
            reader3.Close();
            connection.Close();
        }
    }
}
