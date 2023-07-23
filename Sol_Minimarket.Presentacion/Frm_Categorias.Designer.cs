namespace Sol_Minimarket.Presentacion
{
	partial class Frm_Categorias
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Tbc_principal = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Dgv_principal = new System.Windows.Forms.DataGridView();
			this.Btn_buscar = new System.Windows.Forms.Button();
			this.Txt_buscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Btn_retornar = new System.Windows.Forms.Button();
			this.Btn_guardar = new System.Windows.Forms.Button();
			this.Btn_cancelar = new System.Windows.Forms.Button();
			this.Txt_descripcion_ca = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Btn_nuevo = new System.Windows.Forms.Button();
			this.Btn_actualizar = new System.Windows.Forms.Button();
			this.Btn_eliminar = new System.Windows.Forms.Button();
			this.Btn_reporte = new System.Windows.Forms.Button();
			this.Btn_salir = new System.Windows.Forms.Button();
			this.Tbc_principal.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tbc_principal
			// 
			this.Tbc_principal.Controls.Add(this.tabPage1);
			this.Tbc_principal.Controls.Add(this.tabPage2);
			this.Tbc_principal.Location = new System.Drawing.Point(20, 20);
			this.Tbc_principal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Tbc_principal.Name = "Tbc_principal";
			this.Tbc_principal.SelectedIndex = 0;
			this.Tbc_principal.Size = new System.Drawing.Size(1110, 400);
			this.Tbc_principal.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.Dgv_principal);
			this.tabPage1.Controls.Add(this.Btn_buscar);
			this.tabPage1.Controls.Add(this.Txt_buscar);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new System.Drawing.Size(1102, 367);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Listado";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Dgv_principal
			// 
			this.Dgv_principal.AllowUserToAddRows = false;
			this.Dgv_principal.AllowUserToDeleteRows = false;
			this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Dgv_principal.Location = new System.Drawing.Point(78, 108);
			this.Dgv_principal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Dgv_principal.Name = "Dgv_principal";
			this.Dgv_principal.ReadOnly = true;
			this.Dgv_principal.RowHeadersWidth = 62;
			this.Dgv_principal.Size = new System.Drawing.Size(884, 231);
			this.Dgv_principal.TabIndex = 3;
			this.Dgv_principal.DoubleClick += new System.EventHandler(this.Dgv_principal_DoubleClick);
			// 
			// Btn_buscar
			// 
			this.Btn_buscar.Location = new System.Drawing.Point(417, 63);
			this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_buscar.Name = "Btn_buscar";
			this.Btn_buscar.Size = new System.Drawing.Size(112, 35);
			this.Btn_buscar.TabIndex = 2;
			this.Btn_buscar.Text = "Buscar";
			this.Btn_buscar.UseVisualStyleBackColor = true;
			this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
			// 
			// Txt_buscar
			// 
			this.Txt_buscar.Location = new System.Drawing.Point(147, 66);
			this.Txt_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Txt_buscar.Name = "Txt_buscar";
			this.Txt_buscar.Size = new System.Drawing.Size(258, 26);
			this.Txt_buscar.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 71);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscar :";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Btn_retornar);
			this.tabPage2.Controls.Add(this.Btn_guardar);
			this.tabPage2.Controls.Add(this.Btn_cancelar);
			this.tabPage2.Controls.Add(this.Txt_descripcion_ca);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new System.Drawing.Size(1102, 367);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Mantenimiento";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Btn_retornar
			// 
			this.Btn_retornar.Location = new System.Drawing.Point(471, 109);
			this.Btn_retornar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_retornar.Name = "Btn_retornar";
			this.Btn_retornar.Size = new System.Drawing.Size(112, 35);
			this.Btn_retornar.TabIndex = 4;
			this.Btn_retornar.Text = "Retornar";
			this.Btn_retornar.UseVisualStyleBackColor = true;
			this.Btn_retornar.Visible = false;
			this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
			// 
			// Btn_guardar
			// 
			this.Btn_guardar.Location = new System.Drawing.Point(350, 109);
			this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_guardar.Name = "Btn_guardar";
			this.Btn_guardar.Size = new System.Drawing.Size(112, 35);
			this.Btn_guardar.TabIndex = 3;
			this.Btn_guardar.Text = "Guardar";
			this.Btn_guardar.UseVisualStyleBackColor = true;
			this.Btn_guardar.Visible = false;
			this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
			// 
			// Btn_cancelar
			// 
			this.Btn_cancelar.Location = new System.Drawing.Point(228, 109);
			this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_cancelar.Name = "Btn_cancelar";
			this.Btn_cancelar.Size = new System.Drawing.Size(112, 35);
			this.Btn_cancelar.TabIndex = 2;
			this.Btn_cancelar.Text = "Cancelar";
			this.Btn_cancelar.UseVisualStyleBackColor = true;
			this.Btn_cancelar.Visible = false;
			this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
			// 
			// Txt_descripcion_ca
			// 
			this.Txt_descripcion_ca.Location = new System.Drawing.Point(190, 69);
			this.Txt_descripcion_ca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Txt_descripcion_ca.Name = "Txt_descripcion_ca";
			this.Txt_descripcion_ca.ReadOnly = true;
			this.Txt_descripcion_ca.Size = new System.Drawing.Size(348, 26);
			this.Txt_descripcion_ca.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 74);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Categoría (*) :";
			// 
			// Btn_nuevo
			// 
			this.Btn_nuevo.Location = new System.Drawing.Point(44, 455);
			this.Btn_nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_nuevo.Name = "Btn_nuevo";
			this.Btn_nuevo.Size = new System.Drawing.Size(112, 82);
			this.Btn_nuevo.TabIndex = 1;
			this.Btn_nuevo.Text = "Nuevo";
			this.Btn_nuevo.UseVisualStyleBackColor = true;
			this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
			// 
			// Btn_actualizar
			// 
			this.Btn_actualizar.Location = new System.Drawing.Point(165, 455);
			this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_actualizar.Name = "Btn_actualizar";
			this.Btn_actualizar.Size = new System.Drawing.Size(112, 82);
			this.Btn_actualizar.TabIndex = 2;
			this.Btn_actualizar.Text = "Actualizar";
			this.Btn_actualizar.UseVisualStyleBackColor = true;
			this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
			// 
			// Btn_eliminar
			// 
			this.Btn_eliminar.Location = new System.Drawing.Point(286, 455);
			this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_eliminar.Name = "Btn_eliminar";
			this.Btn_eliminar.Size = new System.Drawing.Size(112, 82);
			this.Btn_eliminar.TabIndex = 3;
			this.Btn_eliminar.Text = "Eliminar";
			this.Btn_eliminar.UseVisualStyleBackColor = true;
			this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
			// 
			// Btn_reporte
			// 
			this.Btn_reporte.Location = new System.Drawing.Point(408, 455);
			this.Btn_reporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_reporte.Name = "Btn_reporte";
			this.Btn_reporte.Size = new System.Drawing.Size(112, 82);
			this.Btn_reporte.TabIndex = 4;
			this.Btn_reporte.Text = "Reporte";
			this.Btn_reporte.UseVisualStyleBackColor = true;
			// 
			// Btn_salir
			// 
			this.Btn_salir.Location = new System.Drawing.Point(530, 455);
			this.Btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Btn_salir.Name = "Btn_salir";
			this.Btn_salir.Size = new System.Drawing.Size(112, 82);
			this.Btn_salir.TabIndex = 5;
			this.Btn_salir.Text = "Salir";
			this.Btn_salir.UseVisualStyleBackColor = true;
			// 
			// Frm_Categorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 555);
			this.Controls.Add(this.Btn_salir);
			this.Controls.Add(this.Btn_reporte);
			this.Controls.Add(this.Btn_eliminar);
			this.Controls.Add(this.Btn_actualizar);
			this.Controls.Add(this.Btn_nuevo);
			this.Controls.Add(this.Tbc_principal);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Frm_Categorias";
			this.Text = "Categorias";
			this.Load += new System.EventHandler(this.Frm_Categorias_Load);
			this.Tbc_principal.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Tbc_principal;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button Btn_buscar;
		private System.Windows.Forms.TextBox Txt_buscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView Dgv_principal;
		private System.Windows.Forms.Button Btn_nuevo;
		private System.Windows.Forms.Button Btn_actualizar;
		private System.Windows.Forms.Button Btn_eliminar;
		private System.Windows.Forms.Button Btn_reporte;
		private System.Windows.Forms.Button Btn_salir;
		private System.Windows.Forms.Button Btn_guardar;
		private System.Windows.Forms.Button Btn_cancelar;
		private System.Windows.Forms.TextBox Txt_descripcion_ca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Btn_retornar;
	}
}