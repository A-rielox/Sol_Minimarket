using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sol_Minimarket.Entidades;
using Sol_Minimarket.Negocio;

namespace Sol_Minimarket.Presentacion
{
	public partial class Frm_Categorias : Form
	{
		public Frm_Categorias()
		{
			InitializeComponent();
		}

		#region "Mis variables"

		int Codigo_ca = 0; // codigo ( d la categoria ) de la row en la q se pica
		int Estadoguarda = 0; // sin accion

		#endregion


		//private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		//{

		//}

		#region "Mis Métodos

		private void Formato_ca()
		{
			Dgv_principal.Columns[0].Width = 100;
			Dgv_principal.Columns[0].HeaderText = "CÓDIGO_CA";
			Dgv_principal.Columns[1].Width = 300;
			Dgv_principal.Columns[1].HeaderText = "CATEGORIA";
		}

		private void Listado_ca(string cTexto)
		{
			try
			{
				// el sp recive codigo + descripcion
				Dgv_principal.DataSource = N_Categorias.Listado_ca(cTexto);

				this.Formato_ca();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.StackTrace);
			}
		}

		private void Estado_BotonesPrincipales(bool lEstado)
		{
			this.Btn_nuevo.Enabled = lEstado;
			this.Btn_actualizar.Enabled = lEstado;
			this.Btn_eliminar.Enabled = lEstado;
			this.Btn_reporte.Enabled = lEstado;
			this.Btn_salir.Enabled = lEstado;
		}

		private void Estado_BotonesProcesos(bool lEstado)
		{
			this.Btn_cancelar.Visible = lEstado;
			this.Btn_guardar.Visible = lEstado;
			this.Btn_retornar.Visible = !lEstado;
		}

		private void Selecciona_item()
		{
			if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value)))
			{
				MessageBox.Show("No se tiene informacion para visualizar.", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.Codigo_ca = Convert.ToInt32( Dgv_principal.CurrentRow.Cells["codigo_ca"].Value );
				Txt_descripcion_ca.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ca"].Value);
			}
		}

		#endregion

		private void Frm_Categorias_Load(object sender, EventArgs e)
		{
			this.Listado_ca("%");
		}

		private void Btn_guardar_Click(object sender, EventArgs e)
		{
			if(Txt_descripcion_ca.Text == string.Empty)
			{
				MessageBox.Show("Falta ingrasar datos requeridos (*).", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				E_Categorias oCa = new E_Categorias();

				string Rpta = "";
				//oCa.Codigo_ca = 0;  1 : crear, 2 : modificar
				oCa.Codigo_ca = this.Codigo_ca; // si estoy en crear => tiene 0, si estoy en modificar => tiene el indice
				oCa.Descripcion_ca = Txt_descripcion_ca.Text.Trim();

				Rpta = N_Categorias.Guardar_ca(Estadoguarda, oCa);

				if(Rpta == "Ok")
				{
					this.Listado_ca("%");

					MessageBox.Show("Los datos han sido guardados correctamente.", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);

					Estadoguarda = 0;
					this.Estado_BotonesPrincipales(true);
					this.Estado_BotonesProcesos(false);
					Txt_descripcion_ca.Text = "";
					Tbc_principal.SelectedIndex = 0;
					Txt_descripcion_ca.ReadOnly = true;

					this.Codigo_ca = 0; // reseteo
				}
				else
				{
					MessageBox.Show(Rpta, "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void Btn_nuevo_Click(object sender, EventArgs e)
		{
			Estadoguarda = 1; // nuevo registro

			this.Estado_BotonesPrincipales(false);
			this.Estado_BotonesProcesos(true);

			Txt_descripcion_ca.Text = "";
			Txt_descripcion_ca.ReadOnly = false;
			Tbc_principal.SelectedIndex = 1;
			Txt_descripcion_ca.Focus();
		}

		private void Btn_actualizar_Click(object sender, EventArgs e)
		{
			Estadoguarda = 2; // actualiza registro

			this.Estado_BotonesPrincipales(false);
			this.Estado_BotonesProcesos(true);

			this.Selecciona_item();
			Txt_descripcion_ca.ReadOnly = false;
			Tbc_principal.SelectedIndex = 1;
			Txt_descripcion_ca.Focus();
		}

		private void Btn_cancelar_Click(object sender, EventArgs e)
		{
			Estadoguarda = 0;
			this.Codigo_ca = 0; // reseteo

			this.Estado_BotonesPrincipales(true);
			this.Estado_BotonesProcesos(false);

			Txt_descripcion_ca.Text = "";
			Txt_descripcion_ca.ReadOnly = true;
			Tbc_principal.SelectedIndex = 0;
		}

		private void Dgv_principal_DoubleClick(object sender, EventArgs e)
		{
			this.Selecciona_item();
			this.Estado_BotonesProcesos(false);
			Tbc_principal.SelectedIndex = 1;
		}

		private void Btn_retornar_Click(object sender, EventArgs e)
		{

			this.Estado_BotonesProcesos(false);
			this.Codigo_ca = 0; // reseteo
			Tbc_principal.SelectedIndex = 0;
		}

		private void Btn_eliminar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value)))
			{
				MessageBox.Show("No se ha seleccionado información.", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult Opcion;
				Opcion = MessageBox.Show("Seguro de eliminar el registro ?", "Aviso del sistema.",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (Opcion == DialogResult.Yes)
				{
					string Rpta = "";
					this.Codigo_ca = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value);

					Rpta = N_Categorias.Eliminar_ca(this.Codigo_ca);

					if (Rpta == "Ok")
					{
						this.Listado_ca("%");

						MessageBox.Show("Registro eliminado correctamente.", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);

						this.Codigo_ca = 0; // reseteo
					}
					else
					{
						MessageBox.Show(Rpta, "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
			}
		}

		private void Btn_buscar_Click(object sender, EventArgs e)
		{
			this.Listado_ca(Txt_buscar.Text.Trim());
		}
	}
}
