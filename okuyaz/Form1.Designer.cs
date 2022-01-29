namespace okuyaz
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
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button29.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button29.Location = new System.Drawing.Point(-1, 125);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(199, 61);
            this.button29.TabIndex = 29;
            this.button29.Text = "Şifre Güncelle";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button30.Location = new System.Drawing.Point(-1, 30);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(199, 61);
            this.button30.TabIndex = 28;
            this.button30.Text = "Aktar";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button47.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button47.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button47.Location = new System.Drawing.Point(420, 516);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(199, 61);
            this.button47.TabIndex = 45;
            this.button47.Text = "Şifre Güncelle";
            this.button47.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(283, 260);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button47;
    }
}

