﻿
namespace futbol_CesarRaveloMartinez
{
    partial class FormProcedimientoInsertarEquipo
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
            this.btCrear = new System.Windows.Forms.Button();
            this.checkBInternacional = new System.Windows.Forms.CheckBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLiga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(294, 149);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCrear.Location = new System.Drawing.Point(375, 149);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 17;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // checkBInternacional
            // 
            this.checkBInternacional.AutoSize = true;
            this.checkBInternacional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBInternacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBInternacional.Location = new System.Drawing.Point(256, 90);
            this.checkBInternacional.Name = "checkBInternacional";
            this.checkBInternacional.Size = new System.Drawing.Size(131, 17);
            this.checkBInternacional.TabIndex = 16;
            this.checkBInternacional.Text = "¿Es internacional?";
            this.checkBInternacional.UseVisualStyleBackColor = true;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(15, 87);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(210, 20);
            this.tbLocalidad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Localidad (hasta 60 letras):";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(15, 34);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(210, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(12, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(213, 13);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Nombre del equipo (hasta 40 letras):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código de Liga";
            // 
            // cbLiga
            // 
            this.cbLiga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLiga.FormattingEnabled = true;
            this.cbLiga.Location = new System.Drawing.Point(256, 33);
            this.cbLiga.Name = "cbLiga";
            this.cbLiga.Size = new System.Drawing.Size(194, 21);
            this.cbLiga.TabIndex = 10;
            // 
            // FormProcedimientoInsertarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 184);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.checkBInternacional);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLiga);
            this.Name = "FormProcedimientoInsertarEquipo";
            this.Text = "Insertar nuevo equipo - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormProcedimientoInsertarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.CheckBox checkBInternacional;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLiga;
    }
}