
namespace futbol_CesarRaveloMartinez
{
    partial class FormBorrarContratos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lbcodContrato = new System.Windows.Forms.Label();
            this.lbcontentcodContrato = new System.Windows.Forms.Label();
            this.lbcodFutbolista = new System.Windows.Forms.Label();
            this.lbcontentDNINIE = new System.Windows.Forms.Label();
            this.lbcodEquipo = new System.Windows.Forms.Label();
            this.lbcontentcodEquipo = new System.Windows.Forms.Label();
            this.lbfechaInicio = new System.Windows.Forms.Label();
            this.lbcontentfechaInicio = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbcontentFechaFin = new System.Windows.Forms.Label();
            this.lbprecioAnual = new System.Windows.Forms.Label();
            this.lbcontentPrecioAnual = new System.Windows.Forms.Label();
            this.lbPrecioRecision = new System.Windows.Forms.Label();
            this.lbcontentprecioRecision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Esta operación es irreversible. ¿Desea continuar?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Se va a borrar el contrato con los siguientes datos:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(291, 157);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btBorrar.Location = new System.Drawing.Point(372, 157);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lbcodContrato
            // 
            this.lbcodContrato.AutoSize = true;
            this.lbcodContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodContrato.Location = new System.Drawing.Point(12, 34);
            this.lbcodContrato.Name = "lbcodContrato";
            this.lbcodContrato.Size = new System.Drawing.Size(120, 13);
            this.lbcodContrato.TabIndex = 12;
            this.lbcodContrato.Text = "Código de Contrato:";
            // 
            // lbcontentcodContrato
            // 
            this.lbcontentcodContrato.AutoSize = true;
            this.lbcontentcodContrato.Location = new System.Drawing.Point(138, 34);
            this.lbcontentcodContrato.Name = "lbcontentcodContrato";
            this.lbcontentcodContrato.Size = new System.Drawing.Size(35, 13);
            this.lbcontentcodContrato.TabIndex = 13;
            this.lbcontentcodContrato.Text = "label3";
            // 
            // lbcodFutbolista
            // 
            this.lbcodFutbolista.AutoSize = true;
            this.lbcodFutbolista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodFutbolista.Location = new System.Drawing.Point(200, 34);
            this.lbcodFutbolista.Name = "lbcodFutbolista";
            this.lbcodFutbolista.Size = new System.Drawing.Size(143, 13);
            this.lbcodFutbolista.TabIndex = 14;
            this.lbcodFutbolista.Text = "DNI o NIE de futbolista:";
            // 
            // lbcontentDNINIE
            // 
            this.lbcontentDNINIE.AutoSize = true;
            this.lbcontentDNINIE.Location = new System.Drawing.Point(349, 34);
            this.lbcontentDNINIE.Name = "lbcontentDNINIE";
            this.lbcontentDNINIE.Size = new System.Drawing.Size(35, 13);
            this.lbcontentDNINIE.TabIndex = 15;
            this.lbcontentDNINIE.Text = "label3";
            // 
            // lbcodEquipo
            // 
            this.lbcodEquipo.AutoSize = true;
            this.lbcodEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodEquipo.Location = new System.Drawing.Point(12, 56);
            this.lbcodEquipo.Name = "lbcodEquipo";
            this.lbcodEquipo.Size = new System.Drawing.Size(111, 13);
            this.lbcodEquipo.TabIndex = 16;
            this.lbcodEquipo.Text = "Código de Equipo:";
            // 
            // lbcontentcodEquipo
            // 
            this.lbcontentcodEquipo.AutoSize = true;
            this.lbcontentcodEquipo.Location = new System.Drawing.Point(138, 56);
            this.lbcontentcodEquipo.Name = "lbcontentcodEquipo";
            this.lbcontentcodEquipo.Size = new System.Drawing.Size(35, 13);
            this.lbcontentcodEquipo.TabIndex = 17;
            this.lbcontentcodEquipo.Text = "label3";
            // 
            // lbfechaInicio
            // 
            this.lbfechaInicio.AutoSize = true;
            this.lbfechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechaInicio.Location = new System.Drawing.Point(12, 80);
            this.lbfechaInicio.Name = "lbfechaInicio";
            this.lbfechaInicio.Size = new System.Drawing.Size(99, 13);
            this.lbfechaInicio.TabIndex = 18;
            this.lbfechaInicio.Text = "Fecha de Inicio:";
            // 
            // lbcontentfechaInicio
            // 
            this.lbcontentfechaInicio.AutoSize = true;
            this.lbcontentfechaInicio.Location = new System.Drawing.Point(138, 80);
            this.lbcontentfechaInicio.Name = "lbcontentfechaInicio";
            this.lbcontentfechaInicio.Size = new System.Drawing.Size(35, 13);
            this.lbcontentfechaInicio.TabIndex = 19;
            this.lbcontentfechaInicio.Text = "label3";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFin.Location = new System.Drawing.Point(200, 80);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(135, 13);
            this.lbFechaFin.TabIndex = 20;
            this.lbFechaFin.Text = "Fecha de Finalización:";
            // 
            // lbcontentFechaFin
            // 
            this.lbcontentFechaFin.AutoSize = true;
            this.lbcontentFechaFin.Location = new System.Drawing.Point(349, 80);
            this.lbcontentFechaFin.Name = "lbcontentFechaFin";
            this.lbcontentFechaFin.Size = new System.Drawing.Size(35, 13);
            this.lbcontentFechaFin.TabIndex = 21;
            this.lbcontentFechaFin.Text = "label3";
            // 
            // lbprecioAnual
            // 
            this.lbprecioAnual.AutoSize = true;
            this.lbprecioAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecioAnual.Location = new System.Drawing.Point(12, 103);
            this.lbprecioAnual.Name = "lbprecioAnual";
            this.lbprecioAnual.Size = new System.Drawing.Size(83, 13);
            this.lbprecioAnual.TabIndex = 22;
            this.lbprecioAnual.Text = "Precio Anual:";
            // 
            // lbcontentPrecioAnual
            // 
            this.lbcontentPrecioAnual.AutoSize = true;
            this.lbcontentPrecioAnual.Location = new System.Drawing.Point(138, 103);
            this.lbcontentPrecioAnual.Name = "lbcontentPrecioAnual";
            this.lbcontentPrecioAnual.Size = new System.Drawing.Size(35, 13);
            this.lbcontentPrecioAnual.TabIndex = 23;
            this.lbcontentPrecioAnual.Text = "label3";
            // 
            // lbPrecioRecision
            // 
            this.lbPrecioRecision.AutoSize = true;
            this.lbPrecioRecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioRecision.Location = new System.Drawing.Point(200, 103);
            this.lbPrecioRecision.Name = "lbPrecioRecision";
            this.lbPrecioRecision.Size = new System.Drawing.Size(118, 13);
            this.lbPrecioRecision.TabIndex = 24;
            this.lbPrecioRecision.Text = "Precio de Recisión:";
            // 
            // lbcontentprecioRecision
            // 
            this.lbcontentprecioRecision.AutoSize = true;
            this.lbcontentprecioRecision.Location = new System.Drawing.Point(349, 103);
            this.lbcontentprecioRecision.Name = "lbcontentprecioRecision";
            this.lbcontentprecioRecision.Size = new System.Drawing.Size(35, 13);
            this.lbcontentprecioRecision.TabIndex = 25;
            this.lbcontentprecioRecision.Text = "label3";
            // 
            // FormBorrarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 192);
            this.Controls.Add(this.lbcontentprecioRecision);
            this.Controls.Add(this.lbPrecioRecision);
            this.Controls.Add(this.lbcontentPrecioAnual);
            this.Controls.Add(this.lbprecioAnual);
            this.Controls.Add(this.lbcontentFechaFin);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.lbcontentfechaInicio);
            this.Controls.Add(this.lbfechaInicio);
            this.Controls.Add(this.lbcontentcodEquipo);
            this.Controls.Add(this.lbcodEquipo);
            this.Controls.Add(this.lbcontentDNINIE);
            this.Controls.Add(this.lbcodFutbolista);
            this.Controls.Add(this.lbcontentcodContrato);
            this.Controls.Add(this.lbcodContrato);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBorrarContratos";
            this.Text = "Borrar Contratos - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormBorrarContratos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lbcodContrato;
        private System.Windows.Forms.Label lbcontentcodContrato;
        private System.Windows.Forms.Label lbcodFutbolista;
        private System.Windows.Forms.Label lbcontentDNINIE;
        private System.Windows.Forms.Label lbcodEquipo;
        private System.Windows.Forms.Label lbcontentcodEquipo;
        private System.Windows.Forms.Label lbfechaInicio;
        private System.Windows.Forms.Label lbcontentfechaInicio;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbcontentFechaFin;
        private System.Windows.Forms.Label lbprecioAnual;
        private System.Windows.Forms.Label lbcontentPrecioAnual;
        private System.Windows.Forms.Label lbPrecioRecision;
        private System.Windows.Forms.Label lbcontentprecioRecision;
    }
}