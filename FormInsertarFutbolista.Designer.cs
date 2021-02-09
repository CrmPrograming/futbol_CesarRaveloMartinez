
namespace futbol_CesarRaveloMartinez
{
    partial class FormInsertarFutbolista
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
            this.lbDNINIE = new System.Windows.Forms.Label();
            this.tbDNINIE = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNacionalidad = new System.Windows.Forms.Label();
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDNINIE
            // 
            this.lbDNINIE.AutoSize = true;
            this.lbDNINIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNINIE.Location = new System.Drawing.Point(13, 13);
            this.lbDNINIE.Name = "lbDNINIE";
            this.lbDNINIE.Size = new System.Drawing.Size(245, 13);
            this.lbDNINIE.TabIndex = 0;
            this.lbDNINIE.Text = "Código de DNI o NIE (9 letras y números):";
            // 
            // tbDNINIE
            // 
            this.tbDNINIE.Location = new System.Drawing.Point(16, 30);
            this.tbDNINIE.Name = "tbDNINIE";
            this.tbDNINIE.Size = new System.Drawing.Size(127, 20);
            this.tbDNINIE.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(13, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(227, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre del futbolista (hasta 40 letras):";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(16, 126);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(250, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // lbNacionalidad
            // 
            this.lbNacionalidad.AutoSize = true;
            this.lbNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNacionalidad.Location = new System.Drawing.Point(13, 61);
            this.lbNacionalidad.Name = "lbNacionalidad";
            this.lbNacionalidad.Size = new System.Drawing.Size(181, 13);
            this.lbNacionalidad.TabIndex = 4;
            this.lbNacionalidad.Text = "Nacionalidad (hasta 50 letras):";
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(16, 77);
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.Size = new System.Drawing.Size(250, 20);
            this.tbNacionalidad.TabIndex = 5;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(294, 157);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCrear.Location = new System.Drawing.Point(375, 157);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 6;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // FormInsertarFutbolista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 192);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.tbNacionalidad);
            this.Controls.Add(this.lbNacionalidad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbDNINIE);
            this.Controls.Add(this.lbDNINIE);
            this.Name = "FormInsertarFutbolista";
            this.Text = "Insertar nuevo futbolista - César Ravelo Martínez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDNINIE;
        private System.Windows.Forms.TextBox tbDNINIE;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNacionalidad;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCrear;
    }
}