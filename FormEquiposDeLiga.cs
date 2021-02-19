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
     * Clase gestora de mostrar un combobox
     * de ligas el cual al cambiar de item,
     * actualiza el datagrid para mostrar
     * los equipos pertenecientes a dicha liga.
    */
    public partial class FormEquiposDeLiga : Form
    {

        public FormEquiposDeLiga()
        {
            InitializeComponent();
        }

        private void FormEquiposDeLiga_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> ligaDictionary = GestorConexion.obtenerListadoLigas();

            cbLiga.DisplayMember = "Key";
            cbLiga.ValueMember = "Value";
            cbLiga.DataSource = new BindingSource(ligaDictionary, null);

            cbLiga.SelectedIndex = 0;

            // Inicializamos el datagrid con los equipos propios de la primera liga
            dataGridViewContenido.DataSource = GestorConexion.obtenerEquipos((string)cbLiga.SelectedValue);
            dataGridViewContenido.Columns[0].HeaderText = "Código de Equipo";
            dataGridViewContenido.Columns[0].ReadOnly = true;
            dataGridViewContenido.Columns[1].HeaderText = "Nombre del Equipo";
            dataGridViewContenido.Columns[2].HeaderText = "Código de Liga";
            dataGridViewContenido.Columns[3].HeaderText = "Localidad";
            dataGridViewContenido.Columns[4].HeaderText = "¿Es internacional?";
        }

        private void cbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Buscamos los equipos asociados a la liga actualmente seleccionada
            dataGridViewContenido.DataSource = GestorConexion.obtenerEquipos((string)cbLiga.SelectedValue);
        }
    }
}
