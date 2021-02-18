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
    public partial class FormRelaciones : Form
    {
        public FormRelaciones()
        {
            InitializeComponent();
        }

        public void actualizarDataGrid(string codLiga, string nomLiga, DataView dataView)
        {
            lbResultCodLiga.Text = codLiga;
            lbResultNomLiga.Text = nomLiga;
            dataGridViewChildContent.DataSource = dataView;
        }
    }
}
