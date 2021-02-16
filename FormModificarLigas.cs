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
    public partial class FormModificarLigas : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormModificarLigas(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormModificarLigas_Load(object sender, EventArgs e)
        {
            tbCodLiga.Text = this.row.Cells[0].Value.ToString();
            tbNomLiga.Text = this.row.Cells[1].Value.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            string nomLiga = tbNomLiga.Text;
            if (validarNomLiga(nomLiga))
            {
                dataSet.Tables[0].Rows[row.Index][1] = nomLiga;
                formMain.actualizarRegistros();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos introducidos no son válidos. Asegúrese de respetar los tamaños indicados.");
            }
        }

        private bool validarNomLiga(string nomLiga)
        {
            return nomLiga.Length <= 50 && nomLiga.Length > 0;
        }
    }
}
