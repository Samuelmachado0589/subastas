using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace subastas.pro
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            double telefono = Convert.ToDouble(txtTelefono.Text);
            double Documneto = Convert.ToDouble(txtDocumentos.Text);
            clsResgistros Registro = new clsResgistros();
            dgvRegistros.Rows.Add(nombre, apellido, Documneto, telefono, email);
            MessageBox.Show( Registro.GuardarDatos(nombre, apellido, Documneto, telefono, email));


            //  Registros.Add($"Nombre:{Registro.Nombre},Apellido:{Registro.Apellido}, Documento:{Registro.Documento},Telefono:{Registro.Telefono},Email:{Registro.Email}.");

           


        }


        public List<string> ObtenerDatosdgv()
        {
            List<string> datos = new List<string>();

            foreach (DataGridViewRow row in dgvRegistros.Rows)
            {
                if (!row.IsNewRow)
                { // Agregar llaves para definir el bloque del condicional
                    string nombre = row.Cells["Column1"].Value?.ToString() ?? string.Empty;
                    string apellido = row.Cells["Column2"].Value?.ToString() ?? string.Empty;
                    string documento = row.Cells["Column3"].Value?.ToString() ?? string.Empty;
                    string telefono = row.Cells["Column4"].Value?.ToString() ?? string.Empty;
                    string email = row.Cells["Column5"].Value?.ToString() ?? string.Empty;

                    string filaFormateada = $"{nombre}, {apellido}, {telefono}, {email}, {documento}";
                    datos.Add(filaFormateada);
                }
            }

            return datos; // Mover esta línea dentro del alcance del método
        }

    }
}
