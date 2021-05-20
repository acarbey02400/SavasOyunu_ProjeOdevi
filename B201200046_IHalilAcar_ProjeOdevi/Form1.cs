﻿using System;
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
        private readonly Oyun _oyun;
        public Form1()
        {
            InitializeComponent();
            _oyun = new Oyun(ucaksavarPanel, savasAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    MessageBox.Show("Oyun başladı");
                    _oyun.Baslat();
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
    }
   
}