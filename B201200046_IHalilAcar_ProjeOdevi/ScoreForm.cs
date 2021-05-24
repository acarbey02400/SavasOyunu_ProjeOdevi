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

using Savas.Library.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B201200046_IHalilAcar_ProjeOdevi
{
    public partial class ScoreForm : Form
    {
        String _label1;
        String _label2;
        String _label3;
        String _label4;
        String _label5;
        Oyun _oyun;
        
        /*Her skor tablosu açılmak istendiğinde oyun ve skor değerlerini gönderilmesini istedim. 
        Aldığım değerleri kendi oluşturduğum değişkenlere atadım*/
        public ScoreForm(Oyun oyun, Label label1, Label label2, Label label3, Label label4, Label label5) 
        {
            InitializeComponent();
            _label1 = label1.Text;
            _label2 = label2.Text;
            _label3 = label3.Text;
            _label4 = label4.Text;
            _label5 = label5.Text;
            _oyun = oyun;
        }

        private void ScoreForm_Load(object sender, EventArgs e) //Kendi değişkenlerimi formdaki label'lere eşitledim
        {
            label1.Text = _label1;
            label2.Text = _label2;
            label3.Text = _label3;
            label4.Text = _label4;
            label5.Text = _label5;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        /*Skor listesine tıklarken duraklattığım oyunu tekrar devam ettirdim
         ayırca oyun başlamamışsa duraklatma işlemini yapması oyunumuzu bozabileceği için oyunun devamını kontrol ettim */ 
        private void button1_Click(object sender, EventArgs e)
{
            if ((!_oyun.DevamEdiyorMu))
            {
                
            }
            else
            {
                _oyun.duraklatVeyaDevamEt();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           Application.Exit();
        }
    }
}
