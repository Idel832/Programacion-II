namespace Practica_3
{
    partial class Categorias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Cargar_Catg = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGV_Catg = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_Name_Add_Catg = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_Update_Edit_Catg = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBox_ID_Edit_Catg = new System.Windows.Forms.TextBox();
            this.TxtBox_Name_Edit_Catg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Btn_Delete_Del_Catg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBox_ID_Del_Catg = new System.Windows.Forms.TextBox();
            this.Btn_Agregar_Add_Catg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Catg)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 656);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1039, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 656);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Cargar_Catg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(42, 616);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 40);
            this.panel3.TabIndex = 2;
            // 
            // Btn_Cargar_Catg
            // 
            this.Btn_Cargar_Catg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cargar_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar_Catg.Location = new System.Drawing.Point(0, 0);
            this.Btn_Cargar_Catg.Name = "Btn_Cargar_Catg";
            this.Btn_Cargar_Catg.Size = new System.Drawing.Size(997, 40);
            this.Btn_Cargar_Catg.TabIndex = 0;
            this.Btn_Cargar_Catg.Text = "Cargar tabla";
            this.Btn_Cargar_Catg.UseVisualStyleBackColor = true;
            this.Btn_Cargar_Catg.Click += new System.EventHandler(this.Btn_Cargar_Catg_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(42, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(997, 40);
            this.panel4.TabIndex = 3;
            // 
            // DGV_Catg
            // 
            this.DGV_Catg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Catg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Catg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Catg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Catg.Location = new System.Drawing.Point(42, 410);
            this.DGV_Catg.Name = "DGV_Catg";
            this.DGV_Catg.ReadOnly = true;
            this.DGV_Catg.Size = new System.Drawing.Size(997, 206);
            this.DGV_Catg.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(42, 370);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(997, 40);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Btn_Agregar_Add_Catg);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.TxtBox_Name_Add_Catg);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(42, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 330);
            this.panel6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoría";
            // 
            // TxtBox_Name_Add_Catg
            // 
            this.TxtBox_Name_Add_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Name_Add_Catg.Location = new System.Drawing.Point(10, 42);
            this.TxtBox_Name_Add_Catg.Name = "TxtBox_Name_Add_Catg";
            this.TxtBox_Name_Add_Catg.Size = new System.Drawing.Size(316, 24);
            this.TxtBox_Name_Add_Catg.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Btn_Update_Edit_Catg);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.TxtBox_ID_Edit_Catg);
            this.panel7.Controls.Add(this.TxtBox_Name_Edit_Catg);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(707, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(332, 330);
            this.panel7.TabIndex = 7;
            // 
            // Btn_Update_Edit_Catg
            // 
            this.Btn_Update_Edit_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update_Edit_Catg.Location = new System.Drawing.Point(173, 32);
            this.Btn_Update_Edit_Catg.Name = "Btn_Update_Edit_Catg";
            this.Btn_Update_Edit_Catg.Size = new System.Drawing.Size(129, 43);
            this.Btn_Update_Edit_Catg.TabIndex = 27;
            this.Btn_Update_Edit_Catg.Text = "Actualizar";
            this.Btn_Update_Edit_Catg.UseVisualStyleBackColor = true;
            this.Btn_Update_Edit_Catg.Click += new System.EventHandler(this.Btn_Update_Edit_Catg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID";
            // 
            // TxtBox_ID_Edit_Catg
            // 
            this.TxtBox_ID_Edit_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_ID_Edit_Catg.Location = new System.Drawing.Point(8, 41);
            this.TxtBox_ID_Edit_Catg.Name = "TxtBox_ID_Edit_Catg";
            this.TxtBox_ID_Edit_Catg.Size = new System.Drawing.Size(125, 24);
            this.TxtBox_ID_Edit_Catg.TabIndex = 19;
            // 
            // TxtBox_Name_Edit_Catg
            // 
            this.TxtBox_Name_Edit_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Name_Edit_Catg.Location = new System.Drawing.Point(8, 112);
            this.TxtBox_Name_Edit_Catg.Name = "TxtBox_Name_Edit_Catg";
            this.TxtBox_Name_Edit_Catg.Size = new System.Drawing.Size(316, 24);
            this.TxtBox_Name_Edit_Catg.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Categoría";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.Btn_Delete_Del_Catg);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.TxtBox_ID_Del_Catg);
            this.panel8.Location = new System.Drawing.Point(374, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(333, 330);
            this.panel8.TabIndex = 8;
            // 
            // Btn_Delete_Del_Catg
            // 
            this.Btn_Delete_Del_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete_Del_Catg.Location = new System.Drawing.Point(84, 72);
            this.Btn_Delete_Del_Catg.Name = "Btn_Delete_Del_Catg";
            this.Btn_Delete_Del_Catg.Size = new System.Drawing.Size(150, 52);
            this.Btn_Delete_Del_Catg.TabIndex = 13;
            this.Btn_Delete_Del_Catg.Text = "Eliminar";
            this.Btn_Delete_Del_Catg.UseVisualStyleBackColor = true;
            this.Btn_Delete_Del_Catg.Click += new System.EventHandler(this.Btn_Delete_Del_Catg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID";
            // 
            // TxtBox_ID_Del_Catg
            // 
            this.TxtBox_ID_Del_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_ID_Del_Catg.Location = new System.Drawing.Point(6, 42);
            this.TxtBox_ID_Del_Catg.Name = "TxtBox_ID_Del_Catg";
            this.TxtBox_ID_Del_Catg.Size = new System.Drawing.Size(316, 24);
            this.TxtBox_ID_Del_Catg.TabIndex = 11;
            // 
            // Btn_Agregar_Add_Catg
            // 
            this.Btn_Agregar_Add_Catg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Add_Catg.Location = new System.Drawing.Point(86, 93);
            this.Btn_Agregar_Add_Catg.Name = "Btn_Agregar_Add_Catg";
            this.Btn_Agregar_Add_Catg.Size = new System.Drawing.Size(150, 32);
            this.Btn_Agregar_Add_Catg.TabIndex = 18;
            this.Btn_Agregar_Add_Catg.Text = "Agregar";
            this.Btn_Agregar_Add_Catg.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Add_Catg.Click += new System.EventHandler(this.Btn_Agregar_Add_Catg_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(934, 10);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 656);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.DGV_Catg);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Catg)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DGV_Catg;
        private System.Windows.Forms.Button Btn_Cargar_Catg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_Name_Add_Catg;
        private System.Windows.Forms.Button Btn_Delete_Del_Catg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBox_ID_Del_Catg;
        private System.Windows.Forms.Button Btn_Update_Edit_Catg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBox_ID_Edit_Catg;
        private System.Windows.Forms.TextBox TxtBox_Name_Edit_Catg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_Agregar_Add_Catg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

