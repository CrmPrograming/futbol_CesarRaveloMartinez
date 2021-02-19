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
     * Clase gestora de la vista encargada de mostrar
     * los equipos pertenecientes a la liga seleccionada
     * en el formulario principal.
     * 
    */
    public partial class FormRelaciones : Form
    {
        public FormRelaciones()
        {
            InitializeComponent();
        }

        /*
         * Método encargado de actualizar tanto los label con el código
         * de liga y nombre de la liga, como el DataGrid con los datos
         * de los equipos a mostrar.
         * 
        */
        public void actualizarDataGrid(string codLiga, string nomLiga, DataView dataView)
        {
            lbResultCodLiga.Text = codLiga;
            lbResultNomLiga.Text = nomLiga;
            dataGridViewChildContent.DataSource = dataView;
        }
    }
}
