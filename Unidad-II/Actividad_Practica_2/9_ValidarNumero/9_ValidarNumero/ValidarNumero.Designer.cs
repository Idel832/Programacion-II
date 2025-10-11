namespace _9_ValidarNumero
{
    partial class ValidarNumero
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
            this.TxtBox_Contenido = new System.Windows.Forms.TextBox();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_Contenido
            // 
            this.TxtBox_Contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Contenido.Location = new System.Drawing.Point(42, 58);
            this.TxtBox_Contenido.Name = "TxtBox_Contenido";
            this.TxtBox_Contenido.Size = new System.Drawing.Size(223, 29);
            this.TxtBox_Contenido.TabIndex = 0;
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validar.Location = new System.Drawing.Point(317, 53);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(106, 43);
            this.Btn_Validar.TabIndex = 1;
            this.Btn_Validar.Text = "Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // ValidarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 170);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.TxtBox_Contenido);
            this.Name = "ValidarNumero";
            this.Text = "Validar si es un numero o no";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Contenido;
        private System.Windows.Forms.Button Btn_Validar;
    }
}

