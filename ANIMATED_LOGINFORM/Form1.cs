using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANIMATED_LOGINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "admin" || txtPassword.Text == "admin") & (txtUsername.Text.Length > 0 || txtPassword.Text.Length > 0)) 
            {
                MessageBox.Show("Login successfully!");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Moi nhap lai", "Check", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    txtUsername.Text = " ";
                    txtPassword.Text = " ";
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
