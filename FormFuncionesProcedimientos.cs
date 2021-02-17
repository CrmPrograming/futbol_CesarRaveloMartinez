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
    public partial class FormFuncionesProcedimientos : Form
    {
        public FormFuncionesProcedimientos()
        {
            InitializeComponent();
        }

        private void btListarContratos_MouseLeave(object sender, EventArgs e)
        {
            resetMensajeDescripcion();
        }

        private void btListarContratos_MouseEnter(object sender, EventArgs e)
        {
            lbDescripcion.Text = "Lista todos los contratos de un futbolista indicando su dni o nie.";
        }

        private void btInsertarEquipo_MouseLeave(object sender, EventArgs e)
        {
            resetMensajeDescripcion();
        }

        private void resetMensajeDescripcion()
        {
            lbDescripcion.Text = "Seleccione una de las funciones o procedimientos.";
        }

        private void cambiarMensajeDescripcion(string mensaje)
        {
            lbDescripcion.Text = mensaje;
        }

        private void btFutbolistasActivos_MouseLeave(object sender, EventArgs e)
        {
            resetMensajeDescripcion();
        }

        private void btMesesActivo_MouseLeave(object sender, EventArgs e)
        {
            resetMensajeDescripcion();
        }

        private void btInsertarEquipo_MouseEnter(object sender, EventArgs e)
        {
            cambiarMensajeDescripcion("Inserte un equipo indicando sus valores.");
        }

        private void btFutbolistasActivos_MouseEnter(object sender, EventArgs e)
        {
            cambiarMensajeDescripcion(
                "Obtener la cantidad de futbolistas en activo (con contrato vigente)"
                + " que hay en un equipo dado, junto con la cantidad de futbolistas en activo de dicho equipo"
                + " con precio anual y de recisión menor de los indicados."
            );
        }

        private void btMesesActivo_MouseEnter(object sender, EventArgs e)
        {
            cambiarMensajeDescripcion("Dado el DNI o NIE de un futbolista, obtener el número total de meses que ha estado en activo.");
        }

        private void btListarContratos_Click(object sender, EventArgs e)
        {
            new FormListarContratos().ShowDialog();
        }

        private void btInsertarEquipo_Click(object sender, EventArgs e)
        {
            new FormProcedimientoInsertarEquipo().ShowDialog();
        }

        private void btFutbolistasActivos_Click(object sender, EventArgs e)
        {
            new FormFutbolistasActivos().ShowDialog();
        }

        private void btMesesActivo_Click(object sender, EventArgs e)
        {
            new FormTotalMeses().ShowDialog();
        }
    }
}
