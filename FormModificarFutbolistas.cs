using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbol_CesarRaveloMartinez
{
    public partial class FormModificarFutbolistas : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormModificarFutbolistas(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormModificarFutbolistas_Load(object sender, EventArgs e)
        {
            tbDNINIE.Text = this.row.Cells[0].Value.ToString();
            tbNombre.Text = this.row.Cells[1].Value.ToString();
            tbNacionalidad.Text = this.row.Cells[2].Value.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {            
            string nombre = tbNombre.Text;
            string nacionalidad = tbNacionalidad.Text;

            if (validarNombre(nombre) && validarNacionalidad(nacionalidad))
            {
                dataSet.Tables[0].Rows[row.Index][1] = nombre;
                dataSet.Tables[0].Rows[row.Index][2] = nacionalidad;
                formMain.actualizarRegistros();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos introducidos no son válidos. Asegúrese de respetar los tamaños indicados.");
            }
        }

        private bool validarNombre(string nombre)
        {
            return nombre.Length > 0 && nombre.Length <= 50;
        }

        private bool validarNacionalidad(string nacionalidad)
        {
            return nacionalidad.Length > 0 && nacionalidad.Length <= 40;
        }
    }
}
