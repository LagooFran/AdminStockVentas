namespace Master_guapo
{
    partial class Form3
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
            this.BTN_menuAdmin1 = new System.Windows.Forms.Button();
            this.LBL_menuAdmin1 = new System.Windows.Forms.Label();
            this.LBL_menuAdmin2 = new System.Windows.Forms.Label();
            this.DGV_menuAdmin1 = new System.Windows.Forms.DataGridView();
            this.DGV_menuAdmin2 = new System.Windows.Forms.DataGridView();
            this.BTN_menuAdmin2 = new System.Windows.Forms.Button();
            this.BTN_menuAdmin3 = new System.Windows.Forms.Button();
            this.CMB_menuAdmin1 = new System.Windows.Forms.ComboBox();
            this.TXB_menuAdmin1 = new System.Windows.Forms.TextBox();
            this.TXB_menuAdmin4 = new System.Windows.Forms.TextBox();
            this.TXB_menuAdmin2 = new System.Windows.Forms.TextBox();
            this.TXB_menuAdmin3 = new System.Windows.Forms.TextBox();
            this.LBL_menuAdmin3 = new System.Windows.Forms.Label();
            this.LBL_menuAdmin4 = new System.Windows.Forms.Label();
            this.LBL_menuAdmin5 = new System.Windows.Forms.Label();
            this.LBL_menuAdmin6 = new System.Windows.Forms.Label();
            this.LBL_menuAdmin7 = new System.Windows.Forms.Label();
            this.BTN_menuAdmin4 = new System.Windows.Forms.Button();
            this.BTN_menuAdmin5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_menuAdmin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_menuAdmin2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_menuAdmin1
            // 
            this.BTN_menuAdmin1.Location = new System.Drawing.Point(12, 84);
            this.BTN_menuAdmin1.Name = "BTN_menuAdmin1";
            this.BTN_menuAdmin1.Size = new System.Drawing.Size(283, 54);
            this.BTN_menuAdmin1.TabIndex = 0;
            this.BTN_menuAdmin1.Text = "Crear una cuenta vendedor";
            this.BTN_menuAdmin1.UseVisualStyleBackColor = true;
            this.BTN_menuAdmin1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL_menuAdmin1
            // 
            this.LBL_menuAdmin1.AutoSize = true;
            this.LBL_menuAdmin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin1.Location = new System.Drawing.Point(12, 21);
            this.LBL_menuAdmin1.Name = "LBL_menuAdmin1";
            this.LBL_menuAdmin1.Size = new System.Drawing.Size(175, 24);
            this.LBL_menuAdmin1.TabIndex = 1;
            this.LBL_menuAdmin1.Text = "Hola! Administrador";
            // 
            // LBL_menuAdmin2
            // 
            this.LBL_menuAdmin2.AutoSize = true;
            this.LBL_menuAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin2.Location = new System.Drawing.Point(13, 45);
            this.LBL_menuAdmin2.Name = "LBL_menuAdmin2";
            this.LBL_menuAdmin2.Size = new System.Drawing.Size(145, 16);
            this.LBL_menuAdmin2.TabIndex = 2;
            this.LBL_menuAdmin2.Text = "Seleccione una opcion";
            // 
            // DGV_menuAdmin1
            // 
            this.DGV_menuAdmin1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_menuAdmin1.Location = new System.Drawing.Point(12, 292);
            this.DGV_menuAdmin1.Name = "DGV_menuAdmin1";
            this.DGV_menuAdmin1.Size = new System.Drawing.Size(370, 233);
            this.DGV_menuAdmin1.TabIndex = 3;
            // 
            // DGV_menuAdmin2
            // 
            this.DGV_menuAdmin2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_menuAdmin2.Location = new System.Drawing.Point(417, 292);
            this.DGV_menuAdmin2.Name = "DGV_menuAdmin2";
            this.DGV_menuAdmin2.Size = new System.Drawing.Size(285, 233);
            this.DGV_menuAdmin2.TabIndex = 4;
            // 
            // BTN_menuAdmin2
            // 
            this.BTN_menuAdmin2.Location = new System.Drawing.Point(12, 263);
            this.BTN_menuAdmin2.Name = "BTN_menuAdmin2";
            this.BTN_menuAdmin2.Size = new System.Drawing.Size(370, 23);
            this.BTN_menuAdmin2.TabIndex = 5;
            this.BTN_menuAdmin2.Text = "Ver personal";
            this.BTN_menuAdmin2.UseVisualStyleBackColor = true;
            this.BTN_menuAdmin2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTN_menuAdmin3
            // 
            this.BTN_menuAdmin3.Location = new System.Drawing.Point(417, 263);
            this.BTN_menuAdmin3.Name = "BTN_menuAdmin3";
            this.BTN_menuAdmin3.Size = new System.Drawing.Size(285, 23);
            this.BTN_menuAdmin3.TabIndex = 6;
            this.BTN_menuAdmin3.Text = "Ver vehiculos";
            this.BTN_menuAdmin3.UseVisualStyleBackColor = true;
            // 
            // CMB_menuAdmin1
            // 
            this.CMB_menuAdmin1.FormattingEnabled = true;
            this.CMB_menuAdmin1.Items.AddRange(new object[] {
            "Cuenta Administrador"});
            this.CMB_menuAdmin1.Location = new System.Drawing.Point(417, 47);
            this.CMB_menuAdmin1.Name = "CMB_menuAdmin1";
            this.CMB_menuAdmin1.Size = new System.Drawing.Size(121, 21);
            this.CMB_menuAdmin1.TabIndex = 7;
            // 
            // TXB_menuAdmin1
            // 
            this.TXB_menuAdmin1.Location = new System.Drawing.Point(417, 87);
            this.TXB_menuAdmin1.Name = "TXB_menuAdmin1";
            this.TXB_menuAdmin1.Size = new System.Drawing.Size(151, 20);
            this.TXB_menuAdmin1.TabIndex = 8;
            // 
            // TXB_menuAdmin4
            // 
            this.TXB_menuAdmin4.Location = new System.Drawing.Point(417, 204);
            this.TXB_menuAdmin4.Name = "TXB_menuAdmin4";
            this.TXB_menuAdmin4.Size = new System.Drawing.Size(151, 20);
            this.TXB_menuAdmin4.TabIndex = 9;
            // 
            // TXB_menuAdmin2
            // 
            this.TXB_menuAdmin2.Location = new System.Drawing.Point(417, 126);
            this.TXB_menuAdmin2.Name = "TXB_menuAdmin2";
            this.TXB_menuAdmin2.PasswordChar = '*';
            this.TXB_menuAdmin2.Size = new System.Drawing.Size(151, 20);
            this.TXB_menuAdmin2.TabIndex = 10;
            // 
            // TXB_menuAdmin3
            // 
            this.TXB_menuAdmin3.Location = new System.Drawing.Point(417, 165);
            this.TXB_menuAdmin3.Name = "TXB_menuAdmin3";
            this.TXB_menuAdmin3.Size = new System.Drawing.Size(151, 20);
            this.TXB_menuAdmin3.TabIndex = 11;
            // 
            // LBL_menuAdmin3
            // 
            this.LBL_menuAdmin3.AutoSize = true;
            this.LBL_menuAdmin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin3.Location = new System.Drawing.Point(414, 27);
            this.LBL_menuAdmin3.Name = "LBL_menuAdmin3";
            this.LBL_menuAdmin3.Size = new System.Drawing.Size(169, 16);
            this.LBL_menuAdmin3.TabIndex = 12;
            this.LBL_menuAdmin3.Text = "Cambiar datos de usuarios";
            this.LBL_menuAdmin3.Click += new System.EventHandler(this.LBL_menuAdmin3_Click);
            // 
            // LBL_menuAdmin4
            // 
            this.LBL_menuAdmin4.AutoSize = true;
            this.LBL_menuAdmin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin4.Location = new System.Drawing.Point(414, 71);
            this.LBL_menuAdmin4.Name = "LBL_menuAdmin4";
            this.LBL_menuAdmin4.Size = new System.Drawing.Size(43, 13);
            this.LBL_menuAdmin4.TabIndex = 13;
            this.LBL_menuAdmin4.Text = "Usuario";
            // 
            // LBL_menuAdmin5
            // 
            this.LBL_menuAdmin5.AutoSize = true;
            this.LBL_menuAdmin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin5.Location = new System.Drawing.Point(414, 110);
            this.LBL_menuAdmin5.Name = "LBL_menuAdmin5";
            this.LBL_menuAdmin5.Size = new System.Drawing.Size(61, 13);
            this.LBL_menuAdmin5.TabIndex = 14;
            this.LBL_menuAdmin5.Text = "Contraseña";
            // 
            // LBL_menuAdmin6
            // 
            this.LBL_menuAdmin6.AutoSize = true;
            this.LBL_menuAdmin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin6.Location = new System.Drawing.Point(414, 149);
            this.LBL_menuAdmin6.Name = "LBL_menuAdmin6";
            this.LBL_menuAdmin6.Size = new System.Drawing.Size(23, 13);
            this.LBL_menuAdmin6.TabIndex = 15;
            this.LBL_menuAdmin6.Text = "Dni";
            // 
            // LBL_menuAdmin7
            // 
            this.LBL_menuAdmin7.AutoSize = true;
            this.LBL_menuAdmin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_menuAdmin7.Location = new System.Drawing.Point(414, 188);
            this.LBL_menuAdmin7.Name = "LBL_menuAdmin7";
            this.LBL_menuAdmin7.Size = new System.Drawing.Size(32, 13);
            this.LBL_menuAdmin7.TabIndex = 16;
            this.LBL_menuAdmin7.Text = "Email";
            // 
            // BTN_menuAdmin4
            // 
            this.BTN_menuAdmin4.Location = new System.Drawing.Point(593, 204);
            this.BTN_menuAdmin4.Name = "BTN_menuAdmin4";
            this.BTN_menuAdmin4.Size = new System.Drawing.Size(92, 23);
            this.BTN_menuAdmin4.TabIndex = 17;
            this.BTN_menuAdmin4.Text = "Cambiar datos";
            this.BTN_menuAdmin4.UseVisualStyleBackColor = true;
            this.BTN_menuAdmin4.Click += new System.EventHandler(this.BTN_menuAdmin4_Click);
            // 
            // BTN_menuAdmin5
            // 
            this.BTN_menuAdmin5.Location = new System.Drawing.Point(12, 144);
            this.BTN_menuAdmin5.Name = "BTN_menuAdmin5";
            this.BTN_menuAdmin5.Size = new System.Drawing.Size(283, 80);
            this.BTN_menuAdmin5.TabIndex = 18;
            this.BTN_menuAdmin5.Text = "Cerrar sesion";
            this.BTN_menuAdmin5.UseVisualStyleBackColor = true;
            this.BTN_menuAdmin5.Click += new System.EventHandler(this.BTN_menuAdmin5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 537);
            this.Controls.Add(this.BTN_menuAdmin5);
            this.Controls.Add(this.BTN_menuAdmin4);
            this.Controls.Add(this.LBL_menuAdmin7);
            this.Controls.Add(this.LBL_menuAdmin6);
            this.Controls.Add(this.LBL_menuAdmin5);
            this.Controls.Add(this.LBL_menuAdmin4);
            this.Controls.Add(this.LBL_menuAdmin3);
            this.Controls.Add(this.TXB_menuAdmin3);
            this.Controls.Add(this.TXB_menuAdmin2);
            this.Controls.Add(this.TXB_menuAdmin4);
            this.Controls.Add(this.TXB_menuAdmin1);
            this.Controls.Add(this.CMB_menuAdmin1);
            this.Controls.Add(this.BTN_menuAdmin3);
            this.Controls.Add(this.BTN_menuAdmin2);
            this.Controls.Add(this.DGV_menuAdmin2);
            this.Controls.Add(this.DGV_menuAdmin1);
            this.Controls.Add(this.LBL_menuAdmin2);
            this.Controls.Add(this.LBL_menuAdmin1);
            this.Controls.Add(this.BTN_menuAdmin1);
            this.Name = "Form3";
            this.Text = "Menu administracion";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_menuAdmin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_menuAdmin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_menuAdmin1;
        private System.Windows.Forms.Label LBL_menuAdmin1;
        private System.Windows.Forms.Label LBL_menuAdmin2;
        private System.Windows.Forms.DataGridView DGV_menuAdmin1;
        private System.Windows.Forms.DataGridView DGV_menuAdmin2;
        private System.Windows.Forms.Button BTN_menuAdmin2;
        private System.Windows.Forms.Button BTN_menuAdmin3;
        private System.Windows.Forms.ComboBox CMB_menuAdmin1;
        private System.Windows.Forms.TextBox TXB_menuAdmin1;
        private System.Windows.Forms.TextBox TXB_menuAdmin4;
        private System.Windows.Forms.TextBox TXB_menuAdmin2;
        private System.Windows.Forms.TextBox TXB_menuAdmin3;
        private System.Windows.Forms.Label LBL_menuAdmin3;
        private System.Windows.Forms.Label LBL_menuAdmin4;
        private System.Windows.Forms.Label LBL_menuAdmin5;
        private System.Windows.Forms.Label LBL_menuAdmin6;
        private System.Windows.Forms.Label LBL_menuAdmin7;
        private System.Windows.Forms.Button BTN_menuAdmin4;
        private System.Windows.Forms.Button BTN_menuAdmin5;
    }
}