using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (((32 - 20 <= c.R) && (c.R <= 32 + 20)) && ((65 - 20 <= c.G) && (c.G <= 65 + 20)) && ((84 - 20 <= c.B) && (c.B <= 84 + 20)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else if (((48 - 30 <= c.R) && (c.R <= 48 + 30)) && ((81 - 30 <= c.G) && (c.G <= 81 + 30)) && ((100 - 30 <= c.B) && (c.B <= 100 + 30)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else
                        bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (((160 - 20 <= c.R) && (c.R <= 160 + 20)) && ((130 - 20 <= c.G) && (c.G <= 130 + 20)) && ((80 - 20 <= c.B) && (c.B <= 80 + 20)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else if (((79 - 30 <= c.R) && (c.R <= 79 + 30)) && ((86 - 30 <= c.G) && (c.G <= 86 + 30)) && ((50 - 30 <= c.B) && (c.B <= 50 + 30)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else
                        bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (((70 - 30 <= c.R) && (c.R <= 70 + 30)) && ((111 - 30 <= c.G) && (c.G <= 111 + 30)) && ((49 - 30 <= c.B) && (c.B <= 49 + 30)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else if (((110 - 30 <= c.R) && (c.R <= 110 + 30)) && ((129 - 30 <= c.G) && (c.G <= 129 + 30)) && ((69 - 30 <= c.B) && (c.B <= 69 + 30)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else
                        bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }
    }
}
