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
            SqlParameter paramNombre, paramLiga, paramLocalidad, paramInternacional;
            SqlParameter paramEstadoLiga, paramEstadoInsercion;

            sqlConnection = abrirConexion();
            sqlCommand = new SqlCommand("insertarEquipo", sqlConnection);

            paramNombre = new SqlParameter("@nombre", SqlDbType.VarChar);
            paramNombre.Direction = ParameterDirection.Input;
            paramNombre.Value = nomEquipo;
            sqlCommand.Parameters.Add(paramNombre);

            paramLiga = new SqlParameter("@liga", SqlDbType.Char);
            paramLiga.Direction = ParameterDirection.Input;
            paramLiga.Value = codLiga;
            sqlCommand.Parameters.Add(paramLiga);

            paramLocalidad = new SqlParameter("@localidad", SqlDbType.VarChar);
            paramLocalidad.Direction = ParameterDirection.Input;
            paramLocalidad.Value = localidad;
            sqlCommand.Parameters.Add(paramLocalidad);

            paramInternacional = new SqlParameter("@internacional", SqlDbType.Bit);
            paramInternacional.Direction = ParameterDirection.Input;
            paramInternacional.Value = internacional;
            sqlCommand.Parameters.Add(paramInternacional);

            paramEstadoLiga = new SqlParameter("@estadoLiga", SqlDbType.Bit);
            paramEstadoLiga.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(paramEstadoLiga);

            paramEstadoInsercion = new SqlParameter("@estadoInsercion", SqlDbType.Bit);
            paramEstadoInsercion.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(paramEstadoInsercion);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();

            result = Tuple.Create((bool)sqlCommand.Parameters["@estadoLiga"].Value, (bool)sqlCommand.Parameters["@estadoInsercion"].Value);

            sqlConnection.Close();

            return result;
        }

    }
}
