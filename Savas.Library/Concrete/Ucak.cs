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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    internal class Ucak : Cisim
    {
        private static readonly Random Random = new Random();

        public Ucak(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }

        public Mermi VurulduMu(List<Mermi> mermiler)
        {
            foreach (var mermi in mermiler)
            {
                var vurulduMu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vurulduMu) return mermi;
            }

            return null;
        }
    }
}
