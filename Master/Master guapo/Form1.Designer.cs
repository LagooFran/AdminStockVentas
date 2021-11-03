namespace Master_guapo
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
            this.TXB_admin1 = new System.Windows.Forms.TextBox();
            this.TXB_admin2 = new System.Windows.Forms.TextBox();
            this.LBL_admin1 = new System.Windows.Forms.Label();
            this.LBL_admin2 = new System.Windows.Forms.Label();
            this.LBL_admin3 = new System.Windows.Forms.Label();
            this.LBL_admin4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TXB_admin3 = new System.Windows.Forms.TextBox();
            this.TXB_admin4 = new System.Windows.Forms.TextBox();
            this.LBL_admin5 = new System.Windows.Forms.Label();
            this.LBL_admin6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_admin1
            // 
            this.TXB_admin1.Location = new System.Drawing.Point(26, 99);
            this.TXB_admin1.Name = "TXB_admin1";
            this.TXB_admin1.Size = new System.Drawing.Size(151, 20);
            this.TXB_admin1.TabIndex = 0;
            // 
            // TXB_admin2
            // 
            this.TXB_admin2.Location = new System.Drawing.Point(26, 138);
            this.TXB_admin2.Name = "TXB_admin2";
            this.TXB_admin2.PasswordChar = '*';
            this.TXB_admin2.Size = new System.Drawing.Size(151, 20);
            this.TXB_admin2.TabIndex = 1;
            // 
            // LBL_admin1
            // 
            this.LBL_admin1.AutoSize = true;
            this.LBL_admin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_admin1.Location = new System.Drawing.Point(23, 25);
            this.LBL_admin1.Name = "LBL_admin1";
            this.LBL_admin1.Size = new System.Drawing.Size(105, 24);
            this.LBL_admin1.TabIndex = 2;
            this.LBL_admin1.Text = "Bienvenido";
            // 
            // LBL_admin2
            // 
            this.LBL_admin2.AutoSize = true;
            this.LBL_admin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_admin2.Location = new System.Drawing.Point(23, 49);
            this.LBL_admin2.Name = "LBL_admin2";
            this.LBL_admin2.Size = new System.Drawing.Size(226, 16);
            this.LBL_admin2.TabIndex = 3;
            this.LBL_admin2.Text = "Cree un nuevo usuario administrador";
            // 
            // LBL_admin3
            // 
            this.LBL_admin3.AutoSize = true;
            this.LBL_admin3.Location = new System.Drawing.Point(27, 80);
            this.LBL_admin3.Name = "LBL_admin3";
            this.LBL_admin3.Size = new System.Drawing.Size(43, 13);
            this.LBL_admin3.TabIndex = 4;
            this.LBL_admin3.Text = "Usuario";
            // 
            // LBL_admin4
            // 
            this.LBL_admin4.AutoSize = true;
            this.LBL_admin4.Location = new System.Drawing.Point(27, 122);
            this.LBL_admin4.Name = "LBL_admin4";
            this.LBL_admin4.Size = new System.Drawing.Size(61, 13);
            this.LBL_admin4.TabIndex = 5;
            this.LBL_admin4.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXB_admin3
            // 
            this.TXB_admin3.Location = new System.Drawing.Point(26, 177);
            this.TXB_admin3.Name = "TXB_admin3";
            this.TXB_admin3.Size = new System.Drawing.Size(151, 20);
            this.TXB_admin3.TabIndex = 7;
            // 
            // TXB_admin4
            // 
            this.TXB_admin4.Location = new System.Drawing.Point(26, 216);
            this.TXB_admin4.Name = "TXB_admin4";
            this.TXB_admin4.Size = new System.Drawing.Size(150, 20);
            this.TXB_admin4.TabIndex = 8;
            // 
            // LBL_admin5
            // 
            this.LBL_admin5.AutoSize = true;
            this.LBL_admin5.Location = new System.Drawing.Point(27, 161);
            this.LBL_admin5.Name = "LBL_admin5";
            this.LBL_admin5.Size = new System.Drawing.Size(26, 13);
            this.LBL_admin5.TabIndex = 9;
            this.LBL_admin5.Text = "DNI";
            // 
            // LBL_admin6
            // 
            this.LBL_admin6.AutoSize = true;
            this.LBL_admin6.Location = new System.Drawing.Point(27, 200);
            this.LBL_admin6.Name = "LBL_admin6";
            this.LBL_admin6.Size = new System.Drawing.Size(32, 13);
            this.LBL_admin6.TabIndex = 10;
            this.LBL_admin6.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 297);
            this.Controls.Add(this.LBL_admin6);
            this.Controls.Add(this.LBL_admin5);
            this.Controls.Add(this.TXB_admin4);
            this.Controls.Add(this.TXB_admin3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_admin4);
            this.Controls.Add(this.LBL_admin3);
            this.Controls.Add(this.LBL_admin2);
            this.Controls.Add(this.LBL_admin1);
            this.Controls.Add(this.TXB_admin2);
            this.Controls.Add(this.TXB_admin1);
            this.Name = "Form1";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_admin1;
        private System.Windows.Forms.TextBox TXB_admin2;
        private System.Windows.Forms.Label LBL_admin1;
        private System.Windows.Forms.Label LBL_admin2;
        private System.Windows.Forms.Label LBL_admin3;
        private System.Windows.Forms.Label LBL_admin4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXB_admin3;
        private System.Windows.Forms.TextBox TXB_admin4;
        private System.Windows.Forms.Label LBL_admin5;
        private System.Windows.Forms.Label LBL_admin6;
    }
}

