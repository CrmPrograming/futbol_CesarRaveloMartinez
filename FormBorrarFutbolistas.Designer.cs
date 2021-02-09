
namespace futbol_CesarRaveloMartinez
{
    partial class FormBorrarFutbolistas
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
            this.btBorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDNINIE = new System.Windows.Forms.Label();
            this.lbcontentDNINIE = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbcontentNombre = new System.Windows.Forms.Label();
            this.lbcontentLocalidad = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(292, 158);
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
            this.btBorrar.Location = new System.Drawing.Point(373, 158);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Esta operación es irreversible. ¿Desea continuar?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Se va a borrar el futbolista con los siguientes datos:";
            // 
            // lbDNINIE
            // 
            this.lbDNINIE.AutoSize = true;
            this.lbDNINIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNINIE.Location = new System.Drawing.Point(12, 37);
            this.lbDNINIE.Name = "lbDNINIE";
            this.lbDNINIE.Size = new System.Drawing.Size(130, 13);
            this.lbDNINIE.TabIndex = 14;
            this.lbDNINIE.Text = "Código de DNI o NIE:";
            // 
            // lbcontentDNINIE
            // 
            this.lbcontentDNINIE.AutoSize = true;
            this.lbcontentDNINIE.Location = new System.Drawing.Point(148, 37);
            this.lbcontentDNINIE.Name = "lbcontentDNINIE";
            this.lbcontentDNINIE.Size = new System.Drawing.Size(35, 13);
            this.lbcontentDNINIE.TabIndex = 15;
            this.lbcontentDNINIE.Text = "label3";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(12, 60);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbcontentNombre
            // 
            this.lbcontentNombre.AutoSize = true;
            this.lbcontentNombre.Location = new System.Drawing.Point(72, 60);
            this.lbcontentNombre.Name = "lbcontentNombre";
            this.lbcontentNombre.Size = new System.Drawing.Size(35, 13);
            this.lbcontentNombre.TabIndex = 17;
            this.lbcontentNombre.Text = "label3";
            // 
            // lbcontentLocalidad
            // 
            this.lbcontentLocalidad.AutoSize = true;
            this.lbcontentLocalidad.Location = new System.Drawing.Point(84, 83);
            this.lbcontentLocalidad.Name = "lbcontentLocalidad";
            this.lbcontentLocalidad.Size = new System.Drawing.Size(35, 13);
            this.lbcontentLocalidad.TabIndex = 19;
            this.lbcontentLocalidad.Text = "label3";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.Location = new System.Drawing.Point(12, 83);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(66, 13);
            this.lbLocalidad.TabIndex = 18;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // FormBorrarFutbolistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 193);
            this.Controls.Add(this.lbcontentLocalidad);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.lbcontentNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbcontentDNINIE);
            this.Controls.Add(this.lbDNINIE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBorrar);
            this.Name = "FormBorrarFutbolistas";
            this.Text = "Borrar Futbolista - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormBorrarFutbolistas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDNINIE;
        private System.Windows.Forms.Label lbcontentDNINIE;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbcontentNombre;
        private System.Windows.Forms.Label lbcontentLocalidad;
        private System.Windows.Forms.Label lbLocalidad;
    }
}