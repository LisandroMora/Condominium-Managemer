using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Proyecto_Final
{
    class ClassApartamentos : ModuloCRUD
    {
        public string Edificio { get; set; }
        public ClassApartamentos()
        {
            Command = "Select * from Apartamentos";
            CommandID = "Select IdApartamento from Apartamentos";
            Columna = "IdApartamento";
            Delete = "Delete Apartamentos where IdApartamento = @ID";
        }

        public override void Insertar()
        {
            connection.Open();
            string insert = $"Insert into Apartamentos (NumeroApartamento, NombreEdificio) values (@Nombre, @Edificio)";
            SqlCommand comando = new SqlCommand(insert, connection);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Edificio", Edificio);
            comando.ExecuteNonQuery();
            MessageBox.Show("Apartamento insertado en la base de datos");
            connection.Close();
        }

        public override void Editar(string id)
        {
            connection.Open();
            string editar = $"Update Apartamentos set NumeroApartamento = @Nombre, NombreEdificio = @Edificio where IdApartamento = {id}";
            SqlCommand comando = new SqlCommand(editar, connection);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Edificio", Edificio);
            comando.ExecuteNonQuery();
            MessageBox.Show("Apartamento modificado con exito");
            connection.Close();
        }

        public void LLenarTxt(MaskedTextBox TBNombreApt, ComboBox TBEdificio, string id)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand($"Select NumeroApartamento from Apartamentos where IdApartamento = {id}", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()) TBNombreApt.Text = (reader["NumeroApartamento"].ToString());
            reader.Close();
            SqlCommand comando2 = new SqlCommand($"Select NombreEdificio from Apartamentos where IdApartamento = {id}", connection);
            SqlDataReader reader2 = comando2.ExecuteReader();
            if (reader2.Read()) TBEdificio.Text = (reader2["NombreEdificio"].ToString());
            reader2.Close();
            connection.Close();
        }

        public override void CargarEdificios(ComboBox cb1, string manzana)
        {
            connection.Open();
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand comando = new SqlCommand($"Select NombreEdificio from Edificios", connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader["NombreEdificio"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void Asignar(string TNombre, string TEdificio)
        {
            this.Nombre = TNombre;
            this.Edificio = TEdificio;
        }
    }
}
