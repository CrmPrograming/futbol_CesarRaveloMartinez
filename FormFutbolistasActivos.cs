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
     * "futbolistasActivos". Se encarga de toda la operativa
     * respecto a la petición de datos y hacerle la
     * petición a la clase GestorConexion.
     * 
    */
    public partial class FormFutbolistasActivos : Form
    {
        public FormFutbolistasActivos()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            int codEquipo = (int)nudCodEquipo.Value;
            int precioAnual = (int)nudPrecioAnual.Value;
            int precioRecision = (int)nudPrecioRecision.Value;

            Tuple<int, int> result = GestorConexion.obtenerFutbolistasActivos(codEquipo, precioAnual, precioRecision);

            if (result.Item1 == -1) // No existe el equipo indicado
            {
                lbResultActivos.Text = "No existe el equipo indicado.";
                lbResultCriterio.Text = "No existe el equipo indicado.";
            }
            else
            {
                lbResultActivos.Text = result.Item1.ToString();
                lbResultCriterio.Text = result.Item2.ToString();
            }
        }
    }
}
