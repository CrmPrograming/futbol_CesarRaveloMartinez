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
     * Clase gestora de la operación de insertar
     * los contratos mediante formulario.
     * 
    */
    public partial class FormInsertarContrato : Form
    {
        private DataSet dataSet;
        private FormMain formMain;

        public FormInsertarContrato(DataSet dataSet, FormMain formMain)
        {
            // El dataset pasado por parámetro debe tener la siguiente estructura:
            // [0] -> datos de contratos existentes
            // [1] -> datos de equipos existentes
            // [2] -> datos de futbolistas existentes

            this.dataSet = dataSet;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormInsertarContrato_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> equipoDictionary = new Dictionary<string, string>();
            Dictionary<string, string> futbolistaDictionary = new Dictionary<string, string>();

            // Inicializamos el combobox para los equipos
            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                equipoDictionary.Add(row[1].ToString(), row[0].ToString());
            }
            
            cbCodEquipo.DisplayMember = "Key";
            cbCodEquipo.ValueMember = "Value";
            cbCodEquipo.DataSource = new BindingSource(equipoDictionary, null);

            // Inicializamos el combobox para los futbolistas
            foreach (DataRow row in dataSet.Tables[2].Rows)
            {
                futbolistaDictionary.Add(row[1].ToString(), row[0].ToString());
            }

            cbDNINIE.DisplayMember = "Key";
            cbDNINIE.ValueMember = "Value";
            cbDNINIE.DataSource = new BindingSource(futbolistaDictionary, null);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            // Comprobamos que ambos combobox tengan valores
            if (combosSeleccionados() && fechasEscogidas())
            {
                string codDNINIE = cbDNINIE.SelectedValue.ToString();
                string codEquipo = cbCodEquipo.SelectedValue.ToString();
                DateTime fechaInicio = dtpInicio.Value;
                DateTime fechaFin = dtpFin.Value;
                int precioAnual = (int)nudPrecioAnual.Value;
                int precioRecision = (int)nudPrecioRecision.Value;

                // Insertamos el nuevo contrato en el dataset y luego hacemos
                // la petición de actualizar la bd
                dataSet.Tables[0].Rows.Add(null, codDNINIE, codEquipo, fechaInicio, fechaFin, precioAnual, precioRecision);
                formMain.actualizarRegistros();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor seleccione valores para todos los campos.");
            }
        }

        /*
         * Método encargado de comprobar que los
         * dos combobox fueran seleccionados.
         * 
        */
        private bool combosSeleccionados()
        {
            return (cbDNINIE.SelectedIndex > -1 && cbCodEquipo.SelectedIndex > -1);
        }

        /*
         * Método encargado de comprobar que los
         * dos DateTimePicker tengan valores asignados.
         * 
        */
        private bool fechasEscogidas()
        {
            return (dtpInicio.Text.Length > 0 && dtpFin.Text.Length > 0);
        }
    }
}
