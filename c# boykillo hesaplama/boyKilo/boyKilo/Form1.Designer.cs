namespace boyKilo
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
            this.lbl_kilo = new System.Windows.Forms.Label();
            this.lbl_boy = new System.Windows.Forms.Label();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_boy = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_kilo
            // 
            this.lbl_kilo.AutoSize = true;
            this.lbl_kilo.Location = new System.Drawing.Point(23, 70);
            this.lbl_kilo.Name = "lbl_kilo";
            this.lbl_kilo.Size = new System.Drawing.Size(80, 13);
            this.lbl_kilo.TabIndex = 0;
            this.lbl_kilo.Text = "Kilo Hesaplama";
            // 
            // lbl_boy
            // 
            this.lbl_boy.AutoSize = true;
            this.lbl_boy.Location = new System.Drawing.Point(23, 157);
            this.lbl_boy.Name = "lbl_boy";
            this.lbl_boy.Size = new System.Drawing.Size(25, 13);
            this.lbl_boy.TabIndex = 1;
            this.lbl_boy.Text = "Boy";
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(144, 67);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(100, 20);
            this.txt_kilo.TabIndex = 2;
            // 
            // txt_boy
            // 
            this.txt_boy.Location = new System.Drawing.Point(144, 150);
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.Size = new System.Drawing.Size(100, 20);
            this.txt_boy.TabIndex = 3;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(144, 201);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(50, 288);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 13);
            this.lbl_sonuc.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 415);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_boy);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.lbl_boy);
            this.Controls.Add(this.lbl_kilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kilo;
        private System.Windows.Forms.Label lbl_boy;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_boy;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

