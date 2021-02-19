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
    /*
     * Clase gestora de la operación de modificar
     * los equipos mediante formulario.
     * 
    */
    public partial class FormModificarEquipos : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormModificarEquipos(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormModificarEquipos_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> ligaDictionary = new Dictionary<string, string>();
            int i = 0;
            int pos = -1;
            string codLiga = this.row.Cells[2].Value.ToString();

            // Creamos y rellenamos el ComboBox de ligas
            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                ligaDictionary.Add(row[1].ToString(), row[0].ToString());
                // Con este if marcaremos luego la posición del
                // ComboBox en el item que coincida con el código de liga dado
                if (row[0].ToString().Equals(codLiga))
                {
                    pos = i;
                }
                else
                {
                    i++;
                }
            }         

            cbLiga.DisplayMember = "Key";
            cbLiga.ValueMember = "Value";
            cbLiga.DataSource = new BindingSource(ligaDictionary, null);

            cbLiga.SelectedIndex = pos;

            tbNombre.Text = this.row.Cells[1].Value.ToString();
            tbLocalidad.Text = this.row.Cells[3].Value.ToString();
            checkBInternacional.Checked = (bool) this.row.Cells[4].Value;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (cbLiga.SelectedIndex > -1)
            {
                string codLiga = cbLiga.SelectedValue.ToString();
                string nomEquipo = tbNombre.Text;
                string localidad = tbLocalidad.Text;
                bool internacional = checkBInternacional.Checked;

                if (validarNomEquipo(nomEquipo) && validarLocalidad(localidad))
                {
                    // Actualizamos los nuevos valores del equipo en la fila
                    // correspondiente del DataSet; row.Index es el índice
                    // de la fila seleccionada a modificar.
                    dataSet.Tables[0].Rows[row.Index][1] = nomEquipo;
                    dataSet.Tables[0].Rows[row.Index][2] = codLiga;
                    dataSet.Tables[0].Rows[row.Index][3] = localidad;
                    dataSet.Tables[0].Rows[row.Index][4] = internacional;
                    formMain.actualizarRegistros();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los campos introducidos no son válidos. Asegúrese de respetar los tamaños indicados.");
                }
            }
            else
            {
                MessageBox.Show("Debe obligatoriamente escoger el código de liga del equipo.");
            }
        }

        private bool validarNomEquipo(string nomEquipo)
        {
            return nomEquipo.Length > 0 && nomEquipo.Length <= 40;
        }

        private bool validarLocalidad(string localidad)
        {
            return localidad.Length > 0 && localidad.Length <= 60;
        }
    }
}
