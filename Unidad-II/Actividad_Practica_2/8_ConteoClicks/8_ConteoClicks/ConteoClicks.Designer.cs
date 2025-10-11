namespace _8_ConteoClicks
{
    partial class ConteoClicks
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
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.Btn_Objetivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(290, 117);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(33, 25);
            this.Label_Resultado.TabIndex = 0;
            this.Label_Resultado.Text = "...";
            // 
            // Btn_Objetivo
            // 
            this.Btn_Objetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Objetivo.Location = new System.Drawing.Point(69, 88);
            this.Btn_Objetivo.Name = "Btn_Objetivo";
            this.Btn_Objetivo.Size = new System.Drawing.Size(121, 54);
            this.Btn_Objetivo.TabIndex = 1;
            this.Btn_Objetivo.Text = "Presioname";
            this.Btn_Objetivo.UseVisualStyleBackColor = true;
            this.Btn_Objetivo.Click += new System.EventHandler(this.Btn_Objetivo_Click);
            // 
            // ConteoClicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 251);
            this.Controls.Add(this.Btn_Objetivo);
            this.Controls.Add(this.Label_Resultado);
            this.Name = "ConteoClicks";
            this.Text = "Conteo de clicks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Resultado;
        private System.Windows.Forms.Button Btn_Objetivo;
    }
}

