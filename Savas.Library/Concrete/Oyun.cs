using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Enum;
using Savas.Library.Interface;
using System.IO;


namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar
        
        private bool _oyunuDuraklat = false;
        private int _skor = 0;
        private int _level = 1;
        private int _alinacakSkor;
        private bool _oyunDuraklatma = false;
        private readonly Panel bilgiPaneli;
        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 70 };
        private readonly Timer _ucakOlusturmaTimer = new Timer { Interval = 2000 };
        private TimeSpan _gecenSure;
        private readonly Panel _ucaksavarPanel;
        private readonly Panel _savasAlaniPanel;
        private readonly Panel _bilgiPaneli;
        private Ucaksavar _ucaksavar;
        private readonly List<Mermi> _mermiler = new List<Mermi>();
        private readonly List<Ucak> _ucaklar = new List<Ucak>();


        #endregion

        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion

        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;

                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }
        public int Skor
        {
            get => _skor;
            private set => _skor += value;
        }
        public int Level
        {
            get => _level;
            private set => _level = value;
        }
        public bool Duraklatma
        {
            get => _oyunDuraklatma;
            set => _oyunDuraklatma = value;
        }
        public bool OyunuDuraklat
        {
            get => _oyunuDuraklat;
            set => _oyunuDuraklat = value;
        }

        #endregion

        #region Metotlar

        public Oyun(Panel ucaksavarPanel, Panel savasAlaniPanel, Panel bilgiPaneli)
        {
            _ucaksavarPanel = ucaksavarPanel;
            _savasAlaniPanel = savasAlaniPanel;
            _bilgiPaneli = bilgiPaneli;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _ucakOlusturmaTimer.Tick += UcakOlusturmaTimer_Tick;
            _alinacakSkor = 25;
            Level = 1;
            
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            if (OyunuDuraklat) return;
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            if (OyunuDuraklat) return;
            MermileriHareketEttir();
            UcaklariHareketEttir();
            VurulanUcaklariCikar();
        }
        public void duraklatVeyaDevamEt()
        {
            if (OyunuDuraklat == false)
            {
                OyunuDuraklat = true;
            }
            else
            {
                OyunuDuraklat = false;
            }
        }
        private void VurulanUcaklariCikar()
        {
            for (var i = _ucaklar.Count - 1; i >= 0; i--)
            {
                var ucak = _ucaklar[i];

                var vuranMermi = ucak.VurulduMu(_mermiler);
                if (vuranMermi is null) continue;

                _ucaklar.Remove(ucak);
                _mermiler.Remove(vuranMermi);
                _savasAlaniPanel.Controls.Remove(ucak);
                _savasAlaniPanel.Controls.Remove(vuranMermi);
                Skor = _alinacakSkor;
                if (Skor % 300 == 0)
                {
                    Level = Level + 1;
                    oyunZorlugunuArttir();
                }
                puanArttır();

            }
        }

        private void oyunZorlugunuArttir()
        {
            switch (_level) {
                case 2:
                    _hareketTimer.Enabled = false;
                    _hareketTimer.Interval = 50;
                    _ucakOlusturmaTimer.Interval = 1500;
                    _hareketTimer.Enabled = true;
                    _alinacakSkor = 50;
                    break;
                case 3:
                    _hareketTimer.Enabled = false;
                    _hareketTimer.Interval = 40;
                    _ucakOlusturmaTimer.Interval = 1000;
                    _hareketTimer.Enabled = true;
                    _alinacakSkor = 100;
                    break;

                case 4:
                    _hareketTimer.Enabled = false;
                    _hareketTimer.Interval = 30;
                    _ucakOlusturmaTimer.Interval = 750;
                    _hareketTimer.Enabled = true;
                    _alinacakSkor = 100;
                    break;
                case 5:
                    _hareketTimer.Enabled = false;
                    _hareketTimer.Interval = 20;
                    _ucakOlusturmaTimer.Interval = 500;
                    _hareketTimer.Enabled = true;
                    _alinacakSkor = 150;
                    break;
                default:
                    break;

            }
        }

        private void puanArttır()
        {
            var scoreLabel = _bilgiPaneli.Controls.Find("scoreLabel", true).FirstOrDefault();
            scoreLabel.Text = Skor.ToString();
            
        }
        private void UcaklariHareketEttir()
        {
           
            foreach (var ucak in _ucaklar)
            {
                var carptiMi = ucak.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;

                Bitir();
                break;
            }
        }

        private void UcakOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            UcakOlustur();
        }

        private void MermileriHareketEttir()
        {
            for (int i = _mermiler.Count - 1; i >= 0; i--)
            {
                var mermi = _mermiler[i];
                var carptiMi = mermi.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _mermiler.Remove(mermi);
                    _savasAlaniPanel.Controls.Remove(mermi);
                }
            }
        }

        public void Baslat()
        {

            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;

            ZamanlayicilariBaslat();

            UcaksavarOlustur();
            UcakOlustur();
        }

        private void UcakOlustur()
        {
            if (OyunuDuraklat) return;
            var ucak = new Ucak(_savasAlaniPanel.Size);
            _ucaklar.Add(ucak);
            _savasAlaniPanel.Controls.Add(ucak);
        }

        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _ucakOlusturmaTimer.Start();

        }
            private void UcaksavarOlustur()
            {
                _ucaksavar = new Ucaksavar(_ucaksavarPanel.Width, _ucaksavarPanel.Size);
                _ucaksavarPanel.Controls.Add(_ucaksavar);


            }

            private void Bitir()
            {
                if (!DevamEdiyorMu) return;

                DevamEdiyorMu = false;
                ZamanlayicilariDurdur();
                skorListesi();
                oyunuTemizle();

            }
            private void  oyunuTemizle()
             {
            for (var i = _ucaklar.Count - 1; i >= 0; i--)
            {
                var aircraft = _ucaklar[i];
                _ucaklar.Remove(aircraft);
                _savasAlaniPanel.Controls.Remove(aircraft);
            }
            for (var i = _mermiler.Count - 1; i >= 0; i--)
            {
                var bullet = _mermiler[i];
                _mermiler.Remove(bullet);
                _savasAlaniPanel.Controls.Remove(bullet);
            }
            _ucaksavarPanel.Controls.Remove(_ucaksavar);
        }
    
            private void ZamanlayicilariDurdur()
            {
                _gecenSureTimer.Stop();
                _hareketTimer.Stop();
                _ucakOlusturmaTimer.Stop();
            }

            public void AtesEt()
            {
                if (OyunuDuraklat) return;
                if (!DevamEdiyorMu) return;

                var mermi = new Mermi(_savasAlaniPanel.Size, _ucaksavar.Center);
                _mermiler.Add(mermi);
                _savasAlaniPanel.Controls.Add(mermi);
            }

            public void UcaksavariHareketEttir(Yon yon)
            {
                if (OyunuDuraklat) return;
                if (!DevamEdiyorMu) return;

                _ucaksavar.HareketEttir(yon);
            }


            private void skorListesi()
            {
            string skorLogText = "score.txt";
            if (!File.Exists(skorLogText))
            {
                FileStream fs = new FileStream(skorLogText, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("0\n0\n0\n0\n0");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            string[] skorlar = File.ReadAllLines(skorLogText, Encoding.UTF8);

            List<int> yeniSkorList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                yeniSkorList.Add(Convert.ToInt32(skorlar[i]));
            }

            yeniSkorList.Sort();

            for (int i = 0; i < 5; i++)
            {
                if (Skor > Convert.ToInt32(skorlar[i]))
                {
                    yeniSkorList[0] = Skor;

                    yeniSkorList.Sort();

                    String lastScores = yeniSkorList[4].ToString() + "\n" +
                                    yeniSkorList[3].ToString() + "\n" +
                                    yeniSkorList[2].ToString() + "\n" +
                                    yeniSkorList[1].ToString() + "\n" +
                                    yeniSkorList[0].ToString() + "\n";


                    File.WriteAllText(skorLogText, lastScores);

                    break;
                }
            }

            MessageBox.Show(yeniSkorList[4].ToString() + "\n" +
                  yeniSkorList[3].ToString() + "\n" +
                  yeniSkorList[2].ToString() + "\n" +
                  yeniSkorList[1].ToString() + "\n" +
                  yeniSkorList[0].ToString() + "\n",
                  "Puan Sıralaması");
        }
            #endregion
        
    }
}


