
namespace futbol_CesarRaveloMartinez
{
    partial class FormFutbolistasActivos
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
            this.lbCodEquipo = new System.Windows.Forms.Label();
            this.lbPrecioAnual = new System.Windows.Forms.Label();
            this.lbPrecioRecision = new System.Windows.Forms.Label();
            this.nudPrecioRecision = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioAnual = new System.Windows.Forms.NumericUpDown();
            this.lbFutbolistasActivos = new System.Windows.Forms.Label();
            this.lbActivosCriterio = new System.Windows.Forms.Label();
            this.lbResultActivos = new System.Windows.Forms.Label();
            this.lbResultCriterio = new System.Windows.Forms.Label();
            this.btConsulta = new System.Windows.Forms.Button();
            this.nudCodEquipo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioRecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodEquipo
            // 
            this.lbCodEquipo.AutoSize = true;
            this.lbCodEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodEquipo.Location = new System.Drawing.Point(13, 13);
            this.lbCodEquipo.Name = "lbCodEquipo";
            this.lbCodEquipo.Size = new System.Drawing.Size(110, 13);
            this.lbCodEquipo.TabIndex = 0;
            this.lbCodEquipo.Text = "Código de equipo:";
            // 
            // lbPrecioAnual
            // 
            this.lbPrecioAnual.AutoSize = true;
            this.lbPrecioAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioAnual.Location = new System.Drawing.Point(151, 13);
            this.lbPrecioAnual.Name = "lbPrecioAnual";
            this.lbPrecioAnual.Size = new System.Drawing.Size(83, 13);
            this.lbPrecioAnual.TabIndex = 2;
            this.lbPrecioAnual.Text = "Precio Anual:";
            // 
            // lbPrecioRecision
            // 
            this.lbPrecioRecision.AutoSize = true;
            this.lbPrecioRecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioRecision.Location = new System.Drawing.Point(370, 13);
            this.lbPrecioRecision.Name = "lbPrecioRecision";
            this.lbPrecioRecision.Size = new System.Drawing.Size(100, 13);
            this.lbPrecioRecision.TabIndex = 3;
            this.lbPrecioRecision.Text = "Precio Recisión:";
            // 
            // nudPrecioRecision
            // 
            this.nudPrecioRecision.Location = new System.Drawing.Point(373, 30);
            this.nudPrecioRecision.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioRecision.Name = "nudPrecioRecision";
            this.nudPrecioRecision.Size = new System.Drawing.Size(194, 20);
            this.nudPrecioRecision.TabIndex = 12;
            // 
            // nudPrecioAnual
            // 
            this.nudPrecioAnual.Location = new System.Drawing.Point(154, 30);
            this.nudPrecioAnual.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioAnual.Name = "nudPrecioAnual";
            this.nudPrecioAnual.Size = new System.Drawing.Size(194, 20);
            this.nudPrecioAnual.TabIndex = 11;
            // 
            // lbFutbolistasActivos
            // 
            this.lbFutbolistasActivos.AutoSize = true;
            this.lbFutbolistasActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFutbolistasActivos.Location = new System.Drawing.Point(13, 99);
            this.lbFutbolistasActivos.Name = "lbFutbolistasActivos";
            this.lbFutbolistasActivos.Size = new System.Drawing.Size(129, 13);
            this.lbFutbolistasActivos.TabIndex = 13;
            this.lbFutbolistasActivos.Text = "Futbolistas en activo:";
            // 
            // lbActivosCriterio
            // 
            this.lbActivosCriterio.AutoSize = true;
            this.lbActivosCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivosCriterio.Location = new System.Drawing.Point(13, 136);
            this.lbActivosCriterio.Name = "lbActivosCriterio";
            this.lbActivosCriterio.Size = new System.Drawing.Size(210, 13);
            this.lbActivosCriterio.TabIndex = 14;
            this.lbActivosCriterio.Text = "Futbolistas en activo según criterio:";
            // 
            // lbResultActivos
            // 
            this.lbResultActivos.AutoSize = true;
            this.lbResultActivos.Location = new System.Drawing.Point(154, 99);
            this.lbResultActivos.Name = "lbResultActivos";
            this.lbResultActivos.Size = new System.Drawing.Size(132, 13);
            this.lbResultActivos.TabIndex = 15;
            this.lbResultActivos.Text = "Indique un equipo primero.";
            // 
            // lbResultCriterio
            // 
            this.lbResultCriterio.AutoSize = true;
            this.lbResultCriterio.Location = new System.Drawing.Point(239, 136);
            this.lbResultCriterio.Name = "lbResultCriterio";
            this.lbResultCriterio.Size = new System.Drawing.Size(132, 13);
            this.lbResultCriterio.TabIndex = 16;
            this.lbResultCriterio.Text = "Indique un equipo primero.";
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(16, 63);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(111, 23);
            this.btConsulta.TabIndex = 17;
            this.btConsulta.Text = "Realizar consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // nudCodEquipo
            // 
            this.nudCodEquipo.Location = new System.Drawing.Point(16, 30);
            this.nudCodEquipo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudCodEquipo.Name = "nudCodEquipo";
            this.nudCodEquipo.Size = new System.Drawing.Size(111, 20);
            this.nudCodEquipo.TabIndex = 18;
            // 
            // FormFutbolistasActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 171);
            this.Controls.Add(this.nudCodEquipo);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.lbResultCriterio);
            this.Controls.Add(this.lbResultActivos);
            this.Controls.Add(this.lbActivosCriterio);
            this.Controls.Add(this.lbFutbolistasActivos);
            this.Controls.Add(this.nudPrecioRecision);
            this.Controls.Add(this.nudPrecioAnual);
            this.Controls.Add(this.lbPrecioRecision);
            this.Controls.Add(this.lbPrecioAnual);
            this.Controls.Add(this.lbCodEquipo);
            this.Name = "FormFutbolistasActivos";
            this.Text = "Futbolistas en activo - César Ravelo Martínez";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioRecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodEquipo;
        private System.Windows.Forms.Label lbPrecioAnual;
        private System.Windows.Forms.Label lbPrecioRecision;
        private System.Windows.Forms.NumericUpDown nudPrecioRecision;
        private System.Windows.Forms.NumericUpDown nudPrecioAnual;
        private System.Windows.Forms.Label lbFutbolistasActivos;
        private System.Windows.Forms.Label lbActivosCriterio;
        private System.Windows.Forms.Label lbResultActivos;
        private System.Windows.Forms.Label lbResultCriterio;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.NumericUpDown nudCodEquipo;
    }
}