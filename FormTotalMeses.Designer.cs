
namespace futbol_CesarRaveloMartinez
{
    partial class FormTotalMeses
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
            this.tbDNINIE = new System.Windows.Forms.TextBox();
            this.lbDNINIE = new System.Windows.Forms.Label();
            this.btConsulta = new System.Windows.Forms.Button();
            this.lbTotalMeses = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDNINIE
            // 
            this.tbDNINIE.Location = new System.Drawing.Point(15, 26);
            this.tbDNINIE.Name = "tbDNINIE";
            this.tbDNINIE.Size = new System.Drawing.Size(127, 20);
            this.tbDNINIE.TabIndex = 3;
            // 
            // lbDNINIE
            // 
            this.lbDNINIE.AutoSize = true;
            this.lbDNINIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNINIE.Location = new System.Drawing.Point(12, 9);
            this.lbDNINIE.Name = "lbDNINIE";
            this.lbDNINIE.Size = new System.Drawing.Size(245, 13);
            this.lbDNINIE.TabIndex = 2;
            this.lbDNINIE.Text = "Código de DNI o NIE (9 letras y números):";
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(264, 23);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(103, 23);
            this.btConsulta.TabIndex = 4;
            this.btConsulta.Text = "Realizar Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // lbTotalMeses
            // 
            this.lbTotalMeses.AutoSize = true;
            this.lbTotalMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMeses.Location = new System.Drawing.Point(15, 70);
            this.lbTotalMeses.Name = "lbTotalMeses";
            this.lbTotalMeses.Size = new System.Drawing.Size(97, 13);
            this.lbTotalMeses.TabIndex = 5;
            this.lbTotalMeses.Text = "Total de meses:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(118, 70);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(174, 13);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Indique el dni o nie de un futbolista.";
            // 
            // FormTotalMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 113);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbTotalMeses);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.tbDNINIE);
            this.Controls.Add(this.lbDNINIE);
            this.Name = "FormTotalMeses";
            this.Text = "Total de meses en activo - César Ravelo Martínez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDNINIE;
        private System.Windows.Forms.Label lbDNINIE;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Label lbTotalMeses;
        private System.Windows.Forms.Label lbResult;
    }
}