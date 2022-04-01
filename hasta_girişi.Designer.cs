
namespace ProjeDeneme_2
{
    partial class hasta_girişi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msked_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(132, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE :";
            // 
            // msked_tc
            // 
            this.msked_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msked_tc.Location = new System.Drawing.Point(138, 108);
            this.msked_tc.Name = "msked_tc";
            this.msked_tc.Size = new System.Drawing.Size(215, 35);
            this.msked_tc.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(138, 157);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(215, 35);
            this.txt_sifre.TabIndex = 4;
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btn_kaydol.FlatAppearance.BorderSize = 0;
            this.btn_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydol.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydol.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kaydol.Location = new System.Drawing.Point(122, 226);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(99, 43);
            this.btn_kaydol.TabIndex = 5;
            this.btn_kaydol.Text = "Kaydol";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_giris.Location = new System.Drawing.Point(254, 226);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(99, 43);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            // 
            // hasta_girişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(453, 322);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.msked_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hasta_girişi";
            this.Text = "hasta_girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msked_tc;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.Button btn_giris;
    }
}