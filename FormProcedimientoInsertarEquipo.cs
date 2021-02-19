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
     * Clase gestora del procedimiento almacenado de
     * "insertarEquipo". Se encarga de toda la operativa
     * respecto a la petición de datos y hacerle la
     * petición a la clase GestorConexion.
     * 
    */
    public partial class FormProcedimientoInsertarEquipo : Form
    {
        public FormProcedimientoInsertarEquipo()
        {
            InitializeComponent();
        }

        private void FormProcedimientoInsertarEquipo_Load(object sender, EventArgs e)
        {
            cbLiga.DisplayMember = "Key";
            cbLiga.ValueMember = "Value";
            cbLiga.DataSource = new BindingSource(GestorConexion.obtenerListadoLigas(), null);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            // Comprobamos que se ha seleccionado una liga
            if (cbLiga.SelectedIndex > -1)
            {
                string codLiga = cbLiga.SelectedValue.ToString();
                string nomEquipo = tbNombre.Text;
                string localidad = tbLocalidad.Text;
                bool internacional = checkBInternacional.Checked;

                if (validarNomEquipo(nomEquipo) && validarLocalidad(localidad))
                {
                    Tuple<bool, bool> results = GestorConexion.insertarEquipo(codLiga, nomEquipo, localidad, internacional);
                    if (!results.Item1) // Liga no existe
                    {
                        MessageBox.Show("La liga indicada no existe.");
                    }
                    else if (results.Item1 && !results.Item2) // El equipo ya existía antes de la inserción
                    {
                        MessageBox.Show("El equipo ya existía previamente antes de la inserción.");
                    }
                    else if (results.Item1 && results.Item2) // Éxito en la inserción
                    {
                        MessageBox.Show("Nuevo equipo creado con éxito.");
                        this.Close();
                    }
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
