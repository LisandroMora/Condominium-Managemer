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
    class ClassManzanas : ModuloCRUD, IReportes
    {
        public ClassManzanas()
        {
            Command = "Select * from Manzanas";
            CommandID = "Select IdManzana from Manzanas";
            Columna = "IdManzana";
            Delete = "Delete Manzanas where IdManzana = @ID";
        }

        public override void Insertar()
        {
            connection.Open();
            string insert = $"Insert into Manzanas (NombreManzana) values (@Nombre)";
            SqlCommand comando = new SqlCommand(insert, connection);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.ExecuteNonQuery();
            MessageBox.Show("Manzana insertada en la base de datos");
            connection.Close();
        }

        public override void Editar(string id)
        {
            connection.Open();
            string editar = $"Update Manzanas set NombreManzana = @Nombre where IdManzana = {id}";
            SqlCommand comando = new SqlCommand(editar, connection);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.ExecuteNonQuery();
            MessageBox.Show("Manzana modificada con exito");
            connection.Close();
        }

        public void LlenarTxt(MaskedTextBox TBManzana, string id)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand($"Select NombreManzana from Manzanas where IdManzana = {id}", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()) TBManzana.Text = (reader["NombreManzana"].ToString());
            reader.Close();
            connection.Close();
        }

        public void Consulta(string consulta, DataGridView tabla)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand($"select * from Manzanas where NombreManzana Like '{consulta}%'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable data = new DataTable();
            adapter.Fill(data);
            tabla.DataSource = data;
            connection.Close();
        }

        public object CrearReporte(string Filtro, string Consulta)
        {
            ReportManzanas reporte = new ReportManzanas();
            reporte.SetParameterValue("@Filtro", Filtro);
            reporte.SetParameterValue("@Consulta", Consulta);
            return reporte;
        }

        public void Asignar(string TNombre)
        {
            this.Nombre = TNombre;            
        }
    }
}
