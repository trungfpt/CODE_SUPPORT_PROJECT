using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace GENERATION_BARCODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtBarcode.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBoxBarcode.Image = code.GetGraphic(50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Bitmap barcodeBitmap = new Bitmap(pictureBoxBarcode.Image);
            dataGridView1.Rows.Add(txtID.Text,txtCode.Text);
            txtID.Clear();
            txtCode.Clear();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            txtBarcode.Text = dataGridView1.Rows[2].Cells[2].Value.ToString();
        }
    }
}