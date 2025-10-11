namespace _4_SumaBasica
{
    partial class SumaBasica
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
            this.Btn_Sumar = new System.Windows.Forms.Button();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.TxtBox_Num1 = new System.Windows.Forms.TextBox();
            this.TxtBox_Num2 = new System.Windows.Forms.TextBox();
            this.Label_Simbolo_Suma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Sumar
            // 
            this.Btn_Sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sumar.Location = new System.Drawing.Point(107, 166);
            this.Btn_Sumar.Name = "Btn_Sumar";
            this.Btn_Sumar.Size = new System.Drawing.Size(100, 37);
            this.Btn_Sumar.TabIndex = 0;
            this.Btn_Sumar.Text = "Sumar";
            this.Btn_Sumar.UseVisualStyleBackColor = true;
            this.Btn_Sumar.Click += new System.EventHandler(this.Btn_Sumar_Click);
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(328, 170);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(25, 24);
            this.Label_Resultado.TabIndex = 1;
            this.Label_Resultado.Text = "...";
            // 
            // TxtBox_Num1
            // 
            this.TxtBox_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Num1.Location = new System.Drawing.Point(107, 86);
            this.TxtBox_Num1.Name = "TxtBox_Num1";
            this.TxtBox_Num1.Size = new System.Drawing.Size(100, 29);
            this.TxtBox_Num1.TabIndex = 2;
            // 
            // TxtBox_Num2
            // 
            this.TxtBox_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Num2.Location = new System.Drawing.Point(293, 86);
            this.TxtBox_Num2.Name = "TxtBox_Num2";
            this.TxtBox_Num2.Size = new System.Drawing.Size(100, 29);
            this.TxtBox_Num2.TabIndex = 3;
            // 
            // Label_Simbolo_Suma
            // 
            this.Label_Simbolo_Suma.AutoSize = true;
            this.Label_Simbolo_Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Simbolo_Suma.Location = new System.Drawing.Point(237, 89);
            this.Label_Simbolo_Suma.Name = "Label_Simbolo_Suma";
            this.Label_Simbolo_Suma.Size = new System.Drawing.Size(21, 24);
            this.Label_Simbolo_Suma.TabIndex = 4;
            this.Label_Simbolo_Suma.Text = "+";
            // 
            // SumaBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 302);
            this.Controls.Add(this.Label_Simbolo_Suma);
            this.Controls.Add(this.TxtBox_Num2);
            this.Controls.Add(this.TxtBox_Num1);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.Btn_Sumar);
            this.Name = "SumaBasica";
            this.Text = "Suma basica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sumar;
        private System.Windows.Forms.Label Label_Resultado;
        private System.Windows.Forms.TextBox TxtBox_Num1;
        private System.Windows.Forms.TextBox TxtBox_Num2;
        private System.Windows.Forms.Label Label_Simbolo_Suma;
    }
}

