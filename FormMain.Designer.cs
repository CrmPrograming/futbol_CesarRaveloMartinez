
namespace futbol_CesarRaveloMartinez
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewContenido = new System.Windows.Forms.DataGridView();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.lbTotalRegistrosDesc = new System.Windows.Forms.Label();
            this.lbTotalRegistros = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btProcedimientos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContenido
            // 
            this.dataGridViewContenido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContenido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContenido.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewContenido.Name = "dataGridViewContenido";
            this.dataGridViewContenido.Size = new System.Drawing.Size(953, 399);
            this.dataGridViewContenido.TabIndex = 0;
            // 
            // cbTabla
            // 
            this.cbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabla.FormattingEnabled = true;
            this.cbTabla.Location = new System.Drawing.Point(12, 12);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(167, 21);
            this.cbTabla.TabIndex = 1;
            this.cbTabla.SelectedIndexChanged += new System.EventHandler(this.cbTabla_SelectedIndexChanged);
            // 
            // lbTotalRegistrosDesc
            // 
            this.lbTotalRegistrosDesc.AutoSize = true;
            this.lbTotalRegistrosDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRegistrosDesc.Location = new System.Drawing.Point(13, 445);
            this.lbTotalRegistrosDesc.Name = "lbTotalRegistrosDesc";
            this.lbTotalRegistrosDesc.Size = new System.Drawing.Size(115, 13);
            this.lbTotalRegistrosDesc.TabIndex = 2;
            this.lbTotalRegistrosDesc.Text = "Total de Registros:";
            // 
            // lbTotalRegistros
            // 
            this.lbTotalRegistros.AutoSize = true;
            this.lbTotalRegistros.Location = new System.Drawing.Point(125, 445);
            this.lbTotalRegistros.Name = "lbTotalRegistros";
            this.lbTotalRegistros.Size = new System.Drawing.Size(13, 13);
            this.lbTotalRegistros.TabIndex = 3;
            this.lbTotalRegistros.Text = "0";
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(185, 11);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(91, 23);
            this.btActualizar.TabIndex = 4;
            this.btActualizar.Text = "Aplicar Cambios";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(282, 12);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(92, 21);
            this.btInsertar.TabIndex = 5;
            this.btInsertar.Text = "Insertar Registro";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(380, 13);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(92, 21);
            this.btBorrar.TabIndex = 6;
            this.btBorrar.Text = "Borrar Registro";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(478, 13);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(92, 21);
            this.btModificar.TabIndex = 7;
            this.btModificar.Text = "Modificar Registro";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btProcedimientos
            // 
            this.btProcedimientos.BackColor = System.Drawing.Color.LightBlue;
            this.btProcedimientos.Location = new System.Drawing.Point(815, 13);
            this.btProcedimientos.Name = "btProcedimientos";
            this.btProcedimientos.Size = new System.Drawing.Size(150, 21);
            this.btProcedimientos.TabIndex = 8;
            this.btProcedimientos.Text = "Funciones y Procedimientos";
            this.btProcedimientos.UseVisualStyleBackColor = false;
            this.btProcedimientos.Click += new System.EventHandler(this.btProcedimientos_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 472);
            this.Controls.Add(this.btProcedimientos);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.lbTotalRegistros);
            this.Controls.Add(this.lbTotalRegistrosDesc);
            this.Controls.Add(this.cbTabla);
            this.Controls.Add(this.dataGridViewContenido);
            this.Name = "FormMain";
            this.Text = "Acceso a Datos - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContenido;
        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Label lbTotalRegistrosDesc;
        private System.Windows.Forms.Label lbTotalRegistros;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btProcedimientos;
    }
}

