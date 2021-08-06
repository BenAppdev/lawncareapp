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

namespace lawncareapp
{



    public partial class Form1 : Form
    {

        int lastcut = 10;
        int nextcut = 15;
        string nextcutDate = "Jan 8 2022";
        int nextMaintenance = 150;
        
        int myTime = 0;

        string mycutterlink = ("http://www.homedepot.com");
        public Form1()
        {
            InitializeComponent();

            

            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl_lastcut.Visible = false;


        }



        private void btn_yes_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
            lbl2.Text = "Great Job see you next month";
            lbl2.ForeColor = Color.Black;
            rtxbx1.Visible = true;
            lbl_lastcut.Visible = true;

            lbl_lastcut_date.Text = DateTime.Now.ToString("d/MM/yyyy");
            DateTime today = DateTime.Now;
            DateTime nextcutDate = today.AddDays(15);

            //lbl_myTime.Text = ("Time  " + myTime); Figure this out later



            lbl_lastcut.Text = "Great the next cut it will be in " + nextcut + " days. Thats " + nextcutDate.ToString("MM/d");
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            //int lastcut = 10;  this has been declared on the global level
            lbl2.Visible = true;
            lbl2.Text = "All right now its time to get on it";
            lbl2.ForeColor = Color.Red;
            rtxbx1.Visible = true;
            lbl_lastcut.Visible = true;

            lbl_lastcut.Text = "The last time you cut it was "+ lastcut + " days ago";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_yes_2_Click(object sender, EventArgs e)
        {
            lbl3.Visible = true;
            lbl3.Text = "How refreshing";
            lbl3.ForeColor = Color.Black;
            rtxbx2.Visible = true;
        }

        private void btn_no_2_Click(object sender, EventArgs e)
        {
            lbl3.Visible = true;
            lbl3.Text = "Looks like someone is thirsty";
            lbl3.ForeColor = Color.Red;
            rtxbx2.Visible = true;
        }

        private void btn_yes_3_Click(object sender, EventArgs e)
        {
            lbl4.Visible = true;
            lbl4.Text = "Great your grass is happy not being crowded";
            lbl4.ForeColor = Color.Black;
            rtxbx3.Visible = true;
        }

        private void btn_no_3_Click(object sender, EventArgs e)
        {
            lbl4.Visible = true;
            lbl4.Text = "Oh man its too crowded, weeds and grass together";
            lbl4.ForeColor = Color.Red;
            rtxbx3.Visible = true;

        }

        private void rtxbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rtxbx1.Visible = false;
            rtxbx2.Visible = false;
            rtxbx3.Visible = false;

            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_lastcut_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lastcut_date_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_no_mowerOil_Click(object sender, EventArgs e)
        {
            //lbl_oil_hyperlink.Text = ("www.homedepot.com");
            //lbl_oil_.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void lbl_oil_hyperlink_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_orderBlade_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.homedepot.com/p/Toro-22-in-Atomic-Replacement-Blade-for-Select-Brand-Lawn-Mowers-59534P/100190186?source=shoppingads&locale=en-US&mtc=Shopping-B-F_D28I-G-D28I-028_037_OUTDR_PW_ACC-NA-NA-NA-SMART-NA-NA-SMART_SHP&cm_mmc=Shopping-B-F_D28I-G-D28I-028_037_OUTDR_PW_ACC-NA-NA-NA-SMART-NA-NA-SMART_SHP-71700000079956011-58700006728091443-92700060957828806&gclid=Cj0KCQjwu7OIBhCsARIsALxCUaMhF2jBsPw13dMpGw19Fs1-EkDdBP2poKcbtOeHVXib6ANabg0V5C8aAlPFEALw_wcB&gclsrc=aw.ds");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.homedepot.com/p/Toro-8-oz-Top-it-Off-SAE-30-4-Cycle-Premium-Lawn-Mower-Engine-Oil-139-0628/307270389");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_nextschedmain_Click(object sender, EventArgs e)
        {
;


        }

        private void dateTimePicker_mowermain_ValueChanged(object sender, EventArgs e)
        {
            DateTime nextmain;    
            dateTimePicker_mowermain.Text = DateTime.Now.ToString("d/MM/yyyy");
            DateTime todaymain = dateTimePicker_mowermain.Value ;
            //lbl_nextschedmain.Text = (dateTimePicker_mowermain.Value.ToString("d/MM"));
            nextmain = todaymain.AddDays(5);
            lbl_nextschedmain.Text = ("Your next Scheduled Maintenance is "+nextmain.ToString("MM/d"));

            //lbl_lastcut_date.Text = DateTime.Now.ToString("d/MM/yyyy");
            //DateTime today = DateTime.Now;
            //DateTime nextcutDate = today.AddDays(15);
            //today.AddDays(15);
        }
    }
    
}
