namespace _11_TimeDatePicker
{
    partial class TimeDatePicker
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
            this.DateTP_Origen = new System.Windows.Forms.DateTimePicker();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTP_Origen
            // 
            this.DateTP_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTP_Origen.Location = new System.Drawing.Point(33, 136);
            this.DateTP_Origen.Name = "DateTP_Origen";
            this.DateTP_Origen.Size = new System.Drawing.Size(303, 26);
            this.DateTP_Origen.TabIndex = 0;
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Location = new System.Drawing.Point(33, 66);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(99, 39);
            this.Btn_Enviar.TabIndex = 1;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(167, 81);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(25, 24);
            this.Label_Resultado.TabIndex = 2;
            this.Label_Resultado.Text = "...";
            // 
            // TimeDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 270);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.DateTP_Origen);
            this.Name = "TimeDatePicker";
            this.Text = "Mostrar la fecha en una etiqueta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTP_Origen;
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.Label Label_Resultado;
    }
}

