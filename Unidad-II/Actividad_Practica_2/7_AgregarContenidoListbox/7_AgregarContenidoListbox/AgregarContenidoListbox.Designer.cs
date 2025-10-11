namespace _7_AgregarContenidoListbox
{
    partial class AgregarContenidoListbox
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
            this.ListBox_Objetivo = new System.Windows.Forms.ListBox();
            this.TxtBox_Contenido = new System.Windows.Forms.TextBox();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_Objetivo
            // 
            this.ListBox_Objetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Objetivo.FormattingEnabled = true;
            this.ListBox_Objetivo.ItemHeight = 20;
            this.ListBox_Objetivo.Location = new System.Drawing.Point(27, 109);
            this.ListBox_Objetivo.Name = "ListBox_Objetivo";
            this.ListBox_Objetivo.Size = new System.Drawing.Size(541, 184);
            this.ListBox_Objetivo.TabIndex = 0;
            // 
            // TxtBox_Contenido
            // 
            this.TxtBox_Contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Contenido.Location = new System.Drawing.Point(27, 53);
            this.TxtBox_Contenido.Name = "TxtBox_Contenido";
            this.TxtBox_Contenido.Size = new System.Drawing.Size(366, 26);
            this.TxtBox_Contenido.TabIndex = 1;
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Location = new System.Drawing.Point(424, 40);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(144, 53);
            this.Btn_Enviar.TabIndex = 2;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // AgregarContenidoListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 330);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.TxtBox_Contenido);
            this.Controls.Add(this.ListBox_Objetivo);
            this.Name = "AgregarContenidoListbox";
            this.Text = "Agregar elementos a una ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Objetivo;
        private System.Windows.Forms.TextBox TxtBox_Contenido;
        private System.Windows.Forms.Button Btn_Enviar;
    }
}

