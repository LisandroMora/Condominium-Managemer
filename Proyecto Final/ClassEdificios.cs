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
    class ClassEdificios : ModuloCRUD, IReportes
    {
        public int CantidadPisos { get; set; }
        public int CantidadApart { get; set; }
        public string Manzana { get; set; }
        public ClassEdificios()
        {
            Command = "Select * from Edificios";
            CommandID = "Select IdEdificio from Edificios";
            Columna = "IdEdificio";
            Delete = "Delete Edificios where IdEdificio = @ID";
        }

        public override void Insertar()
        {
            connection.Open();
            string insert = "Insert into Edificios (NombreEdificio, CantidadPisos, CantidadApart, NombreManzana) " +
                "values (@Nombre, @Pisos, @Apartamentos, @Manzana)";
            SqlCommand comando = new SqlCommand(insert, connection);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Pisos", CantidadPisos);
            comando.Parameters.AddWithValue("@Apartamentos", CantidadApart);
            comando.Parameters.AddWithValue("@Manzana", Manzana);
            comando.ExecuteNonQuery();
            MessageBox.Show("Edificio insertado en la base de datos");
            connection.Close();
        }

        public override void Editar(string id)
        {
            connection.Open();
            string editar = $"Update Edificios set NombreEdificio = @Nombre, CantidadPisos = @Pisos, CantidadApart = @Apartamentos, " +
                $"NombreManzana = @Manzanas where IdEdificio = @ID";
            SqlCommand comando = new SqlCommand(editar, connection);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Pisos", CantidadPisos);
            comando.Parameters.AddWithValue("@Apartamentos", CantidadPisos);
            comando.Parameters.AddWithValue("@Manzanas", Manzana);
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            MessageBox.Show("Edificio modificado con exito");
            connection.Close();
        }

        public void LlenarTxt(TextBox TBNombreE, MaskedTextBox TBNumeroPisos, MaskedTextBox TBCapartamentos, ComboBox TBManzana, string id)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand($"Select NombreEdificio from Edificios where IdEdificio = {id}", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()) TBNombreE.Text = (reader["NombreEdificio"].ToString());
            reader.Close();
            SqlCommand comando2 = new SqlCommand($"Select CantidadPisos from Edificios where IdEdificio = {id}", connection);
            SqlDataReader reader2 = comando2.ExecuteReader();
            if (reader2.Read()) TBNumeroPisos.Text = (reader2["CantidadPisos"].ToString());
            reader2.Close();
            SqlCommand comando3 = new SqlCommand($"Select CantidadApart from Edificios where IdEdificio = {id}", connection);
            SqlDataReader reader3 = comando3.ExecuteReader();
            if (reader3.Read()) TBCapartamentos.Text = (reader3["CantidadApart"].ToString());
            reader3.Close();
            SqlCommand comando4 = new SqlCommand($"Select NombreManzana from Edificios where IdEdificio = {id}", connection);
            SqlDataReader reader4 = comando4.ExecuteReader();
            if (reader4.Read()) TBManzana.Text = (reader4["NombreManzana"].ToString());
            reader4.Close();
            connection.Close();
        }

        public void Consulta(string filtro, string consulta, DataGridView tabla)
        {
            if (filtro == "Nombre") filtro = "NombreEdificio";
            else if (filtro == "Manzana") filtro = "NombreManzana";
            else if (filtro == "Cantidad de aptos") filtro = "CantidadApart";
            connection.Open();
            SqlCommand comando = new SqlCommand("select NombreEdificio as 'Nombre', CantidadPisos 'Numero de Pisos', " +
                $"CantidadApart as 'Numero de Apartamentos', NombreManzana as 'Manzana' from Edificios where {filtro} like '{consulta}%'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable data = new DataTable();
            adapter.Fill(data);
            tabla.DataSource = data;
            connection.Close();
        }

        public object CrearReporte(string filtro, string consulta)
        {
            if (filtro == "Nombre") filtro = "NombreEdificio";
            else if (filtro == "Manzana") filtro = "NombreManzana";
            else if (filtro == "Cantidad de aptos") filtro = "CantidadApart";
            ReportEdificios reporte = new ReportEdificios();
            reporte.SetParameterValue("@Filtro", filtro);
            reporte.SetParameterValue("@Consulta", consulta);
            return reporte;
        }


        public void Asignar(string TNombre, int Pisos, int Apartamentos, string TManzana)
        {
            this.Nombre = TNombre;
            this.CantidadPisos = Pisos;
            this.CantidadApart = Apartamentos;
            this.Manzana = TManzana;
        }
    }
}
