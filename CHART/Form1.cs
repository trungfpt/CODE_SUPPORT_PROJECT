using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHART
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.mydb' table. You can move, or remove it, as needed.
            this.mydbTableAdapter.Fill(this.database1DataSet.mydb);

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "name";
            chart1.Series[0].YValueMembers = "name";
            chart1.Series[1].XValueMember = "youtube";
            chart1.Series[1].YValueMembers = "youtube";
            chart1.Series[2].XValueMember = "fiver";
            chart1.Series[2].YValueMembers = "fiver";
            chart1.Series[3].XValueMember = "facebook";
            chart1.Series[3].YValueMembers = "facebook";
            chart1.DataSource = database1DataSet.mydb;
            chart1.DataBind();
        }
    }
}
