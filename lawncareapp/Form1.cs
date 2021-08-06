using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lawncareapp
{
    

    public partial class Form1 : Form
    {

        int lastcut = 10;
        int nextcut = 15;
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



            lbl_lastcut.Text = "Great the next cut it will be in " + nextcut + " days";
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
    }
}
