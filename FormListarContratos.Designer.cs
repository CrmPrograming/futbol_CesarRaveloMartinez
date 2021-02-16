
namespace futbol_CesarRaveloMartinez
{
    partial class FormListarContratos
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDNINIE
            // 
            this.tbDNINIE.Location = new System.Drawing.Point(12, 32);
            this.tbDNINIE.Name = "tbDNINIE";
            this.tbDNINIE.Size = new System.Drawing.Size(127, 20);
            this.tbDNINIE.TabIndex = 3;
            // 
            // lbDNINIE
            // 
            this.lbDNINIE.AutoSize = true;
            this.lbDNINIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNINIE.Location = new System.Drawing.Point(9, 15);
            this.lbDNINIE.Name = "lbDNINIE";
            this.lbDNINIE.Size = new System.Drawing.Size(245, 13);
            this.lbDNINIE.TabIndex = 2;
            this.lbDNINIE.Text = "Código de DNI o NIE (9 letras y números):";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(583, 274);
            this.dataGridView.TabIndex = 4;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(145, 31);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // FormListarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 344);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tbDNINIE);
            this.Controls.Add(this.lbDNINIE);
            this.Name = "FormListarContratos";
            this.Text = "Listar contratos de futbolista - César Ravelo Martínez";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDNINIE;
        private System.Windows.Forms.Label lbDNINIE;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btConsultar;
    }
}