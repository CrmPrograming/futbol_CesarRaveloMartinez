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
    public partial class FormMain : Form
    {
        private GestorConexion.TABLAS tablaSeleccionada = 0;
        private DataSet dataSet = null;

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
            cbTabla.SelectedIndex = 0;

            dataSet = GestorConexion.poblarDataSet(GestorConexion.TABLAS.LIGAS);
            dataGridViewContenido.DataSource = dataSet.Tables[0];
            actualizarEstructuraGridView();
            actualizarTotalRegistros();
        }

        private void cbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            construirDataGrid();
        }

        private void construirDataGrid()
        {
            tablaSeleccionada = 0;
            dataSet = null;
            dataGridViewContenido.Columns.Clear();

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

            dataSet = GestorConexion.poblarDataSet(tablaSeleccionada);
            dataGridViewContenido.DataSource = dataSet.Tables[0];
            actualizarEstructuraGridView();
            lbTotalRegistros.Text = dataSet.Tables[0].Rows.Count.ToString();
        }

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
    }
}
