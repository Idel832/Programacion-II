namespace _3_EnviarContenidoBox
{
    partial class EnviarContenidoBox
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
            this.Label_Objetivo = new System.Windows.Forms.Label();
            this.TxtBox_Contenido = new System.Windows.Forms.TextBox();
            this.Btn_Accion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Objetivo
            // 
            this.Label_Objetivo.AutoSize = true;
            this.Label_Objetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Objetivo.Location = new System.Drawing.Point(36, 149);
            this.Label_Objetivo.Name = "Label_Objetivo";
            this.Label_Objetivo.Size = new System.Drawing.Size(25, 24);
            this.Label_Objetivo.TabIndex = 0;
            this.Label_Objetivo.Text = "...";
            // 
            // TxtBox_Contenido
            // 
            this.TxtBox_Contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Contenido.Location = new System.Drawing.Point(40, 57);
            this.TxtBox_Contenido.Name = "TxtBox_Contenido";
            this.TxtBox_Contenido.Size = new System.Drawing.Size(353, 26);
            this.TxtBox_Contenido.TabIndex = 1;
            // 
            // Btn_Accion
            // 
            this.Btn_Accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Accion.Location = new System.Drawing.Point(420, 48);
            this.Btn_Accion.Name = "Btn_Accion";
            this.Btn_Accion.Size = new System.Drawing.Size(132, 45);
            this.Btn_Accion.TabIndex = 2;
            this.Btn_Accion.Text = "Enviar";
            this.Btn_Accion.UseVisualStyleBackColor = true;
            this.Btn_Accion.Click += new System.EventHandler(this.Btn_Accion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 292);
            this.Controls.Add(this.Btn_Accion);
            this.Controls.Add(this.TxtBox_Contenido);
            this.Controls.Add(this.Label_Objetivo);
            this.Name = "Form1";
            this.Text = "Mandar contenido de TxtBox a Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Objetivo;
        private System.Windows.Forms.TextBox TxtBox_Contenido;
        private System.Windows.Forms.Button Btn_Accion;
    }
}

