namespace floyd_algoritması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtn_txtbox = new System.Windows.Forms.RadioButton();
            this.rdBtn_tablo = new System.Windows.Forms.RadioButton();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.btn_basla = new System.Windows.Forms.Button();
            this.txt_dugumSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_Sonuc = new System.Windows.Forms.GroupBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txt_ikinciDugum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_birinciDugum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBox_matrisDoldur = new System.Windows.Forms.GroupBox();
            this.btn_tamam = new System.Windows.Forms.Button();
            this.txt_matrisDegeri = new System.Windows.Forms.TextBox();
            this.lbl_dugumNo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kMatrisi = new System.Windows.Forms.Button();
            this.lbl_matrisInfo = new System.Windows.Forms.Label();
            this.btn_dMatrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBox_Sonuc.SuspendLayout();
            this.grpBox_matrisDoldur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurallar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(876, 93);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 458);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtn_txtbox);
            this.groupBox2.Controls.Add(this.rdBtn_tablo);
            this.groupBox2.Controls.Add(this.btn_vazgec);
            this.groupBox2.Controls.Add(this.btn_basla);
            this.groupBox2.Controls.Add(this.txt_dugumSayisi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // rdBtn_txtbox
            // 
            this.rdBtn_txtbox.AutoSize = true;
            this.rdBtn_txtbox.Location = new System.Drawing.Point(149, 57);
            this.rdBtn_txtbox.Name = "rdBtn_txtbox";
            this.rdBtn_txtbox.Size = new System.Drawing.Size(143, 17);
            this.rdBtn_txtbox.TabIndex = 5;
            this.rdBtn_txtbox.TabStop = true;
            this.rdBtn_txtbox.Text = "Matrisi TextBox\'da doldur";
            this.rdBtn_txtbox.UseVisualStyleBackColor = true;
            // 
            // rdBtn_tablo
            // 
            this.rdBtn_tablo.AutoSize = true;
            this.rdBtn_tablo.Location = new System.Drawing.Point(10, 57);
            this.rdBtn_tablo.Name = "rdBtn_tablo";
            this.rdBtn_tablo.Size = new System.Drawing.Size(131, 17);
            this.rdBtn_tablo.TabIndex = 4;
            this.rdBtn_tablo.TabStop = true;
            this.rdBtn_tablo.Text = "Matrisi Tabloda Doldur";
            this.rdBtn_tablo.UseVisualStyleBackColor = true;
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.Location = new System.Drawing.Point(210, 92);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(75, 29);
            this.btn_vazgec.TabIndex = 3;
            this.btn_vazgec.Text = "Temizle";
            this.btn_vazgec.UseVisualStyleBackColor = true;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.Transparent;
            this.btn_basla.Location = new System.Drawing.Point(129, 92);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(75, 29);
            this.btn_basla.TabIndex = 2;
            this.btn_basla.Text = "Başla";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // txt_dugumSayisi
            // 
            this.txt_dugumSayisi.Location = new System.Drawing.Point(167, 24);
            this.txt_dugumSayisi.Name = "txt_dugumSayisi";
            this.txt_dugumSayisi.Size = new System.Drawing.Size(118, 20);
            this.txt_dugumSayisi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Düğüm Sayısını Giriniz: ";
            // 
            // grpBox_Sonuc
            // 
            this.grpBox_Sonuc.Controls.Add(this.btn_hesapla);
            this.grpBox_Sonuc.Controls.Add(this.txt_ikinciDugum);
            this.grpBox_Sonuc.Controls.Add(this.label5);
            this.grpBox_Sonuc.Controls.Add(this.txt_birinciDugum);
            this.grpBox_Sonuc.Controls.Add(this.label4);
            this.grpBox_Sonuc.Controls.Add(this.label3);
            this.grpBox_Sonuc.Controls.Add(this.label2);
            this.grpBox_Sonuc.Location = new System.Drawing.Point(5, 349);
            this.grpBox_Sonuc.Name = "grpBox_Sonuc";
            this.grpBox_Sonuc.Size = new System.Drawing.Size(291, 148);
            this.grpBox_Sonuc.TabIndex = 3;
            this.grpBox_Sonuc.TabStop = false;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(210, 110);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 29);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txt_ikinciDugum
            // 
            this.txt_ikinciDugum.Location = new System.Drawing.Point(193, 65);
            this.txt_ikinciDugum.Name = "txt_ikinciDugum";
            this.txt_ikinciDugum.Size = new System.Drawing.Size(38, 20);
            this.txt_ikinciDugum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "yanlızca numarasını giriniz. ( Örn: N2 => 2)";
            // 
            // txt_birinciDugum
            // 
            this.txt_birinciDugum.Location = new System.Drawing.Point(69, 65);
            this.txt_birinciDugum.Name = "txt_birinciDugum";
            this.txt_birinciDugum.Size = new System.Drawing.Size(38, 20);
            this.txt_birinciDugum.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "2. Düğüm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1. Düğüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aralarındaki en kısa yolu bulmak istediğiniz iki düğümün";
            // 
            // grpBox_matrisDoldur
            // 
            this.grpBox_matrisDoldur.Controls.Add(this.btn_tamam);
            this.grpBox_matrisDoldur.Controls.Add(this.txt_matrisDegeri);
            this.grpBox_matrisDoldur.Controls.Add(this.lbl_dugumNo);
            this.grpBox_matrisDoldur.Enabled = false;
            this.grpBox_matrisDoldur.Location = new System.Drawing.Point(5, 256);
            this.grpBox_matrisDoldur.Name = "grpBox_matrisDoldur";
            this.grpBox_matrisDoldur.Size = new System.Drawing.Size(291, 87);
            this.grpBox_matrisDoldur.TabIndex = 4;
            this.grpBox_matrisDoldur.TabStop = false;
            // 
            // btn_tamam
            // 
            this.btn_tamam.Location = new System.Drawing.Point(210, 52);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(75, 29);
            this.btn_tamam.TabIndex = 6;
            this.btn_tamam.Text = "Tamam";
            this.btn_tamam.UseVisualStyleBackColor = true;
            this.btn_tamam.Click += new System.EventHandler(this.btn_tamam_Click);
            // 
            // txt_matrisDegeri
            // 
            this.txt_matrisDegeri.Location = new System.Drawing.Point(220, 13);
            this.txt_matrisDegeri.Name = "txt_matrisDegeri";
            this.txt_matrisDegeri.Size = new System.Drawing.Size(53, 20);
            this.txt_matrisDegeri.TabIndex = 5;
            // 
            // lbl_dugumNo
            // 
            this.lbl_dugumNo.AutoSize = true;
            this.lbl_dugumNo.Location = new System.Drawing.Point(7, 16);
            this.lbl_dugumNo.Name = "lbl_dugumNo";
            this.lbl_dugumNo.Size = new System.Drawing.Size(207, 13);
            this.lbl_dugumNo.TabIndex = 0;
            this.lbl_dugumNo.Text = "N1 -  N1 \' e/a  karşılık gelen değerini girin. ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kMatrisi);
            this.groupBox3.Controls.Add(this.lbl_matrisInfo);
            this.groupBox3.Controls.Add(this.btn_dMatrisi);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(303, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 518);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matris Tablosu";
            // 
            // btn_kMatrisi
            // 
            this.btn_kMatrisi.Location = new System.Drawing.Point(6, 483);
            this.btn_kMatrisi.Name = "btn_kMatrisi";
            this.btn_kMatrisi.Size = new System.Drawing.Size(138, 29);
            this.btn_kMatrisi.TabIndex = 10;
            this.btn_kMatrisi.Text = "Girilen değerleri Göster";
            this.btn_kMatrisi.UseVisualStyleBackColor = true;
            this.btn_kMatrisi.Click += new System.EventHandler(this.btn_kMatrisi_Click);
            // 
            // lbl_matrisInfo
            // 
            this.lbl_matrisInfo.AutoSize = true;
            this.lbl_matrisInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_matrisInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_matrisInfo.Location = new System.Drawing.Point(6, 19);
            this.lbl_matrisInfo.Name = "lbl_matrisInfo";
            this.lbl_matrisInfo.Size = new System.Drawing.Size(0, 20);
            this.lbl_matrisInfo.TabIndex = 8;
            // 
            // btn_dMatrisi
            // 
            this.btn_dMatrisi.Location = new System.Drawing.Point(150, 483);
            this.btn_dMatrisi.Name = "btn_dMatrisi";
            this.btn_dMatrisi.Size = new System.Drawing.Size(138, 29);
            this.btn_dMatrisi.TabIndex = 7;
            this.btn_dMatrisi.Text = "D Matrisini Göster";
            this.btn_dMatrisi.UseVisualStyleBackColor = true;
            this.btn_dMatrisi.Click += new System.EventHandler(this.btn_dMatrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1138, 647);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBox_matrisDoldur);
            this.Controls.Add(this.grpBox_Sonuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd Algoritması Hesaplama v1.0";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBox_Sonuc.ResumeLayout(false);
            this.grpBox_Sonuc.PerformLayout();
            this.grpBox_matrisDoldur.ResumeLayout(false);
            this.grpBox_matrisDoldur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.TextBox txt_dugumSayisi;
        private System.Windows.Forms.GroupBox grpBox_Sonuc;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_ikinciDugum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_birinciDugum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBox_matrisDoldur;
        private System.Windows.Forms.Button btn_tamam;
        private System.Windows.Forms.TextBox txt_matrisDegeri;
        private System.Windows.Forms.Label lbl_dugumNo;
        private System.Windows.Forms.RadioButton rdBtn_txtbox;
        private System.Windows.Forms.RadioButton rdBtn_tablo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_matrisInfo;
        private System.Windows.Forms.Button btn_dMatrisi;
        private System.Windows.Forms.Button btn_kMatrisi;
    }
}

