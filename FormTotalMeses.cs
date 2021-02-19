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
     * "fnTotalMeses". Se encarga de toda la operativa
     * respecto a la petición de datos y hacerle la
     * petición a la clase GestorConexion.
     * 
    */
    public partial class FormTotalMeses : Form
    {
        public FormTotalMeses()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            string dnionie = tbDNINIE.Text;

            if (validarDNINIE(dnionie))
            { 
                int total = GestorConexion.obtenerTotalMeses(dnionie);
                lbResult.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Los campos introducidos no son válidos. Asegúrese de respetar los tamaños indicados.");
            }
        }

        private bool validarDNINIE(string cod)
        {
            return cod.Length == 9;
        }
    }
}
