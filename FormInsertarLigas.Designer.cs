
namespace futbol_CesarRaveloMartinez
{
    partial class FormInsertarLigas
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
            this.lbCodLiga = new System.Windows.Forms.Label();
            this.tbCodLiga = new System.Windows.Forms.TextBox();
            this.tbNomLiga = new System.Windows.Forms.TextBox();
            this.lbNomLiga = new System.Windows.Forms.Label();
            this.btCrear = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodLiga
            // 
            this.lbCodLiga.AutoSize = true;
            this.lbCodLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodLiga.Location = new System.Drawing.Point(13, 13);
            this.lbCodLiga.Name = "lbCodLiga";
            this.lbCodLiga.Size = new System.Drawing.Size(150, 13);
            this.lbCodLiga.TabIndex = 0;
            this.lbCodLiga.Text = "Código de Liga (5 letras):";
            // 
            // tbCodLiga
            // 
            this.tbCodLiga.Location = new System.Drawing.Point(16, 30);
            this.tbCodLiga.Name = "tbCodLiga";
            this.tbCodLiga.Size = new System.Drawing.Size(147, 20);
            this.tbCodLiga.TabIndex = 1;
            // 
            // tbNomLiga
            // 
            this.tbNomLiga.Location = new System.Drawing.Point(16, 79);
            this.tbNomLiga.Name = "tbNomLiga";
            this.tbNomLiga.Size = new System.Drawing.Size(231, 20);
            this.tbNomLiga.TabIndex = 3;
            // 
            // lbNomLiga
            // 
            this.lbNomLiga.AutoSize = true;
            this.lbNomLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomLiga.Location = new System.Drawing.Point(13, 63);
            this.lbNomLiga.Name = "lbNomLiga";
            this.lbNomLiga.Size = new System.Drawing.Size(152, 13);
            this.lbNomLiga.TabIndex = 2;
            this.lbNomLiga.Text = "Nombre de Liga (max 50):";
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCrear.Location = new System.Drawing.Point(374, 155);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 4;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(293, 155);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormInsertarLigas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 190);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.tbNomLiga);
            this.Controls.Add(this.lbNomLiga);
            this.Controls.Add(this.tbCodLiga);
            this.Controls.Add(this.lbCodLiga);
            this.Name = "FormInsertarLigas";
            this.Text = "Insertar nueva liga - César Ravelo Martínez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodLiga;
        private System.Windows.Forms.TextBox tbCodLiga;
        private System.Windows.Forms.TextBox tbNomLiga;
        private System.Windows.Forms.Label lbNomLiga;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btCancelar;
    }
}