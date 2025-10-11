namespace _2_CambiarLabel
{
    partial class CambiarLabel
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
            this.Btn_Cambiar = new System.Windows.Forms.Button();
            this.Label_Objetivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Cambiar
            // 
            this.Btn_Cambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cambiar.Location = new System.Drawing.Point(29, 31);
            this.Btn_Cambiar.Name = "Btn_Cambiar";
            this.Btn_Cambiar.Size = new System.Drawing.Size(132, 44);
            this.Btn_Cambiar.TabIndex = 0;
            this.Btn_Cambiar.Text = "Cambiar texto";
            this.Btn_Cambiar.UseVisualStyleBackColor = true;
            this.Btn_Cambiar.Click += new System.EventHandler(this.Btn_Cambiar_Click);
            // 
            // Label_Objetivo
            // 
            this.Label_Objetivo.AutoSize = true;
            this.Label_Objetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Objetivo.Location = new System.Drawing.Point(24, 137);
            this.Label_Objetivo.Name = "Label_Objetivo";
            this.Label_Objetivo.Size = new System.Drawing.Size(186, 25);
            this.Label_Objetivo.TabIndex = 1;
            this.Label_Objetivo.Text = "Presiona el botón!";
            // 
            // CambiarLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 244);
            this.Controls.Add(this.Label_Objetivo);
            this.Controls.Add(this.Btn_Cambiar);
            this.Name = "CambiarLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cambiar;
        private System.Windows.Forms.Label Label_Objetivo;
    }
}

