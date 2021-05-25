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
    class ClassReclamaciones : ModuloProcesos, IReportes
    {
        public ClassReclamaciones()
        {
            Tabla = "Reclamaciones"; 
            CommandInsertar = "Insert into Reclamaciones (Fecha, Cedula, Reclamacion) values (@Fecha, @Cedula, @Proceso)";
        }

        public override void ValidarTxt(Form form, ErrorProvider error)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text) || control is ComboBox && string.IsNullOrEmpty(control.Text) || control is MaskedTextBox && string.IsNullOrEmpty(control.Text.Trim()))
                {
                    error.SetError(control, "Campo Obligatorio");
                    this.vacio = true;
                }
            }
        }
        public void Consulta(string consulta, DataGridView tabla)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand("Select Reclamacion, Condomines.Cedula, Condomines.Nombre, " +
                "Condomines.CorreoElectronico as Email, Condomines.Telefono, Condomines.NombreEdificio, Condomines.NumeroApartamento, Fecha from Reclamaciones " +
                $"inner join Condomines on Reclamaciones.Cedula = Condomines.Cedula where Condomines.NombreEdificio = '{consulta}'",connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable data = new DataTable();
            adapter.Fill(data);
            tabla.DataSource = data;
            connection.Close();
        }
        public void CargarEdificios(ComboBox cb1)
        {
            connection.Open();
            cb1.Items.Clear();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand comando = new SqlCommand("Select NombreEdificio from Edificios", connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader["NombreEdificio"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        public object CrearReporte(string Filtro, string Consulta)
        {
            ReportReclamaciones reporte = new ReportReclamaciones();
            reporte.SetParameterValue("@Filtro", Filtro);
            reporte.SetParameterValue("@Consulta", Consulta);
            return reporte;
        }
    }
}
