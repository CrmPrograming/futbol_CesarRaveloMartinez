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
     * Clase gestora del formulario contenedor de
     * todos los procedimientos almacenados y funciones.
     * 
     * Los botones tienen asignados eventos de entrada
     * y salida del cursor para actualizar la descripción
     * principal del formulario con una descripción
     * del procedimiento o función asociado al botón correspondiente.
     * 
     * Desde él se pueden acceder a cada uno de ellos
     * utilizando los botones presentes.
    */
    public partial class FormFuncionesProcedimientos : Form
    {
        public FormFuncionesProcedimientos()
        {
            InitializeComponent();
        }

        private void btListarContratos_MouseLeave(object sender, EventArgs e)
        {
            // Reinicializamos el mensaje por defecto cuando el cursor abandona el botón
            resetMensajeDescripcion();
        }

        private void btListarContratos_MouseEnter(object sender, EventArgs e)
        {
            cambiarMensajeDescripcion("Lista todos los contratos de un futbolista indicando su dni o nie.");
        }

        private void btInsertarEquipo_MouseLeave(object sender, EventArgs e)
        {
            // Reinicializamos el mensaje por defecto cuando el cursor abandona el botón
            resetMensajeDescripcion();
        }        
        
        private void btFutbolistasActivos_MouseLeave(object sender, EventArgs e)
        {
            // Reinicializamos el mensaje por defecto cuando el cursor abandona el botón
            resetMensajeDescripcion();
        }

        private void btMesesActivo_MouseLeave(object sender, EventArgs e)
        {
            // Reinicializamos el mensaje por defecto cuando el cursor abandona el botón
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

        /*
         * Método encargado de cambiar el label de descripción
         * con un mensaje informativo por defecto.
         * 
        */
        private void resetMensajeDescripcion()
        {
            cambiarMensajeDescripcion("Seleccione una de las funciones o procedimientos.");
        }

        /*
         * Método encargado de cambiar el label de descripción
         * con un mensaje especificado por parámetro.
         * 
        */
        private void cambiarMensajeDescripcion(string mensaje)
        {
            lbDescripcion.Text = mensaje;
        }

        private void btMesesActivo_MouseEnter(object sender, EventArgs e)
        {
            cambiarMensajeDescripcion("Dado el DNI o NIE de un futbolista, obtener el número total de meses que ha estado en activo.");
        }

        // Eventos asociados a cada botón para abrir el formulario correspondiente

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
