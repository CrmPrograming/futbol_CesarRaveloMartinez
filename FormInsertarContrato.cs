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
    public partial class FormInsertarContrato : Form
    {
        private DataSet dataSet;
        private FormMain formMain;

        public FormInsertarContrato(DataSet dataSet, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormInsertarContrato_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> equipoDictionary = new Dictionary<string, string>();
            Dictionary<string, string> futbolistaDictionary = new Dictionary<string, string>();

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                equipoDictionary.Add(row[1].ToString(), row[0].ToString());
            }
            
            cbCodEquipo.DisplayMember = "Key";
            cbCodEquipo.ValueMember = "Value";
            cbCodEquipo.DataSource = new BindingSource(equipoDictionary, null);

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
            if (cbDNINIE.SelectedIndex > -1 && cbCodEquipo.SelectedIndex > -1)
            {
                string codDNINIE = cbDNINIE.SelectedValue.ToString();
                string codEquipo = cbCodEquipo.SelectedValue.ToString();
                DateTime fechaInicio = dtpInicio.Value;
                DateTime fechaFin = dtpFin.Value;
                int precioAnual = (int)nudPrecioAnual.Value;
                int precioRecision = (int)nudPrecioRecision.Value;

                dataSet.Tables[0].Rows.Add(null, codDNINIE, codEquipo, fechaInicio, fechaFin, precioAnual, precioRecision);
                formMain.actualizarRegistros();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe obligatoriamente escoger el jugador y el equipo.");
            }
        }
    }
}
