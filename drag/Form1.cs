using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace drag
{
    public partial class Form1 : Form
    {
        //Sound Effect
        SoundPlayer player =new SoundPlayer(@"beep.wav");
        SoundPlayer playquit = new SoundPlayer(@"quit.wav");


        //Score board
        int i = 0;
                      
        public Form1()

        {
         InitializeComponent(); 
        }

        //Label D&D Pumpkin

        private void lblpu_MouseDown(object sender, MouseEventArgs e)
        {
            Label pb = (Label)sender;
            pb.Select();
            pb.DoDragDrop(pb.Text, DragDropEffects.Copy);


            lblcao.Visible = true;
            lbltoo.Visible = true;
            lblpeo.Visible = true;
            lblego.Visible = true;

        }

        private void lblpu_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))

            {
                e.Effect = DragDropEffects.Copy;


                //pumpkin Visibility
                lblpuo.Visible = true;
                picbxpu.Visible = true;
                picbxpum2.Visible = true;

                //tomato visibility
                lbltoo.Visible = false;
                picbxto.Visible = true;
                picbxto2.Visible = false;

                //pea visibility
                lblpeo.Visible = false;
                picbxpe.Visible = true;
                picbxpe2.Visible = false;

                //eggplant visibility
                lblego.Visible = false;
                picbxeg2.Visible = false;
                picbxeg.Visible = true;

                //carrot visibility
                lblcao.Visible = false;
                picbxca.Visible = true;
                picbxca2.Visible = false;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblpu_DragDrop(object sender, DragEventArgs e)
        {
            //Sound Effect
            player.Play();

            Label pb = (Label)sender;
            pb.Text = (String)e.Data.GetData(DataFormats.StringFormat);

            
         
            if (lblpuo.Text != null && i < 100)

            {
                lblpu.Visible = false;
                picbxpu.Visible = false;
                picbxpum2.Visible = true;

                
                i += 20;
                lblmark.Text = i.ToString();

            }

            else
            {
              //  lblpu.Visible = true;

            }
        }


        //Label D&D Carrot

        private void lblca_MouseDown(object sender, MouseEventArgs e)
        {
            Label pb = (Label)sender;
            pb.Select();
            pb.DoDragDrop(pb.Text, DragDropEffects.Copy);

            lblpuo.Visible = true;
            lbltoo.Visible = true;
            lblpeo.Visible = true;
            lblego.Visible = true;

        }

        private void lblca_DragEnter(object sender, DragEventArgs e)
        {



            if (e.Data.GetDataPresent(DataFormats.StringFormat))

            {
                e.Effect = DragDropEffects.Copy;

                //pumpkin Visibility
                lblpuo.Visible = false;
                picbxpu.Visible = true;
                picbxpum2.Visible = false;

                //tomato visibility
                lbltoo.Visible = false;
                picbxto.Visible = true;
                picbxto2.Visible = false;

                //pea visibility
                lblpeo.Visible = false;
                picbxpe.Visible = true;
                picbxpe2.Visible = false;

                //eggplant visibility
                lblego.Visible = false;
                picbxeg.Visible = true;
                picbxeg2.Visible = false;

                //carrot visibility
                lblcao.Visible = true;
                picbxca.Visible = true;
                picbxca2.Visible = true;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void lblca_DragDrop(object sender, DragEventArgs e)
        {
            //Sound Effect
            player.Play();

            Label pb = (Label)sender;
            pb.Text = (String)e.Data.GetData(DataFormats.StringFormat);




            if (lblcao.Text != null && i < 100)
            {
                lblca.Visible = false;
                picbxca.Visible = false;
                picbxca2.Visible = true;

                i += 20;
                lblmark.Text = i.ToString();

            }

            else
            {
               // lblca.Visible = true;

            }
        }

        //Label D&D Tommato

        private void lblto_MouseDown(object sender, MouseEventArgs e)
        {
            Label pb = (Label)sender;
            pb.Select();
            pb.DoDragDrop(pb.Text, DragDropEffects.Copy);

            lblpuo.Visible = true;
            lblcao.Visible = true;
            lblpeo.Visible = true;
            lblego.Visible = true;

        }

        private void lblto_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.StringFormat))

            {
                e.Effect = DragDropEffects.Copy;

                //pumpkin Visibility
                lblpuo.Visible = false;
                picbxpu.Visible = true;
                picbxpum2.Visible = false;

                //tomato visibility
                lbltoo.Visible = true;
                picbxto.Visible = true;
                picbxto2.Visible = true;

                //pea visibility
                lblpeo.Visible = false;
                picbxpe.Visible = true;
                picbxpe2.Visible = false;

                //eggplant visibility
                lblego.Visible = false;
                picbxeg.Visible = true;
                picbxeg2.Visible = false;

                //carrot visibility
                lblcao.Visible = false;
                picbxca.Visible = true;
                picbxca2.Visible = false;

            }

            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void lblto_DragDrop(object sender, DragEventArgs e)
        {
            //Sound Effect
            player.Play();

            Label pb = (Label)sender;
            pb.Text = (String)e.Data.GetData(DataFormats.StringFormat);



            if (lbltoo.Text != null && i < 100)
            {
                lblto.Visible = false;
                picbxto.Visible = false;
                picbxto2.Visible = true;

                i += 20;
                lblmark.Text = i.ToString();

            }

            else
            {
               // lblto.Visible = true;
            }
        }

        //Label D&D Pea
        
        private void lblpe_MouseDown(object sender, MouseEventArgs e)
        {
            Label pb = (Label)sender;
            pb.Select();
            pb.DoDragDrop(pb.Text, DragDropEffects.Copy);

            lblpuo.Visible = true;
            lblcao.Visible = true;
            lbltoo.Visible = true;
            lblego.Visible = true;

        }

        private void lblpe_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.StringFormat))

            {
                e.Effect = DragDropEffects.Copy;

                //pumpkin Visibility
                lblpuo.Visible = false;
                picbxpu.Visible = true;
                picbxpum2.Visible = false;

                //tomato visibility
                lbltoo.Visible = false;
                picbxto.Visible = true;
                picbxto2.Visible = false;

                //pea visibility
                lblpeo.Visible = true;
                picbxpe.Visible = true;
                picbxpe2.Visible = true;

                //eggplant visibility
                lblego.Visible = false;
                picbxeg.Visible = true;
                picbxeg2.Visible = false;

                //carrot visibility
                lblcao.Visible = false;
                picbxca.Visible = true;
                picbxca2.Visible = false;

            }

            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void lblpe_DragDrop(object sender, DragEventArgs e)
        {

            //Sound Effect
            player.Play();

            Label pb = (Label)sender;
            pb.Text = (String)e.Data.GetData(DataFormats.StringFormat);


            if (lblpeo.Text != null && i < 100)
            {
                lblpe.Visible = false;
                picbxpe.Visible = false;
                picbxpe2.Visible = true;

                i += 20;
                lblmark.Text = i.ToString();
            }

            else
            {
               // lblpe.Visible = true;

            }
        }


        //Label D&D Eggplant

        private void lbleg_MouseDown(object sender, MouseEventArgs e)
        {
            Label pb = (Label)sender;
            pb.Select();
            pb.DoDragDrop(pb.Text, DragDropEffects.Copy);


            lblpuo.Visible = true;
            lbltoo.Visible = true;
            lblpeo.Visible = true;
            lblcao.Visible = true;
        }

        private void lbleg_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
                

            {
                e.Effect = DragDropEffects.Copy;


                //pumpkin Visibility
                lblpuo.Visible = false;
                picbxpu.Visible = true;
                picbxpum2.Visible = false;

                //tomato visibility
                lbltoo.Visible = false;
                picbxto.Visible = true;
                picbxto2.Visible = false;

                //pea visibility
                lblpeo.Visible = false;
                picbxpe.Visible = true;
                picbxpe2.Visible = false;

                //eggplant visibility
                lblego.Visible = true;
                picbxeg.Visible = true;
                picbxeg2.Visible = true;

                //carrot visibility
                lblcao.Visible = false;
                picbxca.Visible = true;
                picbxca2.Visible = false;

            }

            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void lbleg_DragDrop(object sender, DragEventArgs e)
        {
            player.Play();
            Label pb = (Label)sender;
            pb.Text = (String)e.Data.GetData(DataFormats.StringFormat);

            

            if (lbleg.Text != null && i < 100 )
            {
                
                lbleg.Visible = false;
                picbxeg.Visible = false;
                picbxeg2.Visible = true;


                i += 20;
                lblmark.Text = i.ToString();
            }

            else
            {
               // lbleg.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            lblpuo.MouseDown += new MouseEventHandler(lblpu_MouseDown);
            lblpuo.DragEnter += new DragEventHandler(lblpu_DragEnter);
            lblpuo.DragDrop += new DragEventHandler(lblpu_DragDrop);

            lblcao.MouseDown += new MouseEventHandler(lblca_MouseDown);
            lblcao.DragEnter += new DragEventHandler(lblca_DragEnter);
            lblcao.DragDrop += new DragEventHandler(lblca_DragDrop);

            lbltoo.MouseDown += new MouseEventHandler(lblto_MouseDown);
            lbltoo.DragEnter += new DragEventHandler(lblto_DragEnter);
            lbltoo.DragDrop += new DragEventHandler(lblto_DragDrop);

            lblpeo.MouseDown += new MouseEventHandler(lblpe_MouseDown);
            lblpeo.DragEnter += new DragEventHandler(lblpe_DragDrop);
            lblpeo.DragDrop += new DragEventHandler(lblpe_DragDrop);

            lblego.MouseDown += new MouseEventHandler(lbleg_MouseDown);
            lblego.DragEnter += new DragEventHandler(lbleg_DragDrop);
            lblego.DragDrop += new DragEventHandler(lbleg_DragDrop);
                  
        }

        private void lbleg_Click(object sender, EventArgs e)
        {

        }

        private void lblpu_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //btnReset.BackColor = Color.Transparent;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
             
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            playquit.Play();
        }
        /*
private void picbxpu_Click(object sender, EventArgs e)
{

}

private void picbxca_Click(object sender, EventArgs e)
{

}

private void picbxto_Click(object sender, EventArgs e)
{

}

private void picbxpe_Click(object sender, EventArgs e)
{

}

private void picbxeg2_Click(object sender, EventArgs e)
{

}

private void lblego_Click(object sender, EventArgs e)
{

}

private void lblpeo_Click(object sender, EventArgs e)
{

}

private void lbltoo_Click(object sender, EventArgs e)
{

}

private void pictureBox1_Click(object sender, EventArgs e)
{

}

private void lblcao_Click(object sender, EventArgs e)
{

}

private void lblpuoo_Click(object sender, EventArgs e)
{

}*/

        //function of splash screen


    }
}
