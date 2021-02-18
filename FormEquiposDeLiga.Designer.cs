
namespace futbol_CesarRaveloMartinez
{
    partial class FormEquiposDeLiga
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
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.cbLiga = new System.Windows.Forms.ComboBox();
            this.dataGridViewContenido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(13, 13);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(252, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Seleccione una liga para ver sus equipos asociados";
            // 
            // cbLiga
            // 
            this.cbLiga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLiga.FormattingEnabled = true;
            this.cbLiga.Location = new System.Drawing.Point(16, 30);
            this.cbLiga.Name = "cbLiga";
            this.cbLiga.Size = new System.Drawing.Size(249, 21);
            this.cbLiga.TabIndex = 1;
            this.cbLiga.SelectedIndexChanged += new System.EventHandler(this.cbLiga_SelectedIndexChanged);
            // 
            // dataGridViewContenido
            // 
            this.dataGridViewContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContenido.Location = new System.Drawing.Point(16, 57);
            this.dataGridViewContenido.Name = "dataGridViewContenido";
            this.dataGridViewContenido.ReadOnly = true;
            this.dataGridViewContenido.Size = new System.Drawing.Size(563, 273);
            this.dataGridViewContenido.TabIndex = 2;
            // 
            // FormEquiposDeLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 341);
            this.Controls.Add(this.dataGridViewContenido);
            this.Controls.Add(this.cbLiga);
            this.Controls.Add(this.lbDescripcion);
            this.Name = "FormEquiposDeLiga";
            this.Text = "Ver equipos pertenecientes a una liga - César Ravelo Martínez";
            this.Load += new System.EventHandler(this.FormEquiposDeLiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.ComboBox cbLiga;
        private System.Windows.Forms.DataGridView dataGridViewContenido;
    }
}