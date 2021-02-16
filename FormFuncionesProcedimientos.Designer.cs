
namespace futbol_CesarRaveloMartinez
{
    partial class FormFuncionesProcedimientos
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
            this.btListarContratos = new System.Windows.Forms.Button();
            this.btInsertarEquipo = new System.Windows.Forms.Button();
            this.btFutbolistasActivos = new System.Windows.Forms.Button();
            this.btMesesActivo = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btListarContratos
            // 
            this.btListarContratos.Location = new System.Drawing.Point(53, 67);
            this.btListarContratos.Name = "btListarContratos";
            this.btListarContratos.Size = new System.Drawing.Size(169, 23);
            this.btListarContratos.TabIndex = 0;
            this.btListarContratos.Text = "Listar contratos de futbolista";
            this.btListarContratos.UseVisualStyleBackColor = true;
            this.btListarContratos.MouseEnter += new System.EventHandler(this.btListarContratos_MouseEnter);
            this.btListarContratos.MouseLeave += new System.EventHandler(this.btListarContratos_MouseLeave);
            // 
            // btInsertarEquipo
            // 
            this.btInsertarEquipo.Location = new System.Drawing.Point(253, 67);
            this.btInsertarEquipo.Name = "btInsertarEquipo";
            this.btInsertarEquipo.Size = new System.Drawing.Size(169, 23);
            this.btInsertarEquipo.TabIndex = 1;
            this.btInsertarEquipo.Text = "Insertar nuevo equipo";
            this.btInsertarEquipo.UseVisualStyleBackColor = true;
            this.btInsertarEquipo.MouseEnter += new System.EventHandler(this.btInsertarEquipo_MouseEnter);
            this.btInsertarEquipo.MouseLeave += new System.EventHandler(this.btInsertarEquipo_MouseLeave);
            // 
            // btFutbolistasActivos
            // 
            this.btFutbolistasActivos.Location = new System.Drawing.Point(53, 109);
            this.btFutbolistasActivos.Name = "btFutbolistasActivos";
            this.btFutbolistasActivos.Size = new System.Drawing.Size(169, 23);
            this.btFutbolistasActivos.TabIndex = 2;
            this.btFutbolistasActivos.Text = "Futbolistas en activo";
            this.btFutbolistasActivos.UseVisualStyleBackColor = true;
            this.btFutbolistasActivos.MouseEnter += new System.EventHandler(this.btFutbolistasActivos_MouseEnter);
            this.btFutbolistasActivos.MouseLeave += new System.EventHandler(this.btFutbolistasActivos_MouseLeave);
            // 
            // btMesesActivo
            // 
            this.btMesesActivo.Location = new System.Drawing.Point(253, 109);
            this.btMesesActivo.Name = "btMesesActivo";
            this.btMesesActivo.Size = new System.Drawing.Size(169, 23);
            this.btMesesActivo.TabIndex = 3;
            this.btMesesActivo.Text = "Meses en activo de futbolista";
            this.btMesesActivo.UseVisualStyleBackColor = true;
            this.btMesesActivo.MouseEnter += new System.EventHandler(this.btMesesActivo_MouseEnter);
            this.btMesesActivo.MouseLeave += new System.EventHandler(this.btMesesActivo_MouseLeave);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(451, 55);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Seleccione una de las funciones o procedimientos.";
            // 
            // FormFuncionesProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 144);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.btMesesActivo);
            this.Controls.Add(this.btFutbolistasActivos);
            this.Controls.Add(this.btInsertarEquipo);
            this.Controls.Add(this.btListarContratos);
            this.Name = "FormFuncionesProcedimientos";
            this.Text = "Funciones y Procedimientos - César Ravelo Martínez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListarContratos;
        private System.Windows.Forms.Button btInsertarEquipo;
        private System.Windows.Forms.Button btFutbolistasActivos;
        private System.Windows.Forms.Button btMesesActivo;
        private System.Windows.Forms.Label lbDescripcion;
    }
}