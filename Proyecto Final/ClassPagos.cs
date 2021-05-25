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
    class ClassPagos : ModuloProcesos, IReportes
    {
        public ClassPagos()
        {
            Tabla = "Pagos";
            CommandInsertar = "Insert into Pagos (Fecha, Cedula, MesAPagar) values (@Fecha, @Cedula, @Proceso)";
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


        public void Consultas(string desde, string hasta, DataGridView tabla)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand("select IdPago as Pago, Condomines.Cedula, Condomines.Nombre, Condomines.CorreoElectronico as Email, " +
                "Condomines.Telefono, Fecha, MesAPagar as 'Mes Pagado' from Pagos " +
                $"inner join Condomines on Condomines.Cedula = Pagos.Cedula WHERE Fecha between '{desde}' and '{hasta}'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable data = new DataTable();
            adapter.Fill(data);
            tabla.DataSource = data;
            connection.Close();
        }

        public object CrearReporte(string desde, string hasta)
        {
            ReportPagos reporte = new ReportPagos();
            reporte.SetParameterValue("@desde", desde);
            reporte.SetParameterValue("@hasta", hasta);
            return reporte;
        }
    }
}
