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
     * Clase principal de la aplicación.
     * Se encarga del formulario principal
     * desde el cual el usuario puede realizar
     * las distintas operaciones disponibles.
     * 
     * Además de ello, hace de intermediaria entre todos
     * los demás formularios y la clase GestorConexion.
     * 
     * Todas las operaciones que afecten a la base de datos,
     * tienen que ser solicitadas aquí ya que esta clase
     * se comunicará con la clase GestorConexion.
     * 
    */
    public partial class FormMain : Form
    {
        private GestorConexion.TABLAS tablaSeleccionada = 0;
        private DataSet dataSet = null;
        private FormFuncionesProcedimientos formFuncionesProcedimientos = null;
        private FormRelaciones formRelaciones = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tablaSeleccionada = GestorConexion.TABLAS.LIGAS;
            // Añadimos el nombre de las tablas
            cbTabla.Items.Add("ligas");
            cbTabla.Items.Add("equipos");
            cbTabla.Items.Add("fubtbolistas");
            cbTabla.Items.Add("contratos");
            cbTabla.SelectedIndex = 0; // Inicializamos el comboBox con la tabla Ligas

            // Inicializamos el dataSet con los datos de las ligas
            dataSet = GestorConexion.poblarDataSet(GestorConexion.TABLAS.LIGAS);
            dataGridViewContenido.DataSource = dataSet.Tables[0];
            actualizarEstructuraGridView();
            actualizarTotalRegistros();
        }

        private void cbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            construirDataGrid();
        }

        /*
         * Método encargado de montar el DataGridView con los datos
         * de la tabla actualmente seleccionada en el ComboBox.
        */
        private void construirDataGrid()
        {
            tablaSeleccionada = 0;
            dataSet = null;
            // Necesitamos quitar las columnas extras que añadimos, de lo contrario
            // las columnas de combobox añadidas perdurarán.
            dataGridViewContenido.Columns.Clear();

            // Establecemos la tabla seleccionada.
            switch (cbTabla.SelectedIndex)
            {
                case 0:
                    tablaSeleccionada = GestorConexion.TABLAS.LIGAS;
                    break;
                case 1:
                    tablaSeleccionada = GestorConexion.TABLAS.EQUIPOS;
                    break;
                case 2:
                    tablaSeleccionada = GestorConexion.TABLAS.FUTBOLISTAS;
                    break;
                case 3:
                    tablaSeleccionada = GestorConexion.TABLAS.CONTRATOS;
                    break;
            }

            // Poblamos el dataSet y el dataGridView para la tabla indicada
            dataSet = GestorConexion.poblarDataSet(tablaSeleccionada);
            dataGridViewContenido.DataSource = dataSet.Tables[0];
            // Ajustamos la estructura del DataGridView y sus columnas
            actualizarEstructuraGridView();
            // Ajustamos el contador de total de registros
            lbTotalRegistros.Text = dataSet.Tables[0].Rows.Count.ToString();
        }

        /*
         * Método encargado de actualizar la estructura del DataGridView en base
         * a la tabla actualmente seleccionada.
         * 
         * Cambia el texto de las cabeceras y allí donde sea necesario,
         * añade una ComboBoxColumn.
        */
        private void actualizarEstructuraGridView()
        {
            switch (tablaSeleccionada)
            {
                case GestorConexion.TABLAS.LIGAS:
                    dataGridViewContenido.Columns[0].HeaderText = "Código de Liga";
                    dataGridViewContenido.Columns[1].HeaderText = "Nombre de Liga";

                    break;
                case GestorConexion.TABLAS.EQUIPOS:
                    dataGridViewContenido.Columns[0].HeaderText = "Código de Equipo";
                    dataGridViewContenido.Columns[0].ReadOnly = true;
                    dataGridViewContenido.Columns[1].HeaderText = "Nombre del Equipo";
                    dataGridViewContenido.Columns[2].HeaderText = "Código de Liga";
                    dataGridViewContenido.Columns[3].HeaderText = "Localidad";
                    dataGridViewContenido.Columns[4].HeaderText = "¿Es internacional?";

                    // Creamos ComboBox para los códigos de liga                    
                    DataGridViewComboBoxColumn cmbLigas = new DataGridViewComboBoxColumn();
                    cmbLigas.HeaderText = "Ligas";
                    cmbLigas.DataPropertyName = "codLiga";
                    cmbLigas.DisplayMember = "nomLiga";
                    cmbLigas.ValueMember = "codLiga";
                    cmbLigas.DataSource = dataSet.Tables[1];
                    dataGridViewContenido.Columns.Add(cmbLigas);

                    // Deshabilitamos los campos relacionados con otras tablas
                    // para que sólo se puedan modificar con el combobox correspondiente
                    dataGridViewContenido.Columns[2].ReadOnly = true;
                    break;
                case GestorConexion.TABLAS.FUTBOLISTAS:
                    dataGridViewContenido.Columns[0].HeaderText = "DNI o NIE";
                    dataGridViewContenido.Columns[1].HeaderText = "Nombre del Futbolista";
                    dataGridViewContenido.Columns[2].HeaderText = "Nacionalidad";
                    break;
                case GestorConexion.TABLAS.CONTRATOS:
                    dataGridViewContenido.Columns[0].HeaderText = "Código de Contrato";
                    dataGridViewContenido.Columns[0].ReadOnly = true;
                    dataGridViewContenido.Columns[1].HeaderText = "DNI o NIE";
                    dataGridViewContenido.Columns[2].HeaderText = "Código de Equipo";
                    dataGridViewContenido.Columns[3].HeaderText = "Fecha de Inicio";
                    dataGridViewContenido.Columns[4].HeaderText = "Fecha de Finalización";
                    dataGridViewContenido.Columns[5].HeaderText = "Precio Anual";
                    dataGridViewContenido.Columns[6].HeaderText = "Precio de Recisión";

                    // Deshabilitamos los campos relacionados con otras tablas
                    // para que sólo se puedan modificar con el combobox correspondiente
                    dataGridViewContenido.Columns[1].ReadOnly = true;
                    dataGridViewContenido.Columns[2].ReadOnly = true;

                    // Creamos ComboBox para los códigos de equipos
                    DataGridViewComboBoxColumn cmbEquipos = new DataGridViewComboBoxColumn();
                    cmbEquipos.HeaderText = "Equipos";
                    cmbEquipos.DataPropertyName = "codEquipo";
                    cmbEquipos.DisplayMember = "nomEquipo";
                    cmbEquipos.ValueMember = "codEquipo";
                    cmbEquipos.DataSource = dataSet.Tables[1];
                    dataGridViewContenido.Columns.Add(cmbEquipos);

                    // Creamos ComboBox para los dni o nie de fubtbolistas
                    DataGridViewComboBoxColumn cmbFutbolistas = new DataGridViewComboBoxColumn();
                    cmbFutbolistas.HeaderText = "Futbolistas";
                    cmbFutbolistas.DataPropertyName = "coddnionie";
                    cmbFutbolistas.DisplayMember = "nombre";
                    cmbFutbolistas.ValueMember = "coddnionie";
                    cmbFutbolistas.DataSource = dataSet.Tables[2];
                    dataGridViewContenido.Columns.Add(cmbFutbolistas);
                    break;
            }
        }

        /*
         * Método encargado de actualizar el Label con el total de registros
         * contenidos en la tabla actualmente mostrada.
         * 
        */
        private void actualizarTotalRegistros()
        {
            lbTotalRegistros.Text = dataSet.Tables[0].Rows.Count.ToString();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarRegistros();
            MessageBox.Show("Los registros han sido actualizados.");
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            // Según la tabla seleccionada, muestra el formulario
            // de inserción asociado a ella.
            switch (tablaSeleccionada)
            {
                case GestorConexion.TABLAS.LIGAS:
                    new FormInsertarLigas(dataSet, this).ShowDialog();
                    break;
                case GestorConexion.TABLAS.EQUIPOS:
                    new FormInsertarEquipo(dataSet, this).ShowDialog();
                    break;
                case GestorConexion.TABLAS.FUTBOLISTAS:
                    new FormInsertarFutbolista(dataSet, this).ShowDialog();
                    break;
                case GestorConexion.TABLAS.CONTRATOS:
                    new FormInsertarContrato(dataSet, this).ShowDialog();
                    break;
            }
        }

        /*
         * Método encargado de actualizar los registros de la
         * tabla actualmente mostrada en el DataGridView comunicándose
         * con la clase GestorConexion mediante el método actualizarTabla;
         * si hay nuevos registros, modificados o borrados, mandará el dataSet
         * actualizado para sincronizar con la base de datos.
         * 
         * Además de ello, actualiza el label con el total de registros para
         * mantener concordancia de acuerdo al nuevo total de registros.
         * 
         * Si la operación ha fallado, sea por un trigger o un dato no válido,
         * se reconstruye el DataGridView a como estaba antes de realizar la operación.
         * 
        */
        public void actualizarRegistros()
        {
            if (GestorConexion.actualizarTabla(dataSet))
            {
                actualizarTotalRegistros();
                MessageBox.Show("Operación realizada con éxito.");
            }
            else
                construirDataGrid();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            // Comprobamos antes de borrar un registro si realmente hay un único registro seleccionado
            // y que éste no sea la fila de insertar nuevos registros.
            if (dataGridViewContenido.SelectedRows.Count == 1 && dataGridViewContenido.SelectedRows[0].Index != dataGridViewContenido.NewRowIndex)
            {
                switch (tablaSeleccionada)
                {
                    case GestorConexion.TABLAS.LIGAS:
                        new FormBorrarLigas(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                    case GestorConexion.TABLAS.EQUIPOS:
                        new FormBorrarEquipos(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                    case GestorConexion.TABLAS.FUTBOLISTAS:
                        new FormBorrarFutbolistas(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                    case GestorConexion.TABLAS.CONTRATOS:
                        new FormBorrarContratos(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila entera para poder borrar el registro.");
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            // Comprobamos antes de modificar un registro si realmente hay un único registro seleccionado
            // y que éste no sea la fila de insertar nuevos registros.
            if (dataGridViewContenido.SelectedRows.Count == 1 && dataGridViewContenido.SelectedRows[0].Index != dataGridViewContenido.NewRowIndex)
            {
                switch (tablaSeleccionada)
                {
                    case GestorConexion.TABLAS.LIGAS:
                        new FormModificarLigas(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                    case GestorConexion.TABLAS.EQUIPOS:
                        new FormModificarEquipos(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                    case GestorConexion.TABLAS.FUTBOLISTAS:
                        new FormModificarFutbolistas(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                    case GestorConexion.TABLAS.CONTRATOS:
                        new FormModificarContratos(dataSet, dataGridViewContenido.SelectedRows[0], this).ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila entera para poder modificar el registro.");
            }
        }

        private void btProcedimientos_Click(object sender, EventArgs e)
        {
            if (formFuncionesProcedimientos != null)
                formFuncionesProcedimientos.Close();

            formFuncionesProcedimientos = new FormFuncionesProcedimientos();
            formFuncionesProcedimientos.Show();
        }

        private void btEquiposLiga_Click(object sender, EventArgs e)
        {
            new FormEquiposDeLiga().ShowDialog();
        }

        private void dataGridViewContenido_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Comprobamos que se dispare el evento de la nueva fila seleccionada sólo cuando:
            // - Hay una única fila seleccionada
            // - La fila seleccionada no es la de inserción de nuevos datos (NewRowIndex)
            if (dataGridViewContenido.SelectedRows.Count != 1 || dataGridViewContenido.SelectedRows[0].Index == dataGridViewContenido.NewRowIndex) return;

            if (tablaSeleccionada == GestorConexion.TABLAS.LIGAS)
            {
                if (formRelaciones == null || !formRelaciones.Visible)
                {
                    formRelaciones = new FormRelaciones();
                    formRelaciones.Show();
                }

                DataView tableView = new DataView();
                DataRowView currentRowView;

                tableView = new DataView(dataSet.Tables[0]);
                currentRowView = tableView[dataGridViewContenido.SelectedRows[0].Index];
                formRelaciones.actualizarDataGrid(
                    dataGridViewContenido.SelectedRows[0].Cells[0].Value.ToString(),
                    dataGridViewContenido.SelectedRows[0].Cells[1].Value.ToString(),
                    currentRowView.CreateChildView("EquipoLiga")
                );
            }
        }
    }
}
