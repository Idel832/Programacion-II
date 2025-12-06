namespace ManejoDeEmpleados
{
    partial class Departamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Cargar_Prods = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Dpts = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Export_Table_Departamentos = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_Agregar_Add_Dpto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_Name_Add_Dpto = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_Update_Edit_Dpto = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBox_ID_Edit_Dpto = new System.Windows.Forms.TextBox();
            this.TxtBox_Name_Edit_Dpto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Btn_Delete_Del_Dpto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBox_ID_Del_Dpto = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dpts)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(42, 789);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1039, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 789);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Cargar_Prods);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(42, 749);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 40);
            this.panel3.TabIndex = 2;
            // 
            // Btn_Cargar_Prods
            // 
            this.Btn_Cargar_Prods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cargar_Prods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar_Prods.Location = new System.Drawing.Point(0, 0);
            this.Btn_Cargar_Prods.Name = "Btn_Cargar_Prods";
            this.Btn_Cargar_Prods.Size = new System.Drawing.Size(997, 40);
            this.Btn_Cargar_Prods.TabIndex = 0;
            this.Btn_Cargar_Prods.Text = "Cargar tabla";
            this.Btn_Cargar_Prods.UseVisualStyleBackColor = true;
            this.Btn_Cargar_Prods.Click += new System.EventHandler(this.Btn_Cargar_Dpto_Click);
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(934, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar";
            // 
            // DGV_Dpts
            // 
            this.DGV_Dpts.AllowUserToAddRows = false;
            this.DGV_Dpts.AllowUserToDeleteRows = false;
            this.DGV_Dpts.AllowUserToResizeColumns = false;
            this.DGV_Dpts.AllowUserToResizeRows = false;
            this.DGV_Dpts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Dpts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Dpts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Dpts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Dpts.Location = new System.Drawing.Point(42, 509);
            this.DGV_Dpts.Name = "DGV_Dpts";
            this.DGV_Dpts.ReadOnly = true;
            this.DGV_Dpts.Size = new System.Drawing.Size(997, 240);
            this.DGV_Dpts.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn_Export_Table_Departamentos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(42, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(997, 40);
            this.panel5.TabIndex = 5;
            // 
            // Btn_Export_Table_Departamentos
            // 
            this.Btn_Export_Table_Departamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Export_Table_Departamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Export_Table_Departamentos.Location = new System.Drawing.Point(0, 0);
            this.Btn_Export_Table_Departamentos.Name = "Btn_Export_Table_Departamentos";
            this.Btn_Export_Table_Departamentos.Size = new System.Drawing.Size(997, 40);
            this.Btn_Export_Table_Departamentos.TabIndex = 25;
            this.Btn_Export_Table_Departamentos.Text = "Exportar tabla";
            this.Btn_Export_Table_Departamentos.UseVisualStyleBackColor = true;
            this.Btn_Export_Table_Departamentos.Click += new System.EventHandler(this.Btn_Export_Table_Departamentos_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Btn_Agregar_Add_Dpto);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.TxtBox_Name_Add_Dpto);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(42, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 429);
            this.panel6.TabIndex = 6;
            // 
            // Btn_Agregar_Add_Dpto
            // 
            this.Btn_Agregar_Add_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Add_Dpto.Location = new System.Drawing.Point(84, 76);
            this.Btn_Agregar_Add_Dpto.Name = "Btn_Agregar_Add_Dpto";
            this.Btn_Agregar_Add_Dpto.Size = new System.Drawing.Size(150, 52);
            this.Btn_Agregar_Add_Dpto.TabIndex = 16;
            this.Btn_Agregar_Add_Dpto.Text = "Agregar";
            this.Btn_Agregar_Add_Dpto.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Add_Dpto.Click += new System.EventHandler(this.Btn_Agregar_Add_Dpto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre de departamento";
            // 
            // TxtBox_Name_Add_Dpto
            // 
            this.TxtBox_Name_Add_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Name_Add_Dpto.Location = new System.Drawing.Point(7, 46);
            this.TxtBox_Name_Add_Dpto.Name = "TxtBox_Name_Add_Dpto";
            this.TxtBox_Name_Add_Dpto.Size = new System.Drawing.Size(316, 24);
            this.TxtBox_Name_Add_Dpto.TabIndex = 8;
            this.TxtBox_Name_Add_Dpto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Letras_KeyPress);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Btn_Update_Edit_Dpto);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.TxtBox_ID_Edit_Dpto);
            this.panel7.Controls.Add(this.TxtBox_Name_Edit_Dpto);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(707, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(332, 429);
            this.panel7.TabIndex = 7;
            // 
            // Btn_Update_Edit_Dpto
            // 
            this.Btn_Update_Edit_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update_Edit_Dpto.Location = new System.Drawing.Point(172, 32);
            this.Btn_Update_Edit_Dpto.Name = "Btn_Update_Edit_Dpto";
            this.Btn_Update_Edit_Dpto.Size = new System.Drawing.Size(150, 52);
            this.Btn_Update_Edit_Dpto.TabIndex = 30;
            this.Btn_Update_Edit_Dpto.Text = "Actualizar";
            this.Btn_Update_Edit_Dpto.UseVisualStyleBackColor = true;
            this.Btn_Update_Edit_Dpto.Click += new System.EventHandler(this.Btn_Update_Edit_Dpto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID";
            // 
            // TxtBox_ID_Edit_Dpto
            // 
            this.TxtBox_ID_Edit_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_ID_Edit_Dpto.Location = new System.Drawing.Point(6, 46);
            this.TxtBox_ID_Edit_Dpto.Name = "TxtBox_ID_Edit_Dpto";
            this.TxtBox_ID_Edit_Dpto.Size = new System.Drawing.Size(125, 24);
            this.TxtBox_ID_Edit_Dpto.TabIndex = 28;
            this.TxtBox_ID_Edit_Dpto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_ID_KeyPress);
            // 
            // TxtBox_Name_Edit_Dpto
            // 
            this.TxtBox_Name_Edit_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Name_Edit_Dpto.Location = new System.Drawing.Point(6, 114);
            this.TxtBox_Name_Edit_Dpto.Name = "TxtBox_Name_Edit_Dpto";
            this.TxtBox_Name_Edit_Dpto.Size = new System.Drawing.Size(316, 24);
            this.TxtBox_Name_Edit_Dpto.TabIndex = 16;
            this.TxtBox_Name_Edit_Dpto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Letras_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nombre de departamento";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.Btn_Delete_Del_Dpto);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.TxtBox_ID_Del_Dpto);
            this.panel8.Location = new System.Drawing.Point(374, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(333, 429);
            this.panel8.TabIndex = 8;
            // 
            // Btn_Delete_Del_Dpto
            // 
            this.Btn_Delete_Del_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete_Del_Dpto.Location = new System.Drawing.Point(84, 76);
            this.Btn_Delete_Del_Dpto.Name = "Btn_Delete_Del_Dpto";
            this.Btn_Delete_Del_Dpto.Size = new System.Drawing.Size(150, 52);
            this.Btn_Delete_Del_Dpto.TabIndex = 13;
            this.Btn_Delete_Del_Dpto.Text = "Eliminar";
            this.Btn_Delete_Del_Dpto.UseVisualStyleBackColor = true;
            this.Btn_Delete_Del_Dpto.Click += new System.EventHandler(this.Btn_Delete_Del_Dpto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "ID";
            // 
            // TxtBox_ID_Del_Dpto
            // 
            this.TxtBox_ID_Del_Dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_ID_Del_Dpto.Location = new System.Drawing.Point(6, 46);
            this.TxtBox_ID_Del_Dpto.Name = "TxtBox_ID_Del_Dpto";
            this.TxtBox_ID_Del_Dpto.Size = new System.Drawing.Size(316, 24);
            this.TxtBox_ID_Del_Dpto.TabIndex = 11;
            this.TxtBox_ID_Del_Dpto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_ID_KeyPress);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 789);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.DGV_Dpts);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dpts)).EndInit();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView DGV_Dpts;
        private System.Windows.Forms.Button Btn_Cargar_Prods;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_Name_Add_Dpto;
        private System.Windows.Forms.TextBox TxtBox_Name_Edit_Dpto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Update_Edit_Dpto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBox_ID_Edit_Dpto;
        private System.Windows.Forms.Button Btn_Delete_Del_Dpto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBox_ID_Del_Dpto;
        private System.Windows.Forms.Button Btn_Agregar_Add_Dpto;
        private System.Windows.Forms.Button Btn_Export_Table_Departamentos;
    }
}

