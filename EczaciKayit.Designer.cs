
namespace ProjeDeneme_2
{
    partial class EczaciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczaciKayit));
            this.btnEczacıK = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.richAdres = new System.Windows.Forms.RichTextBox();
            this.mskDiploma = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txteczacisifre = new System.Windows.Forms.TextBox();
            this.dogrulanmadi = new System.Windows.Forms.Label();
            this.dogrulandi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEczanead = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEczacıK
            // 
            this.btnEczacıK.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEczacıK.FlatAppearance.BorderSize = 0;
            this.btnEczacıK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEczacıK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnEczacıK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEczacıK.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEczacıK.ForeColor = System.Drawing.Color.Black;
            this.btnEczacıK.Location = new System.Drawing.Point(247, 286);
            this.btnEczacıK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEczacıK.Name = "btnEczacıK";
            this.btnEczacıK.Size = new System.Drawing.Size(119, 38);
            this.btnEczacıK.TabIndex = 11;
            this.btnEczacıK.Text = "Kayıt Ol";
            this.btnEczacıK.UseVisualStyleBackColor = false;
            this.btnEczacıK.Click += new System.EventHandler(this.btnEczacıK_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(186, 43);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 26);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(186, 93);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 26);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(186, 138);
            this.mskTC.Margin = new System.Windows.Forms.Padding(2);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(167, 26);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(186, 185);
            this.mskTel.Margin = new System.Windows.Forms.Padding(2);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(167, 26);
            this.mskTel.TabIndex = 4;
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnKontrol.FlatAppearance.BorderSize = 0;
            this.btnKontrol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnKontrol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontrol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnKontrol.Location = new System.Drawing.Point(252, 316);
            this.btnKontrol.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(100, 31);
            this.btnKontrol.TabIndex = 7;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "T.C. No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Diploma Barkodu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(50, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Şehir :";
            // 
            // cmbSehir
            // 
            this.cmbSehir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(118, 93);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(248, 29);
            this.cmbSehir.TabIndex = 9;
            // 
            // richAdres
            // 
            this.richAdres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richAdres.Location = new System.Drawing.Point(117, 132);
            this.richAdres.Name = "richAdres";
            this.richAdres.Size = new System.Drawing.Size(248, 146);
            this.richAdres.TabIndex = 10;
            this.richAdres.Text = "";
            // 
            // mskDiploma
            // 
            this.mskDiploma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDiploma.Location = new System.Drawing.Point(186, 273);
            this.mskDiploma.Margin = new System.Windows.Forms.Padding(2);
            this.mskDiploma.Mask = "0000000000";
            this.mskDiploma.Name = "mskDiploma";
            this.mskDiploma.Size = new System.Drawing.Size(100, 26);
            this.mskDiploma.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txteczacisifre);
            this.groupBox1.Controls.Add(this.dogrulanmadi);
            this.groupBox1.Controls.Add(this.dogrulandi);
            this.groupBox1.Controls.Add(this.mskDiploma);
            this.groupBox1.Controls.Add(this.btnKontrol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskTel);
            this.groupBox1.Location = new System.Drawing.Point(27, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 355);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(128, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Şifre :";
            // 
            // txteczacisifre
            // 
            this.txteczacisifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteczacisifre.Location = new System.Drawing.Point(186, 232);
            this.txteczacisifre.Margin = new System.Windows.Forms.Padding(2);
            this.txteczacisifre.MaxLength = 10;
            this.txteczacisifre.Name = "txteczacisifre";
            this.txteczacisifre.Size = new System.Drawing.Size(167, 26);
            this.txteczacisifre.TabIndex = 20;
            // 
            // dogrulanmadi
            // 
            this.dogrulanmadi.AutoSize = true;
            this.dogrulanmadi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulanmadi.Location = new System.Drawing.Point(58, 323);
            this.dogrulanmadi.Name = "dogrulanmadi";
            this.dogrulanmadi.Size = new System.Drawing.Size(112, 17);
            this.dogrulanmadi.TabIndex = 19;
            this.dogrulanmadi.Text = "Doğrulanamadı !";
            this.dogrulanmadi.Visible = false;
            // 
            // dogrulandi
            // 
            this.dogrulandi.AutoSize = true;
            this.dogrulandi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulandi.Location = new System.Drawing.Point(58, 323);
            this.dogrulandi.Name = "dogrulandi";
            this.dogrulandi.Size = new System.Drawing.Size(86, 17);
            this.dogrulandi.TabIndex = 18;
            this.dogrulandi.Text = "Doğrulandı !";
            this.dogrulandi.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEczanead);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.richAdres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEczacıK);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbSehir);
            this.groupBox2.Location = new System.Drawing.Point(455, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 355);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // txtEczanead
            // 
            this.txtEczanead.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEczanead.Location = new System.Drawing.Point(118, 59);
            this.txtEczanead.Margin = new System.Windows.Forms.Padding(2);
            this.txtEczanead.Name = "txtEczanead";
            this.txtEczanead.Size = new System.Drawing.Size(247, 26);
            this.txtEczanead.TabIndex = 8;
            this.txtEczanead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEczanead_KeyPress);
            this.txtEczanead.Leave += new System.EventHandler(this.txtEczanead_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Eczane Adı :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(117, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 88);
            this.panel1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(272, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(365, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "ECZACI KAYIT OLUŞTURMA";
            // 
            // EczaciKayit
            // 
            this.AcceptButton = this.btnEczacıK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "EczaciKayit";
            this.Text = "Eczacı Kayıt Paneli";
            this.Load += new System.EventHandler(this.EczaciKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEczacıK;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.RichTextBox richAdres;
        private System.Windows.Forms.MaskedTextBox mskDiploma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dogrulanmadi;
        private System.Windows.Forms.Label dogrulandi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txteczacisifre;
        private System.Windows.Forms.TextBox txtEczanead;
        private System.Windows.Forms.Label label11;
    }
}