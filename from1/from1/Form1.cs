using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your Nme");
            else
                this.errorProvider1.Clear();
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "This is not availid number");
            else
                this.errorProvider1.Clear();
            
        
        }
        //private void txtYear_TextChanged(object sender, EventArgs e)
        //{
        //    Control ctr = (Control)sender;
        //    if(ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-11]))
        //        this.errorProvider1.SetError(ctr,"This is not avalid number");
        //    else
        //        this.errorProvider1.Clear();

        //}
        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    int age;
        //    string s;
        //    s = "My name is " + txtYourName.Text + "\n";
        //    age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
        //    s = s + "Age" + age.ToString();
        //    MessageBox.Show(s);

        //}
        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    txtYourName.Clear();
        //    txtYear.Clear();
        //    txtYourName.Focus();
        //}
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged_1(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            s = s + "Age" + age.ToString();
            MessageBox.Show(s);

        }


    }
}
