namespace _1_SimpleForm
{
    partial class Form1
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
            this.Label_Bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Bienvenida
            // 
            this.Label_Bienvenida.AutoSize = true;
            this.Label_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Bienvenida.Location = new System.Drawing.Point(59, 70);
            this.Label_Bienvenida.Name = "Label_Bienvenida";
            this.Label_Bienvenida.Size = new System.Drawing.Size(671, 25);
            this.Label_Bienvenida.TabIndex = 0;
            this.Label_Bienvenida.Text = "¡Bienvenido al formulario de Idelfonso Peña | MT-2024-00222! ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 216);
            this.Controls.Add(this.Label_Bienvenida);
            this.Name = "Form1";
            this.Text = "Formulario simple de Bienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Bienvenida;
    }
}

