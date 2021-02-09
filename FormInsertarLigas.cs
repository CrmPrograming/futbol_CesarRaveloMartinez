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
    public partial class FormInsertarLigas : Form
    {

        private DataSet dataSet;
        private FormMain formMain;

        public FormInsertarLigas(DataSet dataSet, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            string codLiga = tbCodLiga.Text;
            string nomLiga = tbNomLiga.Text;

            if (validarCodLiga(codLiga) && validarNomLiga(nomLiga))
            {
                dataSet.Tables[0].Rows.Add(codLiga, nomLiga);
                formMain.actualizarRegistros();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos introducidos no son válidos. Asegúrese de respetar los tamaños indicados.");
            }
        }

        private bool validarCodLiga(string codLiga)
        {
            return codLiga.Length == 5;
        }

        private bool validarNomLiga(string nomLiga)
        {
            return nomLiga.Length <= 50 && nomLiga.Length > 0;
        }

    }
}
