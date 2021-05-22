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
    public partial class GirisForm : Form
    {
        
        
        private readonly Timer _gecenSureTimer = new Timer { Interval = 90 };
        public TimeSpan loadingTime;

        public GirisForm()
        {
            
            _gecenSureTimer.Start();
            InitializeComponent();
            _gecenSureTimer.Tick += gecenSureTimer_Tick;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            
            progressBar1.Maximum = 1000;
            progressBar1.Step = 20;
            

        }
        private void gecenSureTimer_Tick(object sender, EventArgs e)
        {
            loadingTime = TimeSpan.FromSeconds(1);
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label1.Visible = true;
                label2.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
