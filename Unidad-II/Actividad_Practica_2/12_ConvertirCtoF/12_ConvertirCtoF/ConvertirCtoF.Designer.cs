namespace _12_ConvertirCtoF
{
    partial class ConvertirCtoF
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
            this.TxtBox_C = new System.Windows.Forms.TextBox();
            this.Label_Tit = new System.Windows.Forms.Label();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_C
            // 
            this.TxtBox_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_C.Location = new System.Drawing.Point(36, 84);
            this.TxtBox_C.Name = "TxtBox_C";
            this.TxtBox_C.Size = new System.Drawing.Size(134, 29);
            this.TxtBox_C.TabIndex = 0;
            // 
            // Label_Tit
            // 
            this.Label_Tit.AutoSize = true;
            this.Label_Tit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tit.Location = new System.Drawing.Point(32, 27);
            this.Label_Tit.Name = "Label_Tit";
            this.Label_Tit.Size = new System.Drawing.Size(323, 20);
            this.Label_Tit.TabIndex = 1;
            this.Label_Tit.Text = "Indique la temperatura en Celcius a convertir";
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calcular.Location = new System.Drawing.Point(247, 77);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(108, 36);
            this.Btn_Calcular.TabIndex = 2;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(405, 87);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(25, 24);
            this.Label_Resultado.TabIndex = 3;
            this.Label_Resultado.Text = "...";
            // 
            // ConvertirCtoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 179);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Label_Tit);
            this.Controls.Add(this.TxtBox_C);
            this.Name = "ConvertirCtoF";
            this.Text = "Convertir de Celsius a Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_C;
        private System.Windows.Forms.Label Label_Tit;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Label Label_Resultado;
    }
}

