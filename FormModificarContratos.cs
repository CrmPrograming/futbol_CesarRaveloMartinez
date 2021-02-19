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
     * los contratos mediante formulario.
     * 
    */
    public partial class FormModificarContratos : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormModificarContratos(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormModificarContratos_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> equipoDictionary = new Dictionary<string, string>();
            Dictionary<string, string> futbolistaDictionary = new Dictionary<string, string>();
            string codEquipo = this.row.Cells[2].Value.ToString();
            string coddnionie = this.row.Cells[1].Value.ToString();
            int i = 0;
            int pos = -1;            

            // Creamos y rellenamos el ComboBox de equipos
            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                equipoDictionary.Add(row[1].ToString(), row[0].ToString());
                // Con este if marcaremos luego la posición del
                // ComboBox en el item que coincida con el código de equipo dado
                if (row[0].ToString().Equals(codEquipo))
                {
                    pos = i;
                }
                else
                {
                    i++;
                }
            }

            cbCodEquipo.DisplayMember = "Key";
            cbCodEquipo.ValueMember = "Value";
            cbCodEquipo.DataSource = new BindingSource(equipoDictionary, null);
            cbCodEquipo.SelectedIndex = pos;

            // Creamos y rellenamos el ComboBox de futbolistas
            i = 0;
            pos = -1;
            foreach (DataRow row in dataSet.Tables[2].Rows)
            {
                futbolistaDictionary.Add(row[1].ToString(), row[0].ToString());
                // Con este if marcaremos luego la posición del
                // ComboBox en el item que coincida con el código de dni o nie dado
                if (row[0].ToString().Equals(coddnionie))
                {
                    pos = i;
                }
                else
                {
                    i++;
                }
            }

            cbDNINIE.DisplayMember = "Key";
            cbDNINIE.ValueMember = "Value";
            cbDNINIE.DataSource = new BindingSource(futbolistaDictionary, null);

            cbDNINIE.SelectedIndex = pos;

            // Fijamos los valores de los DateTimePicker y los NumericUpDown con
            // los valores previos del contrato especificado
            dtpInicio.Text = this.row.Cells[3].Value.ToString();
            dtpFin.Text = this.row.Cells[4].Value.ToString();
            nudPrecioAnual.Text = this.row.Cells[5].Value.ToString();
            nudPrecioRecision.Text = this.row.Cells[6].Value.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (combosSeleccionados() && fechasEscogidas())
            {
                string codDNINIE = cbDNINIE.SelectedValue.ToString();
                string codEquipo = cbCodEquipo.SelectedValue.ToString();
                DateTime fechaInicio = dtpInicio.Value;
                DateTime fechaFin = dtpFin.Value;
                int precioAnual = (int)nudPrecioAnual.Value;
                int precioRecision = (int)nudPrecioRecision.Value;
                
                // Actualizamos los nuevos valores del contrato en la fila
                // correspondiente del DataSet; row.Index es el índice
                // de la fila seleccionada a modificar.
                dataSet.Tables[0].Rows[row.Index][1] = codDNINIE;
                dataSet.Tables[0].Rows[row.Index][2] = codEquipo;
                dataSet.Tables[0].Rows[row.Index][3] = fechaInicio;
                dataSet.Tables[0].Rows[row.Index][4] = fechaFin;
                dataSet.Tables[0].Rows[row.Index][5] = precioAnual;
                dataSet.Tables[0].Rows[row.Index][6] = precioRecision;
                formMain.actualizarRegistros();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe obligatoriamente escoger el jugador y el equipo.");
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
