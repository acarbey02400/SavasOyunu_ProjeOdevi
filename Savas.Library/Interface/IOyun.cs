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
using Savas.Library.Enum;
namespace Savas.Library.Interface
{
   
    internal interface IOyun
        {
            event EventHandler GecenSureDegisti;

            bool DevamEdiyorMu { get; }
            TimeSpan GecenSure { get; }

            void Baslat();
            void AtesEt();
            void UcaksavariHareketEttir(Yon yon);
        }
    
}
