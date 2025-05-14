namespace KelimeEzberlemeUygulamasi
{
    partial class SoruFormu
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
            this.lbIngilizce = new System.Windows.Forms.Label();
            this.lblSoruDurum = new System.Windows.Forms.Label();
            this.btnSecenek1 = new System.Windows.Forms.Button();
            this.btnSecenek2 = new System.Windows.Forms.Button();
            this.btnSecenek3 = new System.Windows.Forms.Button();
            this.btnSecenek4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIngilizce
            // 
            this.lbIngilizce.BackColor = System.Drawing.Color.SteelBlue;
            this.lbIngilizce.Location = new System.Drawing.Point(3, 64);
            this.lbIngilizce.Name = "lbIngilizce";
            this.lbIngilizce.Size = new System.Drawing.Size(524, 69);
            this.lbIngilizce.TabIndex = 0;
            this.lbIngilizce.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSoruDurum
            // 
            this.lblSoruDurum.BackColor = System.Drawing.Color.Teal;
            this.lblSoruDurum.Location = new System.Drawing.Point(3, 5);
            this.lblSoruDurum.Name = "lblSoruDurum";
            this.lblSoruDurum.Size = new System.Drawing.Size(524, 56);
            this.lblSoruDurum.TabIndex = 1;
            // 
            // btnSecenek1
            // 
            this.btnSecenek1.Location = new System.Drawing.Point(3, 136);
            this.btnSecenek1.Name = "btnSecenek1";
            this.btnSecenek1.Size = new System.Drawing.Size(261, 81);
            this.btnSecenek1.TabIndex = 2;
            this.btnSecenek1.Text = "button1";
            this.btnSecenek1.UseVisualStyleBackColor = true;
            // 
            // btnSecenek2
            // 
            this.btnSecenek2.Location = new System.Drawing.Point(270, 136);
            this.btnSecenek2.Name = "btnSecenek2";
            this.btnSecenek2.Size = new System.Drawing.Size(257, 81);
            this.btnSecenek2.TabIndex = 3;
            this.btnSecenek2.Text = "button2";
            this.btnSecenek2.UseVisualStyleBackColor = true;
            // 
            // btnSecenek3
            // 
            this.btnSecenek3.Location = new System.Drawing.Point(3, 223);
            this.btnSecenek3.Name = "btnSecenek3";
            this.btnSecenek3.Size = new System.Drawing.Size(261, 68);
            this.btnSecenek3.TabIndex = 4;
            this.btnSecenek3.Text = "button3";
            this.btnSecenek3.UseVisualStyleBackColor = true;
            // 
            // btnSecenek4
            // 
            this.btnSecenek4.Location = new System.Drawing.Point(270, 223);
            this.btnSecenek4.Name = "btnSecenek4";
            this.btnSecenek4.Size = new System.Drawing.Size(257, 68);
            this.btnSecenek4.TabIndex = 5;
            this.btnSecenek4.Text = "button4";
            this.btnSecenek4.UseVisualStyleBackColor = true;
            // 
            // SoruFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 292);
            this.Controls.Add(this.btnSecenek4);
            this.Controls.Add(this.btnSecenek3);
            this.Controls.Add(this.btnSecenek2);
            this.Controls.Add(this.btnSecenek1);
            this.Controls.Add(this.lblSoruDurum);
            this.Controls.Add(this.lbIngilizce);
            this.Name = "SoruFormu";
            this.Text = "SoruFormu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.SoruFormu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIngilizce;
        private System.Windows.Forms.Label lblSoruDurum;
        private System.Windows.Forms.Button btnSecenek1;
        private System.Windows.Forms.Button btnSecenek2;
        private System.Windows.Forms.Button btnSecenek3;
        private System.Windows.Forms.Button btnSecenek4;
    }
}