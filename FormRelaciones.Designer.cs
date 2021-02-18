
namespace futbol_CesarRaveloMartinez
{
    partial class FormRelaciones
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
            this.dataGridViewChildContent = new System.Windows.Forms.DataGridView();
            this.lbCodLiga = new System.Windows.Forms.Label();
            this.lbResultCodLiga = new System.Windows.Forms.Label();
            this.lbResultNomLiga = new System.Windows.Forms.Label();
            this.lbNomLiga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildContent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChildContent
            // 
            this.dataGridViewChildContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChildContent.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewChildContent.Name = "dataGridViewChildContent";
            this.dataGridViewChildContent.Size = new System.Drawing.Size(776, 392);
            this.dataGridViewChildContent.TabIndex = 0;
            // 
            // lbCodLiga
            // 
            this.lbCodLiga.AutoSize = true;
            this.lbCodLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodLiga.Location = new System.Drawing.Point(12, 13);
            this.lbCodLiga.Name = "lbCodLiga";
            this.lbCodLiga.Size = new System.Drawing.Size(96, 13);
            this.lbCodLiga.TabIndex = 1;
            this.lbCodLiga.Text = "Código de Liga:";
            // 
            // lbResultCodLiga
            // 
            this.lbResultCodLiga.AutoSize = true;
            this.lbResultCodLiga.Location = new System.Drawing.Point(114, 13);
            this.lbResultCodLiga.Name = "lbResultCodLiga";
            this.lbResultCodLiga.Size = new System.Drawing.Size(45, 13);
            this.lbResultCodLiga.TabIndex = 2;
            this.lbResultCodLiga.Text = "codLiga";
            // 
            // lbResultNomLiga
            // 
            this.lbResultNomLiga.AutoSize = true;
            this.lbResultNomLiga.Location = new System.Drawing.Point(325, 13);
            this.lbResultNomLiga.Name = "lbResultNomLiga";
            this.lbResultNomLiga.Size = new System.Drawing.Size(47, 13);
            this.lbResultNomLiga.TabIndex = 4;
            this.lbResultNomLiga.Text = "nomLiga";
            // 
            // lbNomLiga
            // 
            this.lbNomLiga.AutoSize = true;
            this.lbNomLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomLiga.Location = new System.Drawing.Point(223, 13);
            this.lbNomLiga.Name = "lbNomLiga";
            this.lbNomLiga.Size = new System.Drawing.Size(100, 13);
            this.lbNomLiga.TabIndex = 3;
            this.lbNomLiga.Text = "Nombre de Liga:";
            // 
            // FormRelaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultNomLiga);
            this.Controls.Add(this.lbNomLiga);
            this.Controls.Add(this.lbResultCodLiga);
            this.Controls.Add(this.lbCodLiga);
            this.Controls.Add(this.dataGridViewChildContent);
            this.Name = "FormRelaciones";
            this.Text = "Datos relacionados al seleccionado - César Ravelo Martínez";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChildContent;
        private System.Windows.Forms.Label lbCodLiga;
        private System.Windows.Forms.Label lbResultCodLiga;
        private System.Windows.Forms.Label lbResultNomLiga;
        private System.Windows.Forms.Label lbNomLiga;
    }
}