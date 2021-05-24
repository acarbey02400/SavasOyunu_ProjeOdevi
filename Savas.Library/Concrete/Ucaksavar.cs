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
    internal class Ucaksavar : Cisim
    {
        public Ucaksavar(int panelGenisligi, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi / 2;
            HareketMesafesi = Width;
        }
    }
}
