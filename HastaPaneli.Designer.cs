
namespace ProjeDeneme_2
{
    partial class HastaPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaPaneli));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bilgi_güncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlyenirecete = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnrecetegoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrecetegönder = new System.Windows.Forms.Button();
            this.txtrecetekodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EczaneAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceteKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.pnlyenirecete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_bilgi_güncelle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 88);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // btn_bilgi_güncelle
            // 
            this.btn_bilgi_güncelle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_bilgi_güncelle.FlatAppearance.BorderSize = 0;
            this.btn_bilgi_güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bilgi_güncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgi_güncelle.Location = new System.Drawing.Point(605, 20);
            this.btn_bilgi_güncelle.Name = "btn_bilgi_güncelle";
            this.btn_bilgi_güncelle.Size = new System.Drawing.Size(186, 30);
            this.btn_bilgi_güncelle.TabIndex = 6;
            this.btn_bilgi_güncelle.Text = "Bilgilerimi Güncelle";
            this.btn_bilgi_güncelle.UseVisualStyleBackColor = false;
            this.btn_bilgi_güncelle.Click += new System.EventHandler(this.btn_bilgi_güncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "AD-SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C NO :";
            // 
            // pnlyenirecete
            // 
            this.pnlyenirecete.Controls.Add(this.label10);
            this.pnlyenirecete.Controls.Add(this.label9);
            this.pnlyenirecete.Controls.Add(this.label8);
            this.pnlyenirecete.Controls.Add(this.comboBox1);
            this.pnlyenirecete.Controls.Add(this.btnrecetegoster);
            this.pnlyenirecete.Controls.Add(this.dataGridView1);
            this.pnlyenirecete.Controls.Add(this.btnrecetegönder);
            this.pnlyenirecete.Controls.Add(this.txtrecetekodu);
            this.pnlyenirecete.Controls.Add(this.label5);
            this.pnlyenirecete.Location = new System.Drawing.Point(0, 133);
            this.pnlyenirecete.Name = "pnlyenirecete";
            this.pnlyenirecete.Size = new System.Drawing.Size(413, 331);
            this.pnlyenirecete.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(154, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ödenecek Tutar :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // btnrecetegoster
            // 
            this.btnrecetegoster.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecetegoster.Location = new System.Drawing.Point(307, 13);
            this.btnrecetegoster.Name = "btnrecetegoster";
            this.btnrecetegoster.Size = new System.Drawing.Size(81, 36);
            this.btnrecetegoster.TabIndex = 5;
            this.btnrecetegoster.Text = "Göster";
            this.btnrecetegoster.UseVisualStyleBackColor = true;
            this.btnrecetegoster.Click += new System.EventHandler(this.btnrecetegoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(372, 169);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnrecetegönder
            // 
            this.btnrecetegönder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnrecetegönder.FlatAppearance.BorderSize = 0;
            this.btnrecetegönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecetegönder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecetegönder.Location = new System.Drawing.Point(236, 242);
            this.btnrecetegönder.Name = "btnrecetegönder";
            this.btnrecetegönder.Size = new System.Drawing.Size(152, 39);
            this.btnrecetegönder.TabIndex = 3;
            this.btnrecetegönder.Text = "Reçetemi Gönder";
            this.btnrecetegönder.UseVisualStyleBackColor = false;
            this.btnrecetegönder.Click += new System.EventHandler(this.btnrecetegönder_Click);
            // 
            // txtrecetekodu
            // 
            this.txtrecetekodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrecetekodu.Location = new System.Drawing.Point(127, 19);
            this.txtrecetekodu.MaxLength = 8;
            this.txtrecetekodu.Name = "txtrecetekodu";
            this.txtrecetekodu.Size = new System.Drawing.Size(164, 22);
            this.txtrecetekodu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "REÇETE KODU :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(134, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "YENİ REÇETE";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hasta,
            this.EczaneAd,
            this.ReceteKodu,
            this.TeslimTarihi});
            this.dataGridView2.Location = new System.Drawing.Point(419, 146);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(493, 211);
            this.dataGridView2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(535, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "ÖNCEKİ REÇETELERİM";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(809, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(187, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "₺";
            // 
            // Hasta
            // 
            this.Hasta.DataPropertyName = "Hasta";
            this.Hasta.HeaderText = "Hasta Ad-Soyad";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            this.Hasta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EczaneAd
            // 
            this.EczaneAd.DataPropertyName = "EczaneAd";
            this.EczaneAd.HeaderText = "Eczane Adı";
            this.EczaneAd.Name = "EczaneAd";
            this.EczaneAd.ReadOnly = true;
            this.EczaneAd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReceteKodu
            // 
            this.ReceteKodu.DataPropertyName = "OncekiReceteKod";
            this.ReceteKodu.HeaderText = "Reçete Kodu";
            this.ReceteKodu.Name = "ReceteKodu";
            this.ReceteKodu.ReadOnly = true;
            this.ReceteKodu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.DataPropertyName = "TeslimTarihi";
            this.TeslimTarihi.HeaderText = "Sipariş Tarihi";
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.ReadOnly = true;
            // 
            // btnYenile
            // 
            this.btnYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.BackgroundImage")));
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Location = new System.Drawing.Point(850, 114);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(71, 26);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // HastaPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(921, 469);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlyenirecete);
            this.Controls.Add(this.panel3);
            this.Name = "HastaPaneli";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.HastaPaneli_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlyenirecete.ResumeLayout(false);
            this.pnlyenirecete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlyenirecete;
        private System.Windows.Forms.TextBox txtrecetekodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnrecetegoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrecetegönder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_bilgi_güncelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EczaneAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceteKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimTarihi;
        private System.Windows.Forms.Button btnYenile;
    }
}