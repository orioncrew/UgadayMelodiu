using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace UgadayMelodiu
{
    public partial class fMessage : Form
    {
        int timeAnswer =10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 3;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lbTimer.Text = timeAnswer.ToString();
            if(timeAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer(@"Resources\Beep2.wav");
                sp.Play();
            }
        }

        private void fMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
