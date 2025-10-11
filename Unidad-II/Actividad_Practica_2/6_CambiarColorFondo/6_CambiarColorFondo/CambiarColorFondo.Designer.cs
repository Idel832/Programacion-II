namespace _6_CambiarColorFondo
{
    partial class CambiarColorFondo
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
            this.CBox_Seleccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBox_Seleccion
            // 
            this.CBox_Seleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Seleccion.FormattingEnabled = true;
            this.CBox_Seleccion.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul"});
            this.CBox_Seleccion.Location = new System.Drawing.Point(49, 73);
            this.CBox_Seleccion.Name = "CBox_Seleccion";
            this.CBox_Seleccion.Size = new System.Drawing.Size(203, 32);
            this.CBox_Seleccion.TabIndex = 0;
            this.CBox_Seleccion.SelectedIndexChanged += new System.EventHandler(this.CBox_Seleccion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona un color";
            // 
            // CambiarColorFondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBox_Seleccion);
            this.Name = "CambiarColorFondo";
            this.Text = "Cambiar color de fondo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBox_Seleccion;
        private System.Windows.Forms.Label label1;
    }
}

