using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int toplamBen = 0;
        int toplamPc = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            btnBaslaBen.Enabled = false;
            btnBaslaPc.Enabled = true;
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);
            toplamBen = toplamBen + a + b;
            lblPuan1.Text = toplamBen.ToString();
            lblZ1zar.Text = a.ToString(); 
            lbl2Zar.Text = b.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (3).png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (2).png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (1).png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (5).png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (4).png";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (3).png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (2).png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (1).png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (5).png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (4).png";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBaslaPc_Click(object sender, EventArgs e)
        {
            btnBaslaPc.Enabled = false;
            btnBaslaBen.Enabled = true;
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            label10.Text = c.ToString();
            label9.Text = d.ToString();
            toplamPc = toplamPc + c + d;
            lblpcTop.Text = toplamPc.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (3).png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (2).png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (1).png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (5).png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (4).png";
            }
            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (3).png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (2).png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (1).png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (5).png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\legen\\Downloads\\pngwing.com (4).png";
            }
            
            if(toplamBen>=100 && toplamBen > toplamPc)
            {
                label3.Text = "Kazanan Sizsiniz Tebrikler Birinci Oyuncu!:)))))";
                btnBaslaBen.Enabled = false;
                btnBaslaPc.Enabled = false;
            }
            if(toplamPc>=100 && toplamPc > toplamBen)
            {
                label3.Text = "Kazanan Bilgisayar Siz Kaybettiniz :(((((";
                btnBaslaBen.Enabled = false;
                btnBaslaPc.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBaslaBen.Enabled = true;
            btnBaslaPc.Enabled = false;
        }
    }
}
