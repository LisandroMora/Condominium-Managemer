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
    public class ClassCondomines : ModuloCRUD, IReportes
    {
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Manzana { get; set; }
        public string Edificio { get; set; }
        public string Apartamento { get; set; }
        
        public ClassCondomines()
        {
            Command = "Select * from Condomines";
            CommandID = "Select IdCondomine from Condomines";
            Columna = "IdCondomine";
            Delete = "Delete Condomines where IdCondomine = @ID";
        }

        public override void Insertar()
        {
            connection.Open();
            string insert = "Insert into Condomines (Cedula, Nombre, CorreoElectronico, Telefono, NombreManzana, NombreEdificio, NumeroApartamento) values " +
                    $"(@Cedula, @Nombre, @Email, @Telefono, @Manzana, @Edificio, @Apartamento)";
            SqlCommand comando = new SqlCommand(insert, connection);
            comando.Parameters.AddWithValue("@Cedula", Cedula);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Manzana", Manzana);
            comando.Parameters.AddWithValue("@Edificio", Edificio);
            comando.Parameters.AddWithValue("@Apartamento", Apartamento);
            comando.ExecuteNonQuery();
            MessageBox.Show("Condomine insertado en la base de datos");
            connection.Close();
        }

        public override void Editar(string id)
        {
            string editar = $"Update Condomines set Cedula = @Cedula, Nombre = @Nombre, CorreoElectronico = @Email, " +
                $"Telefono = @Telefono, NombreManzana = @Manzana, NombreEdificio = @Edificio, NumeroApartamento = @Apartamento " +
                $"where IdCondomine = @ID";
            connection.Open();
            SqlCommand comando = new SqlCommand(editar, connection);
            comando.Parameters.AddWithValue("@Cedula", Cedula);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Manzana", Manzana);
            comando.Parameters.AddWithValue("@Edificio", Edificio);
            comando.Parameters.AddWithValue("@Apartamento", Apartamento);
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            MessageBox.Show("Condomine editado con exito");
            connection.Close();
        }

        public void LlenarTxt(MaskedTextBox TBCedula, TextBox TBNombre, TextBox TBEmail, MaskedTextBox TBTelefono, string id)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand($"Select Cedula from Condomines where IdCondomine = {id}", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()) TBCedula.Text = (reader["Cedula"].ToString());
            reader.Close();

            SqlCommand comando2 = new SqlCommand($"Select Nombre from Condomines where IdCondomine = {id}", connection);
            SqlDataReader reader2 = comando2.ExecuteReader();
            if (reader2.Read()) TBNombre.Text = (reader2["Nombre"].ToString());
            reader2.Close();

            SqlCommand comando3 = new SqlCommand($"Select CorreoElectronico from Condomines where IdCondomine = {id}", connection);
            SqlDataReader reader3 = comando3.ExecuteReader();
            if (reader3.Read()) TBEmail.Text = (reader3["CorreoElectronico"].ToString());
            reader3.Close();

            SqlCommand comando4 = new SqlCommand($"Select Telefono from Condomines where IdCondomine = {id}", connection);
            SqlDataReader reader4 = comando4.ExecuteReader();
            if (reader4.Read()) TBTelefono.Text = (reader4["Telefono"].ToString());
            reader4.Close();
            connection.Close();            
        }

        public void Consulta(string filtro, string consulta, DataGridView tabla)
        {
            if (filtro == "Correo Electronico") filtro = "CorreoElectronico";
            else if (filtro == "Edificio") filtro = "NombreEdificio";
            connection.Open();
            SqlCommand comando = new SqlCommand($"Select Cedula, Nombre, CorreoElectronico as 'Email', NumeroApartamento as 'Apartamento', " +
                $"NombreEdificio as 'Edificio', NombreManzana as 'Manzana' from Condomines where {filtro} Like '{consulta}%'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable data = new DataTable();
            adapter.Fill(data);
            tabla.DataSource = data;
            connection.Close();
        }

        public object CrearReporte(string filtro, string consulta)
        {
            if (filtro == "Correo Electronico") filtro = "CorreoElectronico";
            else if (filtro == "Edificio") filtro = "NombreEdificio";
            ReportCondomines reporte = new ReportCondomines();
            reporte.SetParameterValue("@Filtro", filtro);
            reporte.SetParameterValue("@Consulta", consulta);
            return reporte;      
        }

        public void Asignar(string TCedula, string TNombre, string TEmail, string TTelefono, string TManzana, string TEdificio, string TApartamento)
        {
            this.Cedula = TCedula;
            this.Nombre = TNombre;
            this.Email = TEmail;
            this.Telefono = TTelefono;
            this.Manzana = TManzana;
            this.Edificio = TEdificio;
            this.Apartamento = TApartamento;
        }
    }
}
