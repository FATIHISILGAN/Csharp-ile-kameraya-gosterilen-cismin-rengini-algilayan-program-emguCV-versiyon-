using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace color_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int m, y, k;
        Capture _capture = new Capture();

        Bitmap bitmap;

        private void Form1_Load(object sender, EventArgs e)
        {
          

                
            try
            {



                _capture.Start();
                Application.Idle += streaming;



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Source);
                MessageBox.Show(error.Message);

            }
            m = 0;
            y = 0;
            k = 0;


        }

        private void streaming(object sender, EventArgs e)
        {
            try
            {


                var img = _capture.QueryFrame().ToImage<Bgr, byte>();// değişik görüntü özellikleri verilebilir
                var bpm = img.Bitmap;
                bitmap = new Bitmap(bpm);
                colorREAD();
                picStream.Image = bitmap;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Source);
                MessageBox.Show(error.Message);

            }

        }
        public void colorREAD()
        {
            for (int i = 0; i < picStream.Width; i++)
            {
                for (int j = 0; j < picStream.Height; j++)
                {
                    if (bitmap.GetPixel(i, j).R <= 95 && bitmap.GetPixel(i, j).G <= 95 && bitmap.GetPixel(i, j).B >= 100)//mavi şartı
                    {
                        m++;
                    }
                    if (bitmap.GetPixel(i, j).R <= 95 && bitmap.GetPixel(i, j).G >= 100 && bitmap.GetPixel(i, j).B <= 95)//yeşil şartı
                    {
                        y++;
                    }
                    if (bitmap.GetPixel(i, j).R >= 105 && bitmap.GetPixel(i, j).G <= 95 && bitmap.GetPixel(i, j).B <= 95)//kırmızı şartı
                    {
                        k++;
                    }

                }
            }

            if (k > m && k > y)
            {
                colorDATA.Text = "kırmızı";
                k = 0;
                y = 0;

                m = 0;
            }
            if (y > m && y > k)
            {
                colorDATA.Text = "yeşil";
                k = 0;
                y = 0;

                m = 0;

            }
            if (m > k && m > y)
            {
                colorDATA.Text = "mavi";
                k = 0;
                y = 0;

                m = 0;
            }
        }
    }
}

