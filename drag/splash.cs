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

namespace drag
{
    public partial class splash : Form
    {
        //Sound Effect
        SoundPlayer sp = new SoundPlayer(@"SplashSound.wav");

        public splash()
        {
            InitializeComponent();
          
        }

        private void splashtimer_Tick(object sender, EventArgs e)
        {
            Progressbarsplash.Increment(1);
            if(Progressbarsplash.Value==100)
            {
                splashtimer.Stop();
                picLogo.Visible = true;

            }
        }

        private void splash_Load(object sender, EventArgs e)
        
        
        {
            sp.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
