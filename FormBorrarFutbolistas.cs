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
     * Clase gestora de la operación de borrado
     * mediante formulario para la tabla de
     * futbolistas.
     * 
    */
    public partial class FormBorrarFutbolistas : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormBorrarFutbolistas(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormBorrarFutbolistas_Load(object sender, EventArgs e)
        {
            lbcontentDNINIE.Text = this.row.Cells[0].Value.ToString();
            lbcontentNombre.Text = this.row.Cells[1].Value.ToString();
            lbcontentLocalidad.Text = this.row.Cells[2].Value.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            // Borramos del dataset la fila seleccionada actualmente
            dataSet.Tables[0].Rows[row.Index].Delete();
            formMain.actualizarRegistros();
            this.Close();
        }
    }
}
