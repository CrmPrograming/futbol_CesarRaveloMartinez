
namespace futbol_CesarRaveloMartinez
{
    partial class FormModificarFutbolistas
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
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.lbNacionalidad = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbDNINIE = new System.Windows.Forms.TextBox();
            this.lbDNINIE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(286, 153);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btActualizar.Location = new System.Drawing.Point(367, 153);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 14;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(8, 73);
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.Size = new System.Drawing.Size(250, 20);
            this.tbNacionalidad.TabIndex = 13;
            // 
            // lbNacionalidad
            // 
            this.lbNacionalidad.AutoSize = true;
            this.lbNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNacionalidad.Location = new System.Drawing.Point(5, 57);
            this.lbNacionalidad.Name = "lbNacionalidad";
            this.lbNacionalidad.Size = new System.Drawing.Size(181, 13);
            this.lbNacionalidad.TabIndex = 12;
            this.lbNacionalidad.Text = "Nacionalidad (hasta 50 letras):";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(8, 122);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(250, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(5, 106);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(227, 13);
            this.lbNombre.TabIndex = 10;
            this.lbNombre.Text = "Nombre del futbolista (hasta 40 letras):";
            // 
            // tbDNINIE
            // 
            this.tbDNINIE.Enabled = false;
            this.tbDNINIE.Location = new System.Drawing.Point(8, 26);
            this.tbDNINIE.Name = "tbDNINIE";
            this.tbDNINIE.Size = new System.Drawing.Size(127, 20);
            this.tbDNINIE.TabIndex = 9;
            // 
            // lbDNINIE
            // 
            this.lbDNINIE.AutoSize = true;
            this.lbDNINIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNINIE.Location = new System.Drawing.Point(5, 9);
            this.lbDNINIE.Name = "lbDNINIE";
            this.lbDNINIE.Size = new System.Drawing.Size(245, 13);
            this.lbDNINIE.TabIndex = 8;
            this.lbDNINIE.Text = "Código de DNI o NIE (9 letras y números):";
            // 
            // FormModificarFutbolistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 185);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.tbNacionalidad);
            this.Controls.Add(this.lbNacionalidad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbDNINIE);
            this.Controls.Add(this.lbDNINIE);
            this.Name = "FormModificarFutbolistas";
            this.Text = "Modificar futbolista - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormModificarFutbolistas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.Label lbNacionalidad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbDNINIE;
        private System.Windows.Forms.Label lbDNINIE;
    }
}