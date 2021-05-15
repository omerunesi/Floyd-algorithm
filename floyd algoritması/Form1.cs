using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floyd_algoritması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int dugumSayisi;
        public string sonsuz = "s";
        public const int inf = 99999;

        public int[,] kullaniciMatrisi;
        public int[,] Smatrisi;
        public int[,] Dmatrisi;
        public int i = 0, j = 1;
        public int x = 0, y = 0;

        private void btn_basla_Click(object sender, EventArgs e)
        {
            dugumSayisi = int.Parse(txt_dugumSayisi.Text);
            kullaniciMatrisi = new int[dugumSayisi, dugumSayisi];

            if (rdBtn_txtbox.Checked)
            {
                grpBox_matrisDoldur.Enabled = true;
                dataGridView1.ReadOnly = true;
                btn_basla.Enabled = false;
                txt_dugumSayisi.Enabled = false;
                rdBtn_tablo.Enabled = false;
                rdBtn_txtbox.Enabled = false;

                for (int i = 0; i < dugumSayisi; i++)
                {
                    dataGridView1.ColumnCount = dugumSayisi + 1;
                    dataGridView1.Columns[i + 1].Name = "N" + (i + 1).ToString();
                    dataGridView1.Columns[i + 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    object x = "N" + (i + 1);
                    dataGridView1.Rows.Add(x);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (rdBtn_tablo.Checked)
            {
                btn_basla.Enabled = false;
                txt_dugumSayisi.Enabled = false;
                rdBtn_tablo.Enabled = false;
                rdBtn_txtbox.Enabled = false;

                for (int i = 0; i < dugumSayisi; i++)
                {
                    dataGridView1.ColumnCount = dugumSayisi + 1;
                    dataGridView1.Columns[i + 1].Name = "N" + (i + 1).ToString();
                    dataGridView1.Columns[i + 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    object x = "N" + (i + 1);
                    dataGridView1.Rows.Add(x);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int baslangıcDugumu = int.Parse(txt_birinciDugum.Text);
            int varisDugumu = int.Parse(txt_ikinciDugum.Text);

            int mesafe = Dmatrisi[baslangıcDugumu - 1, varisDugumu - 1];

            MessageBox.Show("N" + baslangıcDugumu + " ile N" + varisDugumu + "  arasında ki en kısa mesafenin uzunluğu: \n => " + mesafe);
        }

        private void btn_dMatrisi_Click(object sender, EventArgs e)
        {
            if (rdBtn_txtbox.Checked)
            {
                // kullanıcıdan alınan verileri dMatrisine atma:
                Dmatrisi = new int[dugumSayisi, dugumSayisi];
                for (int i = 0; i < dugumSayisi; i++)
                {
                    for (int j = 0; j < dugumSayisi; j++)
                    {
                        Dmatrisi[i, j] = kullaniciMatrisi[i, j];
                    }
                }
                for (int k = 0; k < dugumSayisi; ++k)
                {
                    for (int i = 0; i < dugumSayisi; ++i)
                    {
                        for (int j = 0; j < dugumSayisi; ++j)
                        {
                            if (Dmatrisi[i, k] + Dmatrisi[k, j] < Dmatrisi[i, j])
                                Dmatrisi[i, j] = Dmatrisi[i, k] + Dmatrisi[k, j];
                        }
                    }
                }
                for (int i = 0; i < dugumSayisi; i++)
                {
                    for (int j = 0; j < dugumSayisi; j++)
                    {
                        if (Dmatrisi[i, j] == inf)
                        {
                            dataGridView1[i + 1, j].Value = "∞";
                            dataGridView1[i + 1, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        else
                        {
                            dataGridView1[i + 1, j].Value = Dmatrisi[i, j];
                            dataGridView1[i + 1, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
                lbl_matrisInfo.Text = "D MATRİSİ:";
            }
            else if (rdBtn_tablo.Checked)
            {
                for (int i = 0; i < dugumSayisi; i++)
                {
                    for (int j = 0; j < dugumSayisi; j++)
                    {
                        if (dataGridView1[i + 1, j].Value.ToString().ToLower() == "s" || dataGridView1[i + 1, j].Value.ToString().ToLower() == "∞")
                        {
                            kullaniciMatrisi[i, j] = inf;
                        }
                        else
                        {
                            kullaniciMatrisi[i, j] = Int32.Parse(dataGridView1[i + 1, j].Value.ToString());
                        }
                    }
                }
                Dmatrisi = new int[dugumSayisi, dugumSayisi];
                for (int i = 0; i < dugumSayisi; i++)
                {
                    for (int j = 0; j < dugumSayisi; j++)
                    {
                        Dmatrisi[i, j] = kullaniciMatrisi[i, j];
                    }
                }
                for (int k = 0; k < dugumSayisi; ++k)
                {
                    for (int i = 0; i < dugumSayisi; ++i)
                    {
                        for (int j = 0; j < dugumSayisi; ++j)
                        {
                            if (Dmatrisi[i, k] + Dmatrisi[k, j] < Dmatrisi[i, j])
                                Dmatrisi[i, j] = Dmatrisi[i, k] + Dmatrisi[k, j];
                        }
                    }
                }
                for (int i = 0; i < dugumSayisi; i++)
                {
                    for (int j = 0; j < dugumSayisi; j++)
                    {
                        if (Dmatrisi[i, j] == inf)
                        {
                            dataGridView1[i + 1, j].Value = "∞";
                            dataGridView1[i + 1, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        else
                        {
                            dataGridView1[i + 1, j].Value = Dmatrisi[i, j];
                            dataGridView1[i + 1, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
                lbl_matrisInfo.Text = "D MATRİSİ:";
            }
        }

        private void btn_kMatrisi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dugumSayisi; i++)
            {
                for (int j = 0; j < dugumSayisi; j++)
                {
                    if (kullaniciMatrisi[i, j] == inf)
                    {
                        dataGridView1[i + 1, j].Value = "∞";
                        dataGridView1[i + 1, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        dataGridView1[i + 1, j].Value = kullaniciMatrisi[i, j];
                        dataGridView1[i + 1, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
                lbl_matrisInfo.Text = "GİRLEN DEĞERLER:";
            }
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            grpBox_matrisDoldur.Enabled = false;
            dataGridView1.ReadOnly = false;
            rdBtn_txtbox.Enabled = true;
            rdBtn_tablo.Enabled = true;
            txt_dugumSayisi.Enabled = true;
            btn_basla.Enabled = true;
            btn_tamam.Enabled = true;
            txt_dugumSayisi.Text = null;
            txt_birinciDugum.Text = null;
            txt_ikinciDugum.Text = null;
            txt_matrisDegeri.Text = null;
            i = 0;
            j = 1;
            lbl_dugumNo.Text = "N1 -  N1 ' e/a  karşılık gelen değerini girin. ";
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            if (i != dugumSayisi)
            {
                if (j != dugumSayisi + 1)
                {

                    if (txt_matrisDegeri.Text.ToLower() == "s")
                    {
                        kullaniciMatrisi[x, y] = inf;
                    }
                    else
                    {
                        kullaniciMatrisi[x, y] = int.Parse(txt_matrisDegeri.Text);
                    }
                    dataGridView1[j, i].Value = txt_matrisDegeri.Text;
                    txt_matrisDegeri.Text = null;
                    j++;
                    y++;
                    if (j == dugumSayisi + 1)
                    {
                        j = 1;
                        i++;
                        y = 0;
                        x++;
                        if (i == dugumSayisi)
                        {
                            btn_tamam.Enabled = false;
                            i = 0;
                            j = 1;
                            x = 0;
                            y = 0;
                        }
                    }
                    lbl_dugumNo.Text = "N" + (i + 1).ToString() + " - N" + j + " ' e/a  karşılık gelen değerini girin. ";
                }
            }
        }
    }
}
