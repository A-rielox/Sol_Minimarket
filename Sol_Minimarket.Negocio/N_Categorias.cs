//using System.Data;
//using System.Data.SqlClient;
//using Sol_Minimarket.Entidades;
//using Sol_Minimarket.Datos;

using Sol_Minimarket.Datos;
using Sol_Minimarket.Entidades;
using System.Data;

namespace Sol_Minimarket.Negocio
{
	public class N_Categorias
	{
		public static DataTable Listado_ca(string cTexto)
		{
			D_Categorias Datos = new D_Categorias();

			return Datos.Listado_ca(cTexto);
		}

		public static string Guardar_ca(int nOpcion, E_Categorias oCa)
		{
			D_Categorias Datos = new D_Categorias();

			return Datos.Guardar_ca(nOpcion, oCa);
		}

		// Eliminar_ca(int Codigo_ca)
		public static string Eliminar_ca(int Codigo_ca)
		{
			D_Categorias Datos = new D_Categorias();

			return Datos.Eliminar_ca(Codigo_ca);
		}

	}
}
