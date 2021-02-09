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
    public partial class FormBorrarContratos : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormBorrarContratos(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormBorrarContratos_Load(object sender, EventArgs e)
        {
            lbcontentcodContrato.Text = this.row.Cells[0].Value.ToString();
            lbcontentDNINIE.Text = this.row.Cells[1].Value.ToString();
            lbcontentcodEquipo.Text = this.row.Cells[2].Value.ToString();

            // Necesitamos la fecha sólo en formato día/mes/año sin las horas minutos y segundos
            lbcontentfechaInicio.Text = ((DateTime)this.row.Cells[3].Value).ToShortDateString();
            lbcontentFechaFin.Text = ((DateTime)this.row.Cells[4].Value).ToShortDateString();

            lbcontentPrecioAnual.Text = this.row.Cells[5].Value.ToString();
            lbcontentprecioRecision.Text = this.row.Cells[6].Value.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            dataSet.Tables[0].Rows[row.Index].Delete();
            formMain.actualizarRegistros();
            this.Close();
        }
    }
}
