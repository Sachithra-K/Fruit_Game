using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace drag
{
    public partial class Form2 : Form
    {
        //bgmusic
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        //Sound Effect - play btn
        SoundPlayer playbtn = new SoundPlayer(@"playbtn.wav");




        public void startSplash()
        {
            Application.Run(new splash());
        }

        public Form2()
        {
            Thread t = new Thread(new ThreadStart(startSplash));
            t.Start();
            Thread.Sleep(6200);
            InitializeComponent();
            t.Abort();

            //bgmusic
            player.URL = "bgmusic.mp3";
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            //Sound Effect - PLAY BTN
            playbtn.Play();

            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

           



        }

        private void btnquit_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

		private void Form2_Load(object sender, EventArgs e)
		{


		}
	}
}
