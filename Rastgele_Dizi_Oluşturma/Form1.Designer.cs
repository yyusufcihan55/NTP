namespace Rastgele_Dizi_Oluşturma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatırsayisi = new System.Windows.Forms.TextBox();
            this.txtSutunsayisi = new System.Windows.Forms.TextBox();
            this.txtDusuk = new System.Windows.Forms.TextBox();
            this.txtYuksek = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "satır sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sütün sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endusuk değer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enyuksek değer";
            // 
            // txtSatırsayisi
            // 
            this.txtSatırsayisi.Location = new System.Drawing.Point(243, 141);
            this.txtSatırsayisi.Name = "txtSatırsayisi";
            this.txtSatırsayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSatırsayisi.TabIndex = 4;
            // 
            // txtSutunsayisi
            // 
            this.txtSutunsayisi.Location = new System.Drawing.Point(243, 174);
            this.txtSutunsayisi.Name = "txtSutunsayisi";
            this.txtSutunsayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSutunsayisi.TabIndex = 5;
            // 
            // txtDusuk
            // 
            this.txtDusuk.Location = new System.Drawing.Point(244, 201);
            this.txtDusuk.Name = "txtDusuk";
            this.txtDusuk.Size = new System.Drawing.Size(100, 20);
            this.txtDusuk.TabIndex = 6;
            // 
            // txtYuksek
            // 
            this.txtYuksek.Location = new System.Drawing.Point(249, 231);
            this.txtYuksek.Name = "txtYuksek";
            this.txtYuksek.Size = new System.Drawing.Size(100, 20);
            this.txtYuksek.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(509, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 632);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYuksek);
            this.Controls.Add(this.txtDusuk);
            this.Controls.Add(this.txtSutunsayisi);
            this.Controls.Add(this.txtSatırsayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatırsayisi;
        private System.Windows.Forms.TextBox txtSutunsayisi;
        private System.Windows.Forms.TextBox txtDusuk;
        private System.Windows.Forms.TextBox txtYuksek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

