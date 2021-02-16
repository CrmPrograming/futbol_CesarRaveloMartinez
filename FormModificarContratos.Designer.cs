
namespace futbol_CesarRaveloMartinez
{
    partial class FormModificarContratos
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.lbPrecioRecision = new System.Windows.Forms.Label();
            this.nudPrecioRecision = new System.Windows.Forms.NumericUpDown();
            this.lbPrecioAnual = new System.Windows.Forms.Label();
            this.nudPrecioAnual = new System.Windows.Forms.NumericUpDown();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lbEquipo = new System.Windows.Forms.Label();
            this.lbFutbolista = new System.Windows.Forms.Label();
            this.cbCodEquipo = new System.Windows.Forms.ComboBox();
            this.cbDNINIE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioRecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAnual)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(289, 156);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btActualizar.Location = new System.Drawing.Point(370, 156);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 26;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // lbPrecioRecision
            // 
            this.lbPrecioRecision.AutoSize = true;
            this.lbPrecioRecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioRecision.Location = new System.Drawing.Point(228, 114);
            this.lbPrecioRecision.Name = "lbPrecioRecision";
            this.lbPrecioRecision.Size = new System.Drawing.Size(100, 13);
            this.lbPrecioRecision.TabIndex = 25;
            this.lbPrecioRecision.Text = "Precio Recisión:";
            // 
            // nudPrecioRecision
            // 
            this.nudPrecioRecision.Location = new System.Drawing.Point(231, 130);
            this.nudPrecioRecision.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioRecision.Name = "nudPrecioRecision";
            this.nudPrecioRecision.Size = new System.Drawing.Size(194, 20);
            this.nudPrecioRecision.TabIndex = 24;
            // 
            // lbPrecioAnual
            // 
            this.lbPrecioAnual.AutoSize = true;
            this.lbPrecioAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioAnual.Location = new System.Drawing.Point(9, 114);
            this.lbPrecioAnual.Name = "lbPrecioAnual";
            this.lbPrecioAnual.Size = new System.Drawing.Size(83, 13);
            this.lbPrecioAnual.TabIndex = 23;
            this.lbPrecioAnual.Text = "Precio Anual:";
            // 
            // nudPrecioAnual
            // 
            this.nudPrecioAnual.Location = new System.Drawing.Point(12, 130);
            this.nudPrecioAnual.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioAnual.Name = "nudPrecioAnual";
            this.nudPrecioAnual.Size = new System.Drawing.Size(194, 20);
            this.nudPrecioAnual.TabIndex = 22;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(231, 78);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(194, 20);
            this.dtpFin.TabIndex = 21;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFin.Location = new System.Drawing.Point(228, 62);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(67, 13);
            this.lbFechaFin.TabIndex = 20;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicio.Location = new System.Drawing.Point(9, 62);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(81, 13);
            this.lbFechaInicio.TabIndex = 19;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(12, 78);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(194, 20);
            this.dtpInicio.TabIndex = 18;
            // 
            // lbEquipo
            // 
            this.lbEquipo.AutoSize = true;
            this.lbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipo.Location = new System.Drawing.Point(230, 8);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(50, 13);
            this.lbEquipo.TabIndex = 17;
            this.lbEquipo.Text = "Equipo:";
            // 
            // lbFutbolista
            // 
            this.lbFutbolista.AutoSize = true;
            this.lbFutbolista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFutbolista.Location = new System.Drawing.Point(9, 8);
            this.lbFutbolista.Name = "lbFutbolista";
            this.lbFutbolista.Size = new System.Drawing.Size(66, 13);
            this.lbFutbolista.TabIndex = 16;
            this.lbFutbolista.Text = "Futbolista:";
            // 
            // cbCodEquipo
            // 
            this.cbCodEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodEquipo.FormattingEnabled = true;
            this.cbCodEquipo.Location = new System.Drawing.Point(231, 24);
            this.cbCodEquipo.Name = "cbCodEquipo";
            this.cbCodEquipo.Size = new System.Drawing.Size(194, 21);
            this.cbCodEquipo.TabIndex = 15;
            // 
            // cbDNINIE
            // 
            this.cbDNINIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDNINIE.FormattingEnabled = true;
            this.cbDNINIE.Location = new System.Drawing.Point(12, 24);
            this.cbDNINIE.Name = "cbDNINIE";
            this.cbDNINIE.Size = new System.Drawing.Size(194, 21);
            this.cbDNINIE.TabIndex = 14;
            // 
            // FormModificarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 186);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.lbPrecioRecision);
            this.Controls.Add(this.nudPrecioRecision);
            this.Controls.Add(this.lbPrecioAnual);
            this.Controls.Add(this.nudPrecioAnual);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lbEquipo);
            this.Controls.Add(this.lbFutbolista);
            this.Controls.Add(this.cbCodEquipo);
            this.Controls.Add(this.cbDNINIE);
            this.Name = "FormModificarContratos";
            this.Text = "Modificar contrato - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormModificarContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioRecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAnual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Label lbPrecioRecision;
        private System.Windows.Forms.NumericUpDown nudPrecioRecision;
        private System.Windows.Forms.Label lbPrecioAnual;
        private System.Windows.Forms.NumericUpDown nudPrecioAnual;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.Label lbFutbolista;
        private System.Windows.Forms.ComboBox cbCodEquipo;
        private System.Windows.Forms.ComboBox cbDNINIE;
    }
}