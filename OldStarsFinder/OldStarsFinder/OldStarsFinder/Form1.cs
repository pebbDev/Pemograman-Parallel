using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace OldStarsFinder
{
    public partial class Form1 : Form
    {
        private int Count = 0;
        private List<Bitmap> BitmapList;
        private Bitmap OriginalBitmap;
        private String prsOldStarsCount = "0";

        private Bitmap CropBitmap(Bitmap proBitmap, Rectangle proRectangle)
        {
            // Create a new bitmap copying the portion of the 
            // original defined by proRectangle
            // and keeping its PixelFormat
            Bitmap loCroppedBitmap = proBitmap.Clone(proRectangle,
           proBitmap.PixelFormat);
            return loCroppedBitmap;
        }
        private bool IsOldStar(Color color)
        {
            // Contoh sederhana: kita akan menganggap piksel berwarna kuning sebagai bintang lama
            return color == Color.Blue;
        }



        private void ThreadOldStarsFinder(Bitmap loBitmap)
        {
            int liRow; // Nomor baris matriks piksel (Y)
            int liCol; // Nomor kolom matriks piksel (X)
            Color loPixelColor; // Warna piksel

            // Iterasi melalui setiap baris matriks piksel (bitmap)
            for (liRow = 0; liRow < loBitmap.Height; liRow++)
            {
                // Iterasi melalui setiap kolom matriks piksel (bitmap)
                for (liCol = 0; liCol < loBitmap.Width; liCol++)
                {
                    // Dapatkan warna piksel untuk liCol dan liRow
                    loPixelColor = loBitmap.GetPixel(liCol, liRow);

                    if (IsOldStar(loPixelColor))
                    {
                        // Rentang warna sesuai dengan bintang lama
                        // Ubah warnanya menjadi biru murni
                        loBitmap.SetPixel(liCol, liRow, Color.Blue);

                        // Gunakan lock untuk mengamankan prsOldStarsCount dari akses bersamaan
                        lock (prsOldStarsCount)
                        {
                            int i = Convert.ToInt32(prsOldStarsCount);
                            i = i + 1;
                            prsOldStarsCount = i.ToString();
                        }
                    }
                }
            }
        }

        private void ShowBitmapWithOldStars()
        {
            int liThreadNumber;
            Bitmap loBitmap;
            int liStartRow = 0;
            int liEachBitmapHeight = ((int)(OriginalBitmap.Height / Count)) + 1;

            // Membuat bitmap baru dengan lebar dan tinggi yang sama dengan gambar asli
            loBitmap = new Bitmap(OriginalBitmap.Width, OriginalBitmap.Height);
            Graphics g = Graphics.FromImage((Image)loBitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // Menggambar setiap bagian dalam baris awal yang sesuai
            for (liThreadNumber = 0; liThreadNumber < Count; liThreadNumber++)
            {
                g.DrawImage(BitmapList[liThreadNumber], 0, liStartRow);
                liStartRow += liEachBitmapHeight; // Menambahkan baris awal
            }

            // Menampilkan bitmap di PictureBox picStarsBitmap
            picStarsBitmap.Image = loBitmap;
            tbCount.Text = prsOldStarsCount; // Menetapkan jumlah bintang lama
            g.Dispose();
        }


        public Form1()
        {
            InitializeComponent();
        }

        void butFindOldStars_Click(object sender, EventArgs e)
        {
            Count = Convert.ToInt32(tbTasks.Text);
            OriginalBitmap = new Bitmap(picStarsBitmap.Image);
            BitmapList = new List<Bitmap>(Count);
            int StartRow = 0;
            int EachBitmapHeight = ((int)(OriginalBitmap.Height / Count)) + 1;
            int HeightToAdd = OriginalBitmap.Height;
            Bitmap loBitmap;

            // Membagi gambar menjadi daftar bitmap
            for (int i = 0; i < Count; i++)
            {
                if (EachBitmapHeight > HeightToAdd)
                {
                    // Ketinggian bitmap terakhir mungkin lebih kecil dari bitmap lainnya
                    EachBitmapHeight = HeightToAdd;
                }

                loBitmap = CropBitmap(OriginalBitmap, new Rectangle(0, StartRow, OriginalBitmap.Width, EachBitmapHeight));
                HeightToAdd -= EachBitmapHeight;
                StartRow += EachBitmapHeight;
                BitmapList.Add(loBitmap);
            }

            // Melakukan iterasi melalui daftar bitmap dengan perintah Parallel.ForEach
            Parallel.ForEach(BitmapList, item => ThreadOldStarsFinder(item));

            // Menampilkan hasil bitmap yang telah diproses
            ShowBitmapWithOldStars();
        }

    }


}
