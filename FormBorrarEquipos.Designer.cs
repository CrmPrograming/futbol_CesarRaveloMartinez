
namespace futbol_CesarRaveloMartinez
{
    partial class FormBorrarEquipos
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
            this.lbcontentnomequipo = new System.Windows.Forms.Label();
            this.lbcontentcodliga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomEquipo = new System.Windows.Forms.Label();
            this.lbCodLiga = new System.Windows.Forms.Label();
            this.lbCodEquipo = new System.Windows.Forms.Label();
            this.lbcontentcodEquipo = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.lbcontentLocalidad = new System.Windows.Forms.Label();
            this.cbInternacional = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(294, 153);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 17;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btBorrar.Location = new System.Drawing.Point(375, 153);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 16;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Esta operación es irreversible. ¿Desea continuar?";
            // 
            // lbcontentnomequipo
            // 
            this.lbcontentnomequipo.AutoSize = true;
            this.lbcontentnomequipo.Location = new System.Drawing.Point(129, 68);
            this.lbcontentnomequipo.Name = "lbcontentnomequipo";
            this.lbcontentnomequipo.Size = new System.Drawing.Size(35, 13);
            this.lbcontentnomequipo.TabIndex = 14;
            this.lbcontentnomequipo.Text = "label2";
            // 
            // lbcontentcodliga
            // 
            this.lbcontentcodliga.AutoSize = true;
            this.lbcontentcodliga.Location = new System.Drawing.Point(275, 42);
            this.lbcontentcodliga.Name = "lbcontentcodliga";
            this.lbcontentcodliga.Size = new System.Drawing.Size(35, 13);
            this.lbcontentcodliga.TabIndex = 13;
            this.lbcontentcodliga.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Se va a borrar el equipo con los siguientes datos:";
            // 
            // lbNomEquipo
            // 
            this.lbNomEquipo.AutoSize = true;
            this.lbNomEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomEquipo.Location = new System.Drawing.Point(13, 68);
            this.lbNomEquipo.Name = "lbNomEquipo";
            this.lbNomEquipo.Size = new System.Drawing.Size(115, 13);
            this.lbNomEquipo.TabIndex = 11;
            this.lbNomEquipo.Text = "Nombre de Equipo:";
            // 
            // lbCodLiga
            // 
            this.lbCodLiga.AutoSize = true;
            this.lbCodLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodLiga.Location = new System.Drawing.Point(179, 42);
            this.lbCodLiga.Name = "lbCodLiga";
            this.lbCodLiga.Size = new System.Drawing.Size(96, 13);
            this.lbCodLiga.TabIndex = 10;
            this.lbCodLiga.Text = "Código de Liga:";
            // 
            // lbCodEquipo
            // 
            this.lbCodEquipo.AutoSize = true;
            this.lbCodEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodEquipo.Location = new System.Drawing.Point(13, 42);
            this.lbCodEquipo.Name = "lbCodEquipo";
            this.lbCodEquipo.Size = new System.Drawing.Size(111, 13);
            this.lbCodEquipo.TabIndex = 18;
            this.lbCodEquipo.Text = "Código de Equipo:";
            // 
            // lbcontentcodEquipo
            // 
            this.lbcontentcodEquipo.AutoSize = true;
            this.lbcontentcodEquipo.Location = new System.Drawing.Point(129, 42);
            this.lbcontentcodEquipo.Name = "lbcontentcodEquipo";
            this.lbcontentcodEquipo.Size = new System.Drawing.Size(35, 13);
            this.lbcontentcodEquipo.TabIndex = 19;
            this.lbcontentcodEquipo.Text = "label3";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.Location = new System.Drawing.Point(13, 96);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(66, 13);
            this.lbLocalidad.TabIndex = 20;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // lbcontentLocalidad
            // 
            this.lbcontentLocalidad.AutoSize = true;
            this.lbcontentLocalidad.Location = new System.Drawing.Point(86, 95);
            this.lbcontentLocalidad.Name = "lbcontentLocalidad";
            this.lbcontentLocalidad.Size = new System.Drawing.Size(35, 13);
            this.lbcontentLocalidad.TabIndex = 21;
            this.lbcontentLocalidad.Text = "label3";
            // 
            // cbInternacional
            // 
            this.cbInternacional.AutoSize = true;
            this.cbInternacional.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbInternacional.Enabled = false;
            this.cbInternacional.Location = new System.Drawing.Point(352, 42);
            this.cbInternacional.Name = "cbInternacional";
            this.cbInternacional.Size = new System.Drawing.Size(98, 31);
            this.cbInternacional.TabIndex = 22;
            this.cbInternacional.Text = "¿Es internacional?";
            this.cbInternacional.UseVisualStyleBackColor = true;
            // 
            // FormBorrarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 187);
            this.Controls.Add(this.cbInternacional);
            this.Controls.Add(this.lbcontentLocalidad);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.lbcontentcodEquipo);
            this.Controls.Add(this.lbCodEquipo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbcontentnomequipo);
            this.Controls.Add(this.lbcontentcodliga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNomEquipo);
            this.Controls.Add(this.lbCodLiga);
            this.Name = "FormBorrarEquipos";
            this.Text = "Borrar Equipo - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormBorrarEquipos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcontentnomequipo;
        private System.Windows.Forms.Label lbcontentcodliga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNomEquipo;
        private System.Windows.Forms.Label lbCodLiga;
        private System.Windows.Forms.Label lbCodEquipo;
        private System.Windows.Forms.Label lbcontentcodEquipo;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.Label lbcontentLocalidad;
        private System.Windows.Forms.CheckBox cbInternacional;
    }
}