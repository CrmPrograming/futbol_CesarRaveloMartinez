
namespace futbol_CesarRaveloMartinez
{
    partial class FormInsertarContrato
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
            this.cbDNINIE = new System.Windows.Forms.ComboBox();
            this.cbCodEquipo = new System.Windows.Forms.ComboBox();
            this.lbFutbolista = new System.Windows.Forms.Label();
            this.lbEquipo = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.nudPrecioAnual = new System.Windows.Forms.NumericUpDown();
            this.lbPrecioAnual = new System.Windows.Forms.Label();
            this.lbPrecioRecision = new System.Windows.Forms.Label();
            this.nudPrecioRecision = new System.Windows.Forms.NumericUpDown();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioRecision)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDNINIE
            // 
            this.cbDNINIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDNINIE.FormattingEnabled = true;
            this.cbDNINIE.Location = new System.Drawing.Point(16, 29);
            this.cbDNINIE.Name = "cbDNINIE";
            this.cbDNINIE.Size = new System.Drawing.Size(194, 21);
            this.cbDNINIE.TabIndex = 0;
            // 
            // cbCodEquipo
            // 
            this.cbCodEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodEquipo.FormattingEnabled = true;
            this.cbCodEquipo.Location = new System.Drawing.Point(235, 29);
            this.cbCodEquipo.Name = "cbCodEquipo";
            this.cbCodEquipo.Size = new System.Drawing.Size(194, 21);
            this.cbCodEquipo.TabIndex = 1;
            // 
            // lbFutbolista
            // 
            this.lbFutbolista.AutoSize = true;
            this.lbFutbolista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFutbolista.Location = new System.Drawing.Point(13, 13);
            this.lbFutbolista.Name = "lbFutbolista";
            this.lbFutbolista.Size = new System.Drawing.Size(66, 13);
            this.lbFutbolista.TabIndex = 2;
            this.lbFutbolista.Text = "Futbolista:";
            // 
            // lbEquipo
            // 
            this.lbEquipo.AutoSize = true;
            this.lbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipo.Location = new System.Drawing.Point(234, 13);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(50, 13);
            this.lbEquipo.TabIndex = 3;
            this.lbEquipo.Text = "Equipo:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(16, 83);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(194, 20);
            this.dtpInicio.TabIndex = 4;
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicio.Location = new System.Drawing.Point(13, 67);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(81, 13);
            this.lbFechaInicio.TabIndex = 5;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFin.Location = new System.Drawing.Point(232, 67);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(67, 13);
            this.lbFechaFin.TabIndex = 6;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(235, 83);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(194, 20);
            this.dtpFin.TabIndex = 7;
            // 
            // nudPrecioAnual
            // 
            this.nudPrecioAnual.Location = new System.Drawing.Point(16, 135);
            this.nudPrecioAnual.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioAnual.Name = "nudPrecioAnual";
            this.nudPrecioAnual.Size = new System.Drawing.Size(194, 20);
            this.nudPrecioAnual.TabIndex = 8;
            // 
            // lbPrecioAnual
            // 
            this.lbPrecioAnual.AutoSize = true;
            this.lbPrecioAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioAnual.Location = new System.Drawing.Point(13, 119);
            this.lbPrecioAnual.Name = "lbPrecioAnual";
            this.lbPrecioAnual.Size = new System.Drawing.Size(83, 13);
            this.lbPrecioAnual.TabIndex = 9;
            this.lbPrecioAnual.Text = "Precio Anual:";
            // 
            // lbPrecioRecision
            // 
            this.lbPrecioRecision.AutoSize = true;
            this.lbPrecioRecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioRecision.Location = new System.Drawing.Point(232, 119);
            this.lbPrecioRecision.Name = "lbPrecioRecision";
            this.lbPrecioRecision.Size = new System.Drawing.Size(100, 13);
            this.lbPrecioRecision.TabIndex = 11;
            this.lbPrecioRecision.Text = "Precio Recisión:";
            // 
            // nudPrecioRecision
            // 
            this.nudPrecioRecision.Location = new System.Drawing.Point(235, 135);
            this.nudPrecioRecision.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioRecision.Name = "nudPrecioRecision";
            this.nudPrecioRecision.Size = new System.Drawing.Size(194, 20);
            this.nudPrecioRecision.TabIndex = 10;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(293, 161);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCrear.Location = new System.Drawing.Point(374, 161);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 12;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // FormInsertarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 188);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCrear);
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
            this.Name = "FormInsertarContrato";
            this.Text = "Insertar nuevo contrato - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormInsertarContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioRecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDNINIE;
        private System.Windows.Forms.ComboBox cbCodEquipo;
        private System.Windows.Forms.Label lbFutbolista;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.NumericUpDown nudPrecioAnual;
        private System.Windows.Forms.Label lbPrecioAnual;
        private System.Windows.Forms.Label lbPrecioRecision;
        private System.Windows.Forms.NumericUpDown nudPrecioRecision;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCrear;
    }
}