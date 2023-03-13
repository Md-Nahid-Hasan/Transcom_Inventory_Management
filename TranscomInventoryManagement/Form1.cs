using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TranscomInventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passWord.UseSystemPasswordChar = false;
            }
            else
            {
                passWord.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            passWord.Text = "";
            checkBox1.Checked = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}