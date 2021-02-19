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
     * equipos.
     * 
    */
    public partial class FormBorrarEquipos : Form
    {
        private DataSet dataSet;
        private DataGridViewRow row;
        private FormMain formMain;

        public FormBorrarEquipos(DataSet dataSet, DataGridViewRow dataGridViewRow, FormMain formMain)
        {
            this.dataSet = dataSet;
            this.row = dataGridViewRow;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormBorrarEquipos_Load(object sender, EventArgs e)
        {
            // Inicializamos los componentes visuales del formulario
            lbcontentcodEquipo.Text = this.row.Cells[0].Value.ToString();
            lbcontentnomequipo.Text = this.row.Cells[1].Value.ToString();
            lbcontentcodliga.Text = this.row.Cells[2].Value.ToString();
            lbcontentLocalidad.Text = this.row.Cells[3].Value.ToString();
            cbInternacional.Checked = (bool)this.row.Cells[4].Value;
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
