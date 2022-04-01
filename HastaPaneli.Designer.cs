
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlyenirecete = new System.Windows.Forms.Panel();
            this.btnrecetegoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrecetegönder = new System.Windows.Forms.Button();
            this.txtrecetekodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.btn_bilgi_guncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlyenirecete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(177)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.btn_bilgi_guncelle);
            this.panel1.Controls.Add(this.btn_cıkıs);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.pnlyenirecete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 489);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(123, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "YENİ REÇETE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(504, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "ÖNCEKİ REÇETELER";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(410, 162);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(370, 238);
            this.dataGridView2.TabIndex = 3;
            // 
            // pnlyenirecete
            // 
            this.pnlyenirecete.Controls.Add(this.btnrecetegoster);
            this.pnlyenirecete.Controls.Add(this.dataGridView1);
            this.pnlyenirecete.Controls.Add(this.btnrecetegönder);
            this.pnlyenirecete.Controls.Add(this.txtrecetekodu);
            this.pnlyenirecete.Controls.Add(this.label5);
            this.pnlyenirecete.Location = new System.Drawing.Point(6, 146);
            this.pnlyenirecete.Name = "pnlyenirecete";
            this.pnlyenirecete.Size = new System.Drawing.Size(398, 340);
            this.pnlyenirecete.TabIndex = 2;
            // 
            // btnrecetegoster
            // 
            this.btnrecetegoster.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecetegoster.Location = new System.Drawing.Point(303, 16);
            this.btnrecetegoster.Name = "btnrecetegoster";
            this.btnrecetegoster.Size = new System.Drawing.Size(81, 36);
            this.btnrecetegoster.TabIndex = 5;
            this.btnrecetegoster.Text = "Göster";
            this.btnrecetegoster.UseVisualStyleBackColor = true;
            this.btnrecetegoster.Click += new System.EventHandler(this.btnrecetegoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 183);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnrecetegönder
            // 
            this.btnrecetegönder.BackColor = System.Drawing.Color.YellowGreen;
            this.btnrecetegönder.FlatAppearance.BorderSize = 0;
            this.btnrecetegönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecetegönder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecetegönder.Location = new System.Drawing.Point(122, 278);
            this.btnrecetegönder.Name = "btnrecetegönder";
            this.btnrecetegönder.Size = new System.Drawing.Size(152, 39);
            this.btnrecetegönder.TabIndex = 3;
            this.btnrecetegönder.Text = "Reçetemi Gönder";
            this.btnrecetegönder.UseVisualStyleBackColor = false;
            // 
            // txtrecetekodu
            // 
            this.txtrecetekodu.Location = new System.Drawing.Point(131, 24);
            this.txtrecetekodu.MaxLength = 8;
            this.txtrecetekodu.Name = "txtrecetekodu";
            this.txtrecetekodu.Size = new System.Drawing.Size(161, 20);
            this.txtrecetekodu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "REÇETE KODU:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 88);
            this.panel3.TabIndex = 1;
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_cıkıs.FlatAppearance.BorderSize = 0;
            this.btn_cıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cıkıs.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cıkıs.ForeColor = System.Drawing.Color.White;
            this.btn_cıkıs.Location = new System.Drawing.Point(661, 430);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(98, 33);
            this.btn_cıkıs.TabIndex = 6;
            this.btn_cıkıs.Text = "Çıkış";
            this.btn_cıkıs.UseVisualStyleBackColor = false;
            // 
            // btn_bilgi_guncelle
            // 
            this.btn_bilgi_guncelle.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_bilgi_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_bilgi_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bilgi_guncelle.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bilgi_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_bilgi_guncelle.Location = new System.Drawing.Point(450, 430);
            this.btn_bilgi_guncelle.Name = "btn_bilgi_guncelle";
            this.btn_bilgi_guncelle.Size = new System.Drawing.Size(168, 33);
            this.btn_bilgi_guncelle.TabIndex = 5;
            this.btn_bilgi_guncelle.Text = "Bilgilerimi Güncelle";
            this.btn_bilgi_guncelle.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(175, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "AD-SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(200, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C NO :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 88);
            this.panel2.TabIndex = 0;
            // 
            // HastaPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(799, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "HastaPaneli";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.HastaPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlyenirecete.ResumeLayout(false);
            this.pnlyenirecete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlyenirecete;
        private System.Windows.Forms.TextBox txtrecetekodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnrecetegoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrecetegönder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.Button btn_bilgi_guncelle;
    }
}