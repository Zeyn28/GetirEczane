
namespace ProjeDeneme_2
{
    partial class hasta_kayıt_ekleme
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskd_tc = new System.Windows.Forms.MaskedTextBox();
            this.mskd_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_soyad = new System.Windows.Forms.TextBox();
            this.txtbox_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbbox_sehir = new System.Windows.Forms.ComboBox();
            this.rtxtbox_adres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kayıt_ol = new System.Windows.Forms.Button();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 88);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA KAYIT OLUŞTURMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskd_tc);
            this.groupBox1.Controls.Add(this.mskd_tel);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbox_soyad);
            this.groupBox1.Controls.Add(this.txtbox_ad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(51, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 298);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİSEL BİLGİLER";
            // 
            // mskd_tc
            // 
            this.mskd_tc.Location = new System.Drawing.Point(90, 195);
            this.mskd_tc.Mask = "00000000000";
            this.mskd_tc.Name = "mskd_tc";
            this.mskd_tc.Size = new System.Drawing.Size(161, 29);
            this.mskd_tc.TabIndex = 4;
            this.mskd_tc.ValidatingType = typeof(int);
            // 
            // mskd_tel
            // 
            this.mskd_tel.Location = new System.Drawing.Point(90, 145);
            this.mskd_tel.Mask = "(999) 000-0000";
            this.mskd_tel.Name = "mskd_tel";
            this.mskd_tel.Size = new System.Drawing.Size(160, 29);
            this.mskd_tel.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(90, 247);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(162, 24);
            this.txt_sifre.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "ŞİFRE :";
            // 
            // txtbox_soyad
            // 
            this.txtbox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_soyad.Location = new System.Drawing.Point(90, 97);
            this.txtbox_soyad.Name = "txtbox_soyad";
            this.txtbox_soyad.Size = new System.Drawing.Size(162, 24);
            this.txtbox_soyad.TabIndex = 2;
            this.txtbox_soyad.Leave += new System.EventHandler(this.txtbox_soyad_Leave);
            // 
            // txtbox_ad
            // 
            this.txtbox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_ad.Location = new System.Drawing.Point(88, 56);
            this.txtbox_ad.Name = "txtbox_ad";
            this.txtbox_ad.Size = new System.Drawing.Size(162, 24);
            this.txtbox_ad.TabIndex = 1;
            this.txtbox_ad.Leave += new System.EventHandler(this.txtbox_ad_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "T.C NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "TEL. NO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbbox_sehir);
            this.groupBox2.Controls.Add(this.rtxtbox_adres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(376, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADRES BİLGİLERİ";
            // 
            // cmbbox_sehir
            // 
            this.cmbbox_sehir.FormattingEnabled = true;
            this.cmbbox_sehir.Location = new System.Drawing.Point(104, 40);
            this.cmbbox_sehir.Name = "cmbbox_sehir";
            this.cmbbox_sehir.Size = new System.Drawing.Size(210, 30);
            this.cmbbox_sehir.TabIndex = 5;
            // 
            // rtxtbox_adres
            // 
            this.rtxtbox_adres.Location = new System.Drawing.Point(104, 87);
            this.rtxtbox_adres.Name = "rtxtbox_adres";
            this.rtxtbox_adres.Size = new System.Drawing.Size(261, 108);
            this.rtxtbox_adres.TabIndex = 6;
            this.rtxtbox_adres.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "ŞEHİR :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "ADRES :";
            // 
            // btn_kayıt_ol
            // 
            this.btn_kayıt_ol.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_kayıt_ol.FlatAppearance.BorderSize = 0;
            this.btn_kayıt_ol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayıt_ol.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt_ol.ForeColor = System.Drawing.Color.Black;
            this.btn_kayıt_ol.Location = new System.Drawing.Point(615, 355);
            this.btn_kayıt_ol.Name = "btn_kayıt_ol";
            this.btn_kayıt_ol.Size = new System.Drawing.Size(126, 45);
            this.btn_kayıt_ol.TabIndex = 5;
            this.btn_kayıt_ol.Text = "Kayıt Ol";
            this.btn_kayıt_ol.UseVisualStyleBackColor = false;
            this.btn_kayıt_ol.Click += new System.EventHandler(this.btn_kayıt_ol_Click);
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_vazgec.FlatAppearance.BorderSize = 0;
            this.btn_vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vazgec.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vazgec.ForeColor = System.Drawing.Color.Black;
            this.btn_vazgec.Location = new System.Drawing.Point(450, 355);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(126, 45);
            this.btn_vazgec.TabIndex = 6;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.UseVisualStyleBackColor = false;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // hasta_kayıt_ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.btn_kayıt_ol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "hasta_kayıt_ekleme";
            this.Text = "hasta_kayıt_ekleme";
            this.Load += new System.EventHandler(this.hasta_kayıt_ekleme_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbox_soyad;
        private System.Windows.Forms.TextBox txtbox_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtbox_adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbox_sehir;
        private System.Windows.Forms.Button btn_kayıt_ol;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.MaskedTextBox mskd_tc;
        private System.Windows.Forms.MaskedTextBox mskd_tel;
    }
}