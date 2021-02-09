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
    public partial class FormInsertarEquipo : Form
    {
        private DataSet dataSet;
        private FormMain formMain;

        public FormInsertarEquipo(DataSet dataSet, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormInsertarEquipo_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> ligaDictionary = new Dictionary<string, string>();

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                ligaDictionary.Add(row[1].ToString(), row[0].ToString());
            }

            cbLiga.DisplayMember = "Key";
            cbLiga.ValueMember = "Value";
            cbLiga.DataSource = new BindingSource(ligaDictionary, null);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            if (cbLiga.SelectedIndex > -1)
            {
                string codLiga = cbLiga.SelectedValue.ToString();
                string nomEquipo = tbNombre.Text;
                string localidad = tbLocalidad.Text;
                bool internacional = checkBInternacional.Checked;

                if (validarNomEquipo(nomEquipo) && validarLocalidad(localidad))
                {
                    dataSet.Tables[0].Rows.Add(null, nomEquipo, codLiga, localidad, internacional);
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
