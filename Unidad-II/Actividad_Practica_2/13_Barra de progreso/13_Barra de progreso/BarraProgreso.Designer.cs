namespace _13_Barra_de_progreso
{
    partial class BarraProgreso
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
            this.components = new System.ComponentModel.Container();
            this.ProBar_Objetivo = new System.Windows.Forms.ProgressBar();
            this.Btn_Progreso = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProBar_Objetivo
            // 
            this.ProBar_Objetivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProBar_Objetivo.Location = new System.Drawing.Point(21, 58);
            this.ProBar_Objetivo.Name = "ProBar_Objetivo";
            this.ProBar_Objetivo.Size = new System.Drawing.Size(379, 57);
            this.ProBar_Objetivo.TabIndex = 0;
            // 
            // Btn_Progreso
            // 
            this.Btn_Progreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Progreso.Location = new System.Drawing.Point(440, 58);
            this.Btn_Progreso.Name = "Btn_Progreso";
            this.Btn_Progreso.Size = new System.Drawing.Size(172, 57);
            this.Btn_Progreso.TabIndex = 1;
            this.Btn_Progreso.Text = "Iniciar";
            this.Btn_Progreso.UseVisualStyleBackColor = true;
            this.Btn_Progreso.Click += new System.EventHandler(this.Btn_Progreso_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BarraProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 203);
            this.Controls.Add(this.Btn_Progreso);
            this.Controls.Add(this.ProBar_Objetivo);
            this.Name = "BarraProgreso";
            this.Text = "Barra de progeso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProBar_Objetivo;
        private System.Windows.Forms.Button Btn_Progreso;
        private System.Windows.Forms.Timer timer1;
    }
}

