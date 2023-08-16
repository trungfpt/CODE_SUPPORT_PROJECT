using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATETIMEPICKER_TIMER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetDate_Click(object sender, EventArgs e)
        {
            int selectedDay = dateTimePicker1.Value.Day;
            int selectedMonth = dateTimePicker1.Value.Month;
            int selectedYear = dateTimePicker1.Value.Year;
            MessageBox.Show($"Selected Day: {selectedDay}\n Selected Month: {selectedMonth}\n Selected Year: {selectedYear}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
