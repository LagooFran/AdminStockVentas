namespace Master_guapo
{
    partial class Form7
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
            this.BTN_ingProd2 = new System.Windows.Forms.Button();
            this.BTN_ingProd1 = new System.Windows.Forms.Button();
            this.LBL_ingProd1 = new System.Windows.Forms.Label();
            this.LBL_ingProd2 = new System.Windows.Forms.Label();
            this.CMB_ingProd1 = new System.Windows.Forms.ComboBox();
            this.CMB_ingProd2 = new System.Windows.Forms.ComboBox();
            this.LBL_ingProd3 = new System.Windows.Forms.Label();
            this.LBL_ingProd6 = new System.Windows.Forms.Label();
            this.TXB_ingProd1 = new System.Windows.Forms.TextBox();
            this.TXB_ingProd2 = new System.Windows.Forms.TextBox();
            this.LBL_ingProd4 = new System.Windows.Forms.Label();
            this.LBL_ingProd5 = new System.Windows.Forms.Label();
            this.LBL_ingProd7 = new System.Windows.Forms.Label();
            this.CMB_ingProd3 = new System.Windows.Forms.ComboBox();
            this.CHB_ingProd1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTN_ingProd2
            // 
            this.BTN_ingProd2.Location = new System.Drawing.Point(12, 303);
            this.BTN_ingProd2.Name = "BTN_ingProd2";
            this.BTN_ingProd2.Size = new System.Drawing.Size(90, 23);
            this.BTN_ingProd2.TabIndex = 0;
            this.BTN_ingProd2.Text = "Atras";
            this.BTN_ingProd2.UseVisualStyleBackColor = true;
            this.BTN_ingProd2.Click += new System.EventHandler(this.BTN_ingProd2_Click);
            // 
            // BTN_ingProd1
            // 
            this.BTN_ingProd1.Location = new System.Drawing.Point(184, 303);
            this.BTN_ingProd1.Name = "BTN_ingProd1";
            this.BTN_ingProd1.Size = new System.Drawing.Size(88, 23);
            this.BTN_ingProd1.TabIndex = 1;
            this.BTN_ingProd1.Text = "Siguiente";
            this.BTN_ingProd1.UseVisualStyleBackColor = true;
            this.BTN_ingProd1.Click += new System.EventHandler(this.BTN_ingProd1_Click);
            // 
            // LBL_ingProd1
            // 
            this.LBL_ingProd1.AutoSize = true;
            this.LBL_ingProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ingProd1.Location = new System.Drawing.Point(8, 9);
            this.LBL_ingProd1.Name = "LBL_ingProd1";
            this.LBL_ingProd1.Size = new System.Drawing.Size(180, 24);
            this.LBL_ingProd1.TabIndex = 3;
            this.LBL_ingProd1.Text = "Ingreso de producto";
            // 
            // LBL_ingProd2
            // 
            this.LBL_ingProd2.AutoSize = true;
            this.LBL_ingProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ingProd2.Location = new System.Drawing.Point(9, 33);
            this.LBL_ingProd2.Name = "LBL_ingProd2";
            this.LBL_ingProd2.Size = new System.Drawing.Size(124, 16);
            this.LBL_ingProd2.TabIndex = 4;
            this.LBL_ingProd2.Text = "Complete los datos";
            // 
            // CMB_ingProd1
            // 
            this.CMB_ingProd1.FormattingEnabled = true;
            this.CMB_ingProd1.Items.AddRange(new object[] {
            "Jabon",
            "Limpiador"});
            this.CMB_ingProd1.Location = new System.Drawing.Point(12, 95);
            this.CMB_ingProd1.Name = "CMB_ingProd1";
            this.CMB_ingProd1.Size = new System.Drawing.Size(176, 21);
            this.CMB_ingProd1.TabIndex = 5;
            this.CMB_ingProd1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CMB_ingProd2
            // 
            this.CMB_ingProd2.FormattingEnabled = true;
            this.CMB_ingProd2.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "12"});
            this.CMB_ingProd2.Location = new System.Drawing.Point(12, 213);
            this.CMB_ingProd2.Name = "CMB_ingProd2";
            this.CMB_ingProd2.Size = new System.Drawing.Size(176, 21);
            this.CMB_ingProd2.TabIndex = 6;
            // 
            // LBL_ingProd3
            // 
            this.LBL_ingProd3.AutoSize = true;
            this.LBL_ingProd3.Location = new System.Drawing.Point(12, 79);
            this.LBL_ingProd3.Name = "LBL_ingProd3";
            this.LBL_ingProd3.Size = new System.Drawing.Size(28, 13);
            this.LBL_ingProd3.TabIndex = 7;
            this.LBL_ingProd3.Text = "Tipo";
            // 
            // LBL_ingProd6
            // 
            this.LBL_ingProd6.AutoSize = true;
            this.LBL_ingProd6.Location = new System.Drawing.Point(13, 197);
            this.LBL_ingProd6.Name = "LBL_ingProd6";
            this.LBL_ingProd6.Size = new System.Drawing.Size(90, 13);
            this.LBL_ingProd6.TabIndex = 8;
            this.LBL_ingProd6.Text = "Tamaño del pack";
            this.LBL_ingProd6.Click += new System.EventHandler(this.LBL_ingProd6_Click);
            // 
            // TXB_ingProd1
            // 
            this.TXB_ingProd1.Location = new System.Drawing.Point(12, 135);
            this.TXB_ingProd1.Name = "TXB_ingProd1";
            this.TXB_ingProd1.Size = new System.Drawing.Size(176, 20);
            this.TXB_ingProd1.TabIndex = 9;
            // 
            // TXB_ingProd2
            // 
            this.TXB_ingProd2.Location = new System.Drawing.Point(12, 174);
            this.TXB_ingProd2.Name = "TXB_ingProd2";
            this.TXB_ingProd2.Size = new System.Drawing.Size(176, 20);
            this.TXB_ingProd2.TabIndex = 10;
            // 
            // LBL_ingProd4
            // 
            this.LBL_ingProd4.AutoSize = true;
            this.LBL_ingProd4.Location = new System.Drawing.Point(13, 119);
            this.LBL_ingProd4.Name = "LBL_ingProd4";
            this.LBL_ingProd4.Size = new System.Drawing.Size(37, 13);
            this.LBL_ingProd4.TabIndex = 12;
            this.LBL_ingProd4.Text = "Precio";
            // 
            // LBL_ingProd5
            // 
            this.LBL_ingProd5.AutoSize = true;
            this.LBL_ingProd5.Location = new System.Drawing.Point(13, 158);
            this.LBL_ingProd5.Name = "LBL_ingProd5";
            this.LBL_ingProd5.Size = new System.Drawing.Size(40, 13);
            this.LBL_ingProd5.TabIndex = 13;
            this.LBL_ingProd5.Text = "Codigo";
            // 
            // LBL_ingProd7
            // 
            this.LBL_ingProd7.AutoSize = true;
            this.LBL_ingProd7.Location = new System.Drawing.Point(13, 237);
            this.LBL_ingProd7.Name = "LBL_ingProd7";
            this.LBL_ingProd7.Size = new System.Drawing.Size(37, 13);
            this.LBL_ingProd7.TabIndex = 14;
            this.LBL_ingProd7.Text = "Aroma";
            this.LBL_ingProd7.Visible = false;
            // 
            // CMB_ingProd3
            // 
            this.CMB_ingProd3.FormattingEnabled = true;
            this.CMB_ingProd3.Items.AddRange(new object[] {
            "Lavanda",
            "Rosas",
            "Frutilla",
            "Anana",
            "Uva",
            "Inodoro"});
            this.CMB_ingProd3.Location = new System.Drawing.Point(12, 253);
            this.CMB_ingProd3.Name = "CMB_ingProd3";
            this.CMB_ingProd3.Size = new System.Drawing.Size(176, 21);
            this.CMB_ingProd3.TabIndex = 15;
            this.CMB_ingProd3.Visible = false;
            // 
            // CHB_ingProd1
            // 
            this.CHB_ingProd1.AutoSize = true;
            this.CHB_ingProd1.Location = new System.Drawing.Point(12, 255);
            this.CHB_ingProd1.Name = "CHB_ingProd1";
            this.CHB_ingProd1.Size = new System.Drawing.Size(93, 17);
            this.CHB_ingProd1.TabIndex = 16;
            this.CHB_ingProd1.Text = "Para interiores";
            this.CHB_ingProd1.UseVisualStyleBackColor = true;
            this.CHB_ingProd1.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.CHB_ingProd1);
            this.Controls.Add(this.CMB_ingProd3);
            this.Controls.Add(this.LBL_ingProd7);
            this.Controls.Add(this.LBL_ingProd5);
            this.Controls.Add(this.LBL_ingProd4);
            this.Controls.Add(this.TXB_ingProd2);
            this.Controls.Add(this.TXB_ingProd1);
            this.Controls.Add(this.LBL_ingProd6);
            this.Controls.Add(this.LBL_ingProd3);
            this.Controls.Add(this.CMB_ingProd2);
            this.Controls.Add(this.CMB_ingProd1);
            this.Controls.Add(this.LBL_ingProd2);
            this.Controls.Add(this.LBL_ingProd1);
            this.Controls.Add(this.BTN_ingProd1);
            this.Controls.Add(this.BTN_ingProd2);
            this.Name = "Form7";
            this.Text = "Ingreso de producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ingProd2;
        private System.Windows.Forms.Button BTN_ingProd1;
        private System.Windows.Forms.Label LBL_ingProd1;
        private System.Windows.Forms.Label LBL_ingProd2;
        private System.Windows.Forms.ComboBox CMB_ingProd1;
        private System.Windows.Forms.ComboBox CMB_ingProd2;
        private System.Windows.Forms.Label LBL_ingProd3;
        private System.Windows.Forms.Label LBL_ingProd6;
        private System.Windows.Forms.TextBox TXB_ingProd1;
        private System.Windows.Forms.TextBox TXB_ingProd2;
        private System.Windows.Forms.Label LBL_ingProd4;
        private System.Windows.Forms.Label LBL_ingProd5;
        private System.Windows.Forms.Label LBL_ingProd7;
        private System.Windows.Forms.ComboBox CMB_ingProd3;
        private System.Windows.Forms.CheckBox CHB_ingProd1;
    }
}