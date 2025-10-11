namespace _5_MostrarSelección
{
    partial class MostrarSelección
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
            this.RBtn_A = new System.Windows.Forms.RadioButton();
            this.RBtn_B = new System.Windows.Forms.RadioButton();
            this.RBtn_C = new System.Windows.Forms.RadioButton();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.Btn_Verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RBtn_A
            // 
            this.RBtn_A.AutoSize = true;
            this.RBtn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_A.Location = new System.Drawing.Point(25, 41);
            this.RBtn_A.Name = "RBtn_A";
            this.RBtn_A.Size = new System.Drawing.Size(42, 28);
            this.RBtn_A.TabIndex = 0;
            this.RBtn_A.TabStop = true;
            this.RBtn_A.Text = "A";
            this.RBtn_A.UseVisualStyleBackColor = true;
            // 
            // RBtn_B
            // 
            this.RBtn_B.AutoSize = true;
            this.RBtn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_B.Location = new System.Drawing.Point(25, 83);
            this.RBtn_B.Name = "RBtn_B";
            this.RBtn_B.Size = new System.Drawing.Size(41, 28);
            this.RBtn_B.TabIndex = 1;
            this.RBtn_B.TabStop = true;
            this.RBtn_B.Text = "B";
            this.RBtn_B.UseVisualStyleBackColor = true;
            // 
            // RBtn_C
            // 
            this.RBtn_C.AutoSize = true;
            this.RBtn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_C.Location = new System.Drawing.Point(25, 126);
            this.RBtn_C.Name = "RBtn_C";
            this.RBtn_C.Size = new System.Drawing.Size(42, 28);
            this.RBtn_C.TabIndex = 2;
            this.RBtn_C.TabStop = true;
            this.RBtn_C.Text = "C";
            this.RBtn_C.UseVisualStyleBackColor = true;
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(303, 87);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(25, 24);
            this.Label_Resultado.TabIndex = 3;
            this.Label_Resultado.Text = "...";
            // 
            // Btn_Verificar
            // 
            this.Btn_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Verificar.Location = new System.Drawing.Point(107, 77);
            this.Btn_Verificar.Name = "Btn_Verificar";
            this.Btn_Verificar.Size = new System.Drawing.Size(100, 43);
            this.Btn_Verificar.TabIndex = 4;
            this.Btn_Verificar.Text = "Verificar";
            this.Btn_Verificar.UseVisualStyleBackColor = true;
            this.Btn_Verificar.Click += new System.EventHandler(this.Btn_Verificar_Click);
            // 
            // MostrarSelección
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 217);
            this.Controls.Add(this.Btn_Verificar);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.RBtn_C);
            this.Controls.Add(this.RBtn_B);
            this.Controls.Add(this.RBtn_A);
            this.Name = "MostrarSelección";
            this.Text = "Mostrar que RadioButton fue selecionado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBtn_A;
        private System.Windows.Forms.RadioButton RBtn_B;
        private System.Windows.Forms.RadioButton RBtn_C;
        private System.Windows.Forms.Label Label_Resultado;
        private System.Windows.Forms.Button Btn_Verificar;
    }
}

