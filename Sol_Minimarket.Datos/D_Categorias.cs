//using Sol_Minimarket.Entidades;

using Sol_Minimarket.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Sol_Minimarket.Datos
{
	public class D_Categorias
	{
		public DataTable Listado_ca(string cTexto)
		{
			// activar comunicacion con sqlServer
			SqlDataReader Resultado;
			DataTable Tabla = new DataTable();
			SqlConnection SQLCon = new SqlConnection();

			try
			{
				SQLCon = Conexion.getInstancia().CrearConexion(); // de mi clase Conexion

				SqlCommand Comando = new SqlCommand("USP_Listado_ca", SQLCon);

				Comando.CommandType = CommandType.StoredProcedure;

				Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;

				SQLCon.Open();

				Resultado = Comando.ExecuteReader();

				Tabla.Load(Resultado);

				return Tabla;
			}
			catch (Exception ex)
			{

				throw ex;
			}

			finally
			{
				if(SQLCon.State == ConnectionState.Open) SQLCon.Close();
			}
		}

		public string Guardar_ca(int nOpcion, E_Categorias oCa)
		{
			string Rpta = "";

			SqlConnection SQLCon = new SqlConnection();

			try
			{
				SQLCon = Conexion.getInstancia().CrearConexion(); // de mi clase Conexion

				SqlCommand Comando = new SqlCommand("USP_Guardar_ca", SQLCon);

				Comando.CommandType = CommandType.StoredProcedure;

				Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
				Comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = oCa.Codigo_ca;
				Comando.Parameters.Add("@cDescripcion_ca", SqlDbType.VarChar).Value = oCa.Descripcion_ca;

				SQLCon.Open();

				Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo registrar los datos.";
			}
			catch (Exception ex)
			{
				Rpta = ex.Message;
			}

			finally
			{
				if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
			}

			return Rpta;
		}

		public string Eliminar_ca(int Codigo_ca)
		{
			string Rpta = "";

			SqlConnection SQLCon = new SqlConnection();

			try
			{
				SQLCon = Conexion.getInstancia().CrearConexion(); // de mi clase Conexion

				SqlCommand Comando = new SqlCommand("USP_Eliminar_ca", SQLCon);

				Comando.CommandType = CommandType.StoredProcedure;

				Comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = Codigo_ca;

				SQLCon.Open();

				Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo eliminar el dato.";
			}
			catch (Exception ex)
			{
				Rpta = ex.Message;
			}

			finally
			{
				if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
			}

			return Rpta;
		}
	}
}
