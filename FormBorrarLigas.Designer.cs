
namespace futbol_CesarRaveloMartinez
{
    partial class FormBorrarLigas
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
            this.lbNomLiga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcontentcodliga = new System.Windows.Forms.Label();
            this.lbcontentnomliga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodLiga
            // 
            this.lbCodLiga.AutoSize = true;
            this.lbCodLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodLiga.Location = new System.Drawing.Point(12, 44);
            this.lbCodLiga.Name = "lbCodLiga";
            this.lbCodLiga.Size = new System.Drawing.Size(96, 13);
            this.lbCodLiga.TabIndex = 1;
            this.lbCodLiga.Text = "Código de Liga:";
            // 
            // lbNomLiga
            // 
            this.lbNomLiga.AutoSize = true;
            this.lbNomLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomLiga.Location = new System.Drawing.Point(12, 70);
            this.lbNomLiga.Name = "lbNomLiga";
            this.lbNomLiga.Size = new System.Drawing.Size(100, 13);
            this.lbNomLiga.TabIndex = 3;
            this.lbNomLiga.Text = "Nombre de Liga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Se va a borrar la liga con los siguientes datos:";
            // 
            // lbcontentcodliga
            // 
            this.lbcontentcodliga.AutoSize = true;
            this.lbcontentcodliga.Location = new System.Drawing.Point(115, 44);
            this.lbcontentcodliga.Name = "lbcontentcodliga";
            this.lbcontentcodliga.Size = new System.Drawing.Size(35, 13);
            this.lbcontentcodliga.TabIndex = 5;
            this.lbcontentcodliga.Text = "label2";
            // 
            // lbcontentnomliga
            // 
            this.lbcontentnomliga.AutoSize = true;
            this.lbcontentnomliga.Location = new System.Drawing.Point(118, 70);
            this.lbcontentnomliga.Name = "lbcontentnomliga";
            this.lbcontentnomliga.Size = new System.Drawing.Size(35, 13);
            this.lbcontentnomliga.TabIndex = 6;
            this.lbcontentnomliga.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Esta operación es irreversible. ¿Desea continuar?";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.Location = new System.Drawing.Point(293, 155);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btBorrar.Location = new System.Drawing.Point(374, 155);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 8;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // FormBorrarLigas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 190);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbcontentnomliga);
            this.Controls.Add(this.lbcontentcodliga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNomLiga);
            this.Controls.Add(this.lbCodLiga);
            this.Name = "FormBorrarLigas";
            this.Text = "Borrar Liga - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormBorrarLigas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodLiga;
        private System.Windows.Forms.Label lbNomLiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcontentcodliga;
        private System.Windows.Forms.Label lbcontentnomliga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBorrar;
    }
}