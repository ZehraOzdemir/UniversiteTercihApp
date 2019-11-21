namespace UniversiteTercihApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtosure = new System.Windows.Forms.TextBox();
            this.txtpturu = new System.Windows.Forms.TextBox();
            this.txtdozel = new System.Windows.Forms.TextBox();
            this.txtuadi = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.ogrnbul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üniversite Adı\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenim Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puan Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Devlet Özel";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txtosure
            // 
            this.txtosure.Location = new System.Drawing.Point(175, 176);
            this.txtosure.Name = "txtosure";
            this.txtosure.Size = new System.Drawing.Size(100, 20);
            this.txtosure.TabIndex = 8;
            // 
            // txtpturu
            // 
            this.txtpturu.Location = new System.Drawing.Point(175, 203);
            this.txtpturu.Name = "txtpturu";
            this.txtpturu.Size = new System.Drawing.Size(100, 20);
            this.txtpturu.TabIndex = 9;
            // 
            // txtdozel
            // 
            this.txtdozel.Location = new System.Drawing.Point(175, 229);
            this.txtdozel.Name = "txtdozel";
            this.txtdozel.Size = new System.Drawing.Size(100, 20);
            this.txtdozel.TabIndex = 10;
            // 
            // txtuadi
            // 
            this.txtuadi.Location = new System.Drawing.Point(175, 111);
            this.txtuadi.Name = "txtuadi";
            this.txtuadi.Size = new System.Drawing.Size(100, 20);
            this.txtuadi.TabIndex = 11;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(385, 267);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(118, 57);
            this.ekle.TabIndex = 12;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // ogrnbul
            // 
            this.ogrnbul.Location = new System.Drawing.Point(535, 267);
            this.ogrnbul.Name = "ogrnbul";
            this.ogrnbul.Size = new System.Drawing.Size(107, 57);
            this.ogrnbul.TabIndex = 13;
            this.ogrnbul.Text = "ÖĞRENCİ BUL";
            this.ogrnbul.UseVisualStyleBackColor = true;
            this.ogrnbul.Click += new System.EventHandler(this.Ogrnbul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ogrnbul);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.txtuadi);
            this.Controls.Add(this.txtdozel);
            this.Controls.Add(this.txtpturu);
            this.Controls.Add(this.txtosure);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtosure;
        private System.Windows.Forms.TextBox txtpturu;
        private System.Windows.Forms.TextBox txtdozel;
        private System.Windows.Forms.TextBox txtuadi;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button ogrnbul;
    }
}

