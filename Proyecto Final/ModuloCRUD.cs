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
    public abstract class ModuloCRUD
    {
        public string Nombre { get; set; }
        protected string Command { get; set; }
        protected string CommandID { get; set; }
        protected string Columna { get; set; }
        protected string Delete { get; set; }
        public bool vacio { get; set; }

        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public void Error()
        {
            connection.Close();
        }
        public void ValidarTxt(Form form, ErrorProvider error)
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
        public void LlenarDataGrid(DataGridView tabla1)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand(this.Command, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tabla1.DataSource = table;
            connection.Close();
        }

        public void Borrar(string id)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand(this.Delete, connection);
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            MessageBox.Show("Elemento eliminado de la base de datos");
            connection.Close();
        }

        public virtual void CargarID(ComboBox cb1)
        {
            connection.Open();
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand comando = new SqlCommand(this.CommandID, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader[$"{this.Columna}"].ToString());
            }
            reader.Close();
            connection.Close();
        }
    

        public virtual void CargarManzanas(ComboBox cb1)
        {
            connection.Open();
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand comando = new SqlCommand("Select NombreManzana from Manzanas", connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader["NombreManzana"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        public virtual void CargarEdificios(ComboBox cb1, string manzana)
        {
            connection.Open();
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand comando = new SqlCommand($"Select NombreEdificio from Edificios where NombreManzana = '{manzana}'", connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader["NombreEdificio"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        public virtual void CargarApartamentos(ComboBox cb1, string edificio)
        {
            connection.Open();
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand comando = new SqlCommand($"Select NumeroApartamento from Apartamentos where NombreEdificio = '{edificio}'", connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader["NumeroApartamento"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        public abstract void Insertar();
        public abstract void Editar(string id);      
    }
}
