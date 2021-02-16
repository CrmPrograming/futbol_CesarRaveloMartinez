
namespace futbol_CesarRaveloMartinez
{
    partial class FormModificarLigas
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
            this.tbNomLiga = new System.Windows.Forms.TextBox();
            this.lbNomLiga = new System.Windows.Forms.Label();
            this.tbCodLiga = new System.Windows.Forms.TextBox();
            this.lbCodLiga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(307, 153);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btActualizar.Location = new System.Drawing.Point(388, 153);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 6;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // tbNomLiga
            // 
            this.tbNomLiga.Location = new System.Drawing.Point(12, 78);
            this.tbNomLiga.Name = "tbNomLiga";
            this.tbNomLiga.Size = new System.Drawing.Size(231, 20);
            this.tbNomLiga.TabIndex = 11;
            // 
            // lbNomLiga
            // 
            this.lbNomLiga.AutoSize = true;
            this.lbNomLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomLiga.Location = new System.Drawing.Point(9, 62);
            this.lbNomLiga.Name = "lbNomLiga";
            this.lbNomLiga.Size = new System.Drawing.Size(152, 13);
            this.lbNomLiga.TabIndex = 10;
            this.lbNomLiga.Text = "Nombre de Liga (max 50):";
            // 
            // tbCodLiga
            // 
            this.tbCodLiga.Enabled = false;
            this.tbCodLiga.Location = new System.Drawing.Point(12, 29);
            this.tbCodLiga.Name = "tbCodLiga";
            this.tbCodLiga.Size = new System.Drawing.Size(147, 20);
            this.tbCodLiga.TabIndex = 9;
            // 
            // lbCodLiga
            // 
            this.lbCodLiga.AutoSize = true;
            this.lbCodLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodLiga.Location = new System.Drawing.Point(9, 12);
            this.lbCodLiga.Name = "lbCodLiga";
            this.lbCodLiga.Size = new System.Drawing.Size(96, 13);
            this.lbCodLiga.TabIndex = 8;
            this.lbCodLiga.Text = "Código de Liga:";
            // 
            // FormModificarLigas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 188);
            this.Controls.Add(this.tbNomLiga);
            this.Controls.Add(this.lbNomLiga);
            this.Controls.Add(this.tbCodLiga);
            this.Controls.Add(this.lbCodLiga);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btActualizar);
            this.Name = "FormModificarLigas";
            this.Text = "Modificar liga - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormModificarLigas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox tbNomLiga;
        private System.Windows.Forms.Label lbNomLiga;
        private System.Windows.Forms.TextBox tbCodLiga;
        private System.Windows.Forms.Label lbCodLiga;
    }
}