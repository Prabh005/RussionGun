using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussionGun
{
    
    public partial class Form1 : Form
    {
        SoundPlayer s = new SoundPlayer(RussionGun.Properties.Resources.fire);   //fire sound 
        GunClass myclass = new GunClass(); // gun class al the data and function coming from gun class
        public Form1()
        {
            InitializeComponent();
            btnaway.Enabled = false; // button visiablity
            btnfire.Enabled = false;
            btnspin.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit button

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Application.Restart();  //restart button
        }

        private void btnLoadgun_Click(object sender, EventArgs e)
        {
          
           
            myclass.Loadgun();  // loadgun from gun class 
           
            start.Text = "Gun Reloaded, Spin a Chamber ...."; // notification 
            btnspin.Enabled = true;
            btnLoadgun.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start.Text = " Game start Plese load A Gun for Play Game";    // startup message 

            pictureBox2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            myclass.Spin();    // spin chamber  from gun class 
            myclass.Bullet();
            pointdata.Text = myclass.Point.ToString();

            btnspin.Enabled = false;
           
                btnaway.Enabled = true;
            btnfire.Enabled = true;
        }

        private void btnaway_Click(object sender, EventArgs e)
        {
            s.Play(); // sound 
            start.Text = "Secure shot!";// shoot away message 
        
            myclass.awayshot();
         
            if (myclass.bullet == 5)
            {
                myclass.Pointadd();
               start.Text = "WIN!";
                start.Text = "Game Over!";
               btnfire.Enabled = false;
                btnaway.Enabled = false;
                
            }
            if (myclass.away == 2) // 2 chances available
            {

              btnaway.Enabled = true;
                btnfire.Enabled = false ;
                
            }

            myclass.shootaway();
            myclass.Bullet();

           // points 
           pointdata.Text = myclass.Point.ToString();
            start.Text = myclass.fire.ToString();
        }

        private void btnfire_Click(object sender, EventArgs e)
        {
            s.Play();// sound 
            start.Text = "Brave shot!";
           
            myclass.fireshot();
            
            if (myclass.bullet == 5)
            {
                myclass.PointCut();
               start.Text = "LOST!";
                label2.Text = "DEAD!";
               btnfire.Enabled = false;
                btnaway.Enabled = false;
                btnaway.Enabled = false;
                pictureBox1.Hide();
                pictureBox2.Show();
               
               
            }
           
            else if (myclass.fire == 4)
            {
                myclass.Pointadd();
                label2.Text = "WIN!";
               start.Text = "You still have Chaces For shoot Away";
                btnaway.Enabled = false;
                btnfire.Enabled = false;
              
            }

            myclass.Pointadd1();
            myclass.shootaway();
            myclass.Bullet();

            // total point
            pointdata.Text = myclass.Point.ToString();
     
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
