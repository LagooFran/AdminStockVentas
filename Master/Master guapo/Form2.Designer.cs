namespace Master_guapo
{
    partial class Form2
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
            this.LBL_login2 = new System.Windows.Forms.Label();
            this.LBL_login3 = new System.Windows.Forms.Label();
            this.LBL_login1 = new System.Windows.Forms.Label();
            this.BTN_login1 = new System.Windows.Forms.Button();
            this.TXB_login2 = new System.Windows.Forms.TextBox();
            this.TXB_login1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_login2
            // 
            this.LBL_login2.AutoSize = true;
            this.LBL_login2.Location = new System.Drawing.Point(13, 56);
            this.LBL_login2.Name = "LBL_login2";
            this.LBL_login2.Size = new System.Drawing.Size(43, 13);
            this.LBL_login2.TabIndex = 0;
            this.LBL_login2.Text = "Usuario";
            this.LBL_login2.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_login3
            // 
            this.LBL_login3.AutoSize = true;
            this.LBL_login3.Location = new System.Drawing.Point(13, 110);
            this.LBL_login3.Name = "LBL_login3";
            this.LBL_login3.Size = new System.Drawing.Size(61, 13);
            this.LBL_login3.TabIndex = 2;
            this.LBL_login3.Text = "Contraseña";
            // 
            // LBL_login1
            // 
            this.LBL_login1.AutoSize = true;
            this.LBL_login1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_login1.Location = new System.Drawing.Point(12, 18);
            this.LBL_login1.Name = "LBL_login1";
            this.LBL_login1.Size = new System.Drawing.Size(141, 24);
            this.LBL_login1.TabIndex = 6;
            this.LBL_login1.Text = "Inicio de sesion";
            this.LBL_login1.Click += new System.EventHandler(this.LBL_login1_Click);
            // 
            // BTN_login1
            // 
            this.BTN_login1.Location = new System.Drawing.Point(72, 169);
            this.BTN_login1.Name = "BTN_login1";
            this.BTN_login1.Size = new System.Drawing.Size(119, 24);
            this.BTN_login1.TabIndex = 7;
            this.BTN_login1.Text = "Iniciar";
            this.BTN_login1.UseVisualStyleBackColor = true;
            this.BTN_login1.Click += new System.EventHandler(this.BTN_login1_Click);
            // 
            // TXB_login2
            // 
            this.TXB_login2.Location = new System.Drawing.Point(16, 126);
            this.TXB_login2.Name = "TXB_login2";
            this.TXB_login2.PasswordChar = '*';
            this.TXB_login2.Size = new System.Drawing.Size(151, 20);
            this.TXB_login2.TabIndex = 8;
            // 
            // TXB_login1
            // 
            this.TXB_login1.Location = new System.Drawing.Point(16, 72);
            this.TXB_login1.Name = "TXB_login1";
            this.TXB_login1.Size = new System.Drawing.Size(151, 20);
            this.TXB_login1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 205);
            this.Controls.Add(this.TXB_login1);
            this.Controls.Add(this.TXB_login2);
            this.Controls.Add(this.BTN_login1);
            this.Controls.Add(this.LBL_login1);
            this.Controls.Add(this.LBL_login3);
            this.Controls.Add(this.LBL_login2);
            this.Name = "Form2";
            this.Text = "Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_login2;
        private System.Windows.Forms.Label LBL_login3;
        private System.Windows.Forms.Label LBL_login1;
        private System.Windows.Forms.Button BTN_login1;
        private System.Windows.Forms.TextBox TXB_login2;
        private System.Windows.Forms.TextBox TXB_login1;
    }
}