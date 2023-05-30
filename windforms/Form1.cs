using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windforms
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd = new Random();
        
       

        public MainForm()
        {
            InitializeComponent();
            rdBt8.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void random_Click(object sender, EventArgs e)
        {

        }

        private void Count_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //вкладка about program, проверка на гея
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
           DialogResult res= MessageBox.Show("You are gay","gay check", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) MessageBox.Show("I know)","gey check");
            if (res == DialogResult.No) MessageBox.Show("you are absolutly gay.","gay check");
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //это счетчик на плюс
        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }
        //э
        private void btnCount0_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            int n;
            if ((Convert.ToInt32(num1.Value))< (Convert.ToInt32(num2.Value)))
            {
                 n = rnd.Next(Convert.ToInt32(num1.Value), Convert.ToInt32(num2.Value)+1);
                lblrandom.Text = n.ToString();
            }
            else
            { 
                n = rnd.Next(Convert.ToInt32(num2.Value), Convert.ToInt32(num1.Value)+1);
                lblrandom.Text = n.ToString();
            }
            if (chRnd.Checked)
            {
                int i = 0;
                while ((tbRnd.Text.IndexOf(n.ToString()) != -1))
                {
                    if ((Convert.ToInt32(num1.Value)) < (Convert.ToInt32(num2.Value)))
                    {
                        n = rnd.Next(Convert.ToInt32(num1.Value), Convert.ToInt32(num2.Value) + 1);
                        lblrandom.Text = n.ToString();
                        i++;
                    }
                    else
                    {
                        n = rnd.Next(Convert.ToInt32(num2.Value), Convert.ToInt32(num1.Value) + 1);
                        lblrandom.Text = n.ToString();
                        i++;
                    }
                    if (i > 1000) break;


                }

                if(i<1000)    tbRnd.AppendText(n + "\r\n");
                
            }
            else tbRnd.AppendText(n + "\r\n");

        }

        private void lblrandom_Click(object sender, EventArgs e)
        {

        }

        private void btnRndClr_Click(object sender, EventArgs e)
        {
            tbRnd.Clear();
        }

        private void btRndCp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRnd.Text);
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rchTB.AppendText(DateTime.Now.ToShortDateString() + "\r\n");

        }

        private void dateToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            rchTB.AppendText(DateTime.Now.ToShortDateString() + "\r\n");

        }

        private void timeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rchTB.AppendText(DateTime.Now.ToShortTimeString() + "\r\n");

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCrt_Click(object sender, EventArgs e)
        {
            tbRndPsw.Clear();

            string psw = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string num = "0123456789";
            string sym = "!@#$&*?";
            string res = "";
            int lenght=1;
            
            
            if (chBxNumber.Checked == true) { psw += num; }
            if (chBxSymbols.Checked == true) { psw += sym; }
            if (rdBt8.Checked == true) { lenght = 8; }
            if (rdbt16.Checked == true) { lenght = 16; }
            if (rdBt24.Checked == true) { lenght = 24; }
            for (int i= 0;i<lenght;i++)
            {

                res += psw[rnd.Next(0, psw.Length)];

            }
            tbRndPsw.AppendText(res);


        }

        private void btnCp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRndPsw.Text);
        }
    }
}
