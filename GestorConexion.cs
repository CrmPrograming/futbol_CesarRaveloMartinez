using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbol_CesarRaveloMartinez
{
    public abstract class GestorConexion
    {
        private static string SERVIDOR = @"CSAR-TORRE\SQLEXPRESS";
        private static string BD = "bdFutbol";
        private static SqlDataAdapter sqlDataAdapter;

        public enum TABLAS
        {
            LIGAS,
            EQUIPOS,
            FUTBOLISTAS,
            CONTRATOS
        }

        private static SqlConnection abrirConexion()
        {
            string connectionString = "Data Source=" + SERVIDOR + "; Initial Catalog =" + BD + "; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            return sqlConnection;
        }

        public static DataSet poblarDataSet(TABLAS tabla)
        {
            SqlConnection conexion = abrirConexion();
            sqlDataAdapter = null;
            DataSet dataSet = new DataSet();
            string query = "";

            switch (tabla)
            {
                case TABLAS.LIGAS:
                    query = "SELECT * FROM ligas";
                    sqlDataAdapter = new SqlDataAdapter(query, conexion);
                    sqlDataAdapter.Fill(dataSet, "ligas");
                    break;
                case TABLAS.EQUIPOS:
                    query = "SELECT * FROM equipos; SELECT * FROM ligas";
                    sqlDataAdapter = new SqlDataAdapter(query, conexion);
                    sqlDataAdapter.Fill(dataSet);
                    break;
                case TABLAS.FUTBOLISTAS:
                    query = "SELECT * FROM fubtbolistas";
                    sqlDataAdapter = new SqlDataAdapter(query, conexion);
                    sqlDataAdapter.Fill(dataSet);
                    break;
                case TABLAS.CONTRATOS:
                    query = "SELECT * FROM contratos; SELECT * FROM equipos; SELECT * FROM fubtbolistas";
                    sqlDataAdapter = new SqlDataAdapter(query, conexion);
                    sqlDataAdapter.Fill(dataSet);
                    break;
            }

            conexion.Close();
            return dataSet;
        }

        public static bool actualizarTabla(DataSet dataSet)
        {
            bool result = false;
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            try
            {
                sqlDataAdapter.Update(dataSet.Tables[0]);
                result = true;
            } catch (SqlException e)
            {
                MessageBox.Show("Se ha producido un error al intentar realizar la operación:\r\n\r\n" + e.Message);
            }
            return result;
        }

        public static void obtenerListadoContratos(DataGridView dataGridView, string dnionie)
        {
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            SqlParameter sqlParameter;
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();

            sqlConnection = abrirConexion();
            sqlCommand = new SqlCommand("listarContratoFutbolista", sqlConnection);
            sqlParameter = new SqlParameter("@coddnionie", SqlDbType.Char);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlParameter.Direction = ParameterDirection.Input;
            sqlParameter.Value = dnionie;
            sqlCommand.Parameters.Add(sqlParameter);

            sqlDataReader = sqlCommand.ExecuteReader();

            dataTable.Load(sqlDataReader);
            dataGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        public static Dictionary<string, string> obtenerListadoLigas()
        {
            Dictionary<string, string> listado = new Dictionary<string, string>();
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();

            sqlConnection = abrirConexion();
            sqlCommand = new SqlCommand("SELECT * FROM ligas", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            dataTable.Load(sqlDataReader);

            foreach (DataRow row in dataTable.Rows)
            {
                listado.Add(row[1].ToString(), row[0].ToString());
            }

            sqlConnection.Close();
            return listado;
        }

        public static Tuple<bool, bool> insertarEquipo(string codLiga, string nomEquipo, string localidad, bool internacional)
        {
            Tuple<bool, bool> result;
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            SqlParameter inNombre, inLiga, inLocalidad, inInternacional;
            SqlParameter outEstadoLiga, outEstadoInsercion;

            sqlConnection = abrirConexion();
            sqlCommand = new SqlCommand("insertarEquipo", sqlConnection);

            // Parámetros de entrada

            inNombre = new SqlParameter("@nombre", SqlDbType.VarChar);
            inNombre.Direction = ParameterDirection.Input;
            inNombre.Value = nomEquipo;
            sqlCommand.Parameters.Add(inNombre);

            inLiga = new SqlParameter("@liga", SqlDbType.Char);
            inLiga.Direction = ParameterDirection.Input;
            inLiga.Value = codLiga;
            sqlCommand.Parameters.Add(inLiga);

            inLocalidad = new SqlParameter("@localidad", SqlDbType.VarChar);
            inLocalidad.Direction = ParameterDirection.Input;
            inLocalidad.Value = localidad;
            sqlCommand.Parameters.Add(inLocalidad);

            inInternacional = new SqlParameter("@internacional", SqlDbType.Bit);
            inInternacional.Direction = ParameterDirection.Input;
            inInternacional.Value = internacional;
            sqlCommand.Parameters.Add(inInternacional);

            // Parámetros de salida

            outEstadoLiga = new SqlParameter("@estadoLiga", SqlDbType.Bit);
            outEstadoLiga.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(outEstadoLiga);

            outEstadoInsercion = new SqlParameter("@estadoInsercion", SqlDbType.Bit);
            outEstadoInsercion.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(outEstadoInsercion);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();

            result = Tuple.Create((bool)sqlCommand.Parameters["@estadoLiga"].Value, (bool)sqlCommand.Parameters["@estadoInsercion"].Value);

            sqlConnection.Close();

            return result;
        }

        public static Tuple<int, int> obtenerFutbolistasActivos(int codEquipo, int precioAnual, int precioRecision)
        {
            Tuple<int, int> result;
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            SqlParameter inCodEquipo, inPrecioAnual, inPrecioRecision;
            SqlParameter outActivosEquipo, outActivosCriterio;

            sqlConnection = abrirConexion();
            sqlCommand = new SqlCommand("futbolistasActivos", sqlConnection);

            // Parámetros de entrada

            inCodEquipo = new SqlParameter("@equipo", SqlDbType.Int);
            inCodEquipo.Direction = ParameterDirection.Input;
            inCodEquipo.Value = codEquipo;
            sqlCommand.Parameters.Add(inCodEquipo);

            inPrecioAnual = new SqlParameter("@precio", SqlDbType.Int);
            inPrecioAnual.Direction = ParameterDirection.Input;
            inPrecioAnual.Value = precioAnual;
            sqlCommand.Parameters.Add(inPrecioAnual);

            inPrecioRecision = new SqlParameter("@recision", SqlDbType.Int);
            inPrecioRecision.Direction = ParameterDirection.Input;
            inPrecioRecision.Value = precioRecision;
            sqlCommand.Parameters.Add(inPrecioRecision);

            // Parámetros de salida

            outActivosEquipo = new SqlParameter("@activosEquipo", SqlDbType.Int);
            outActivosEquipo.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(outActivosEquipo);

            outActivosCriterio = new SqlParameter("@activosPrecioAnual", SqlDbType.Int);
            outActivosCriterio.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(outActivosCriterio);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();

            result = Tuple.Create((int)sqlCommand.Parameters["@activosEquipo"].Value, (int)sqlCommand.Parameters["@activosPrecioAnual"].Value);

            sqlConnection.Close();

            return result;
        }

    }
}
