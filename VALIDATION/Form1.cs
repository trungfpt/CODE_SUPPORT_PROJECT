using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneNumbers;

namespace VALIDATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPhoneNumber_Click(object sender, EventArgs e)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
            try
            {
                PhoneNumber number = phoneNumberUtil.Parse(txtPhoneNumber.Text, "VN");
                if (phoneNumberUtil.IsValidNumber(number))
                {
                    MessageBox.Show("Số điện thoại hợp lệ.");
                    MessageBox.Show("Định dạng chuẩn: " + phoneNumberUtil.Format(number, PhoneNumberFormat.INTERNATIONAL));
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.");
                }
            }
            catch (NumberParseException)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
            }
        }
    }
}
