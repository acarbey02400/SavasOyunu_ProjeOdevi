/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2020-2021 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: 1. ÖDEV
** ÖĞRENCİ ADI............: İBRAHİM HALİL ACAR
** ÖĞRENCİ NUMARASI.......: B201200046
** DERSİN ALINDIĞI GRUP...: 1. ÖĞRETİM A GRUBU
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Concrete;
using Savas.Library.Enum;

namespace B201200046_IHalilAcar_ProjeOdevi
{
    public partial class Form1 : Form
    {
        private Oyun _oyun;
        

        private int zorluk { get; set; }
        public Form1()
        {
            InitializeComponent();
            
            
            _oyun = new Oyun(ucaksavarPanel, savasAlaniPanel,bilgiPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
            _oyun.skorListesi();
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (!(_oyun.DevamEdiyorMu))//Burada önceki oyunun bitmiş olması durumunda oyunu yeniden oluşturuyoruz.
                    {

                        Oyun yeniOyun = new Oyun(ucaksavarPanel, savasAlaniPanel, bilgiPanel);
                        _oyun = yeniOyun;
                        _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
                       
                    }
                    scoreLabel.Text = "0";
                    sureLabel.Text = "0:00";
                    MessageBox.Show("Oyun başladı");
                    _oyun.Baslat();
                    break;
                case Keys.P:
                    _oyun.duraklatVeyaDevamEt();
                    break;
                case Keys.Right:
                    _oyun.UcaksavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcaksavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
                case Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
           
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
            
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void savasAlaniPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void sureLabel_Click(object sender, EventArgs e)
        {

        }

        //Skor listesi için ayrı bir forma yönlendiriyoruz ve oyunu duraklatıyoruz
        private void label11_MouseClick(object sender, MouseEventArgs e) 
        {
            ScoreForm scoreForm = new ScoreForm(_oyun, label1, label2, label3, label4, label5);
            _oyun.duraklatVeyaDevamEt();
            scoreForm.ShowDialog();
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
   
}
