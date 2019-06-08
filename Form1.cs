using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace test22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ocr_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog.FileName);
                var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
                //(lien,langue,engine)
                var page = ocr.Process(img);
                txt_output.Text = page.GetText();//get text from image
            }
        }
    }
}
