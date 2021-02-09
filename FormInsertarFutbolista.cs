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
    public partial class FormInsertarFutbolista : Form
    {
        private DataSet dataSet;
        private FormMain formMain;

        public FormInsertarFutbolista(DataSet dataSet, FormMain formMain)
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
            string codDNINIE = tbDNINIE.Text;
            string nombre = tbNombre.Text;
            string nacionalidad = tbNacionalidad.Text;

            if (validarDNINIE(codDNINIE) && validarNombre(nombre) && validarNacionalidad(nacionalidad))
            {
                dataSet.Tables[0].Rows.Add(codDNINIE, nombre, nacionalidad);
                formMain.actualizarRegistros();
                this.Close();
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

        private bool validarNombre(string nombre)
        {
            return nombre.Length > 0 && nombre.Length <= 50;
        }

        private bool validarNacionalidad(string nacionalidad)
        {
            return nacionalidad.Length > 0 && nacionalidad.Length <= 40;
        }
    }
}
