using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateNumbers2
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        private void CalculateNumbers2(int i, ParallelLoopState pls)
        {
            int j = numbers[i];

            if (i < 7)
            {
                for (int k = 1; k <= 10; k++)
                {
                    j *= k;
                }
                numbers[i] = j;
            }
            else
            {
                pls.Stop();
                return;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToInt32(tb1.Text);
            numbers[1] = Convert.ToInt32(tb2.Text);
            numbers[2] = Convert.ToInt32(tb3.Text);
            numbers[3] = Convert.ToInt32(tb4.Text);
            numbers[4] = Convert.ToInt32(tb5.Text);
            numbers[5] = Convert.ToInt32(tb6.Text);
            numbers[6] = Convert.ToInt32(tb7.Text);
            numbers[7] = Convert.ToInt32(tb8.Text);
            numbers[8] = Convert.ToInt32(tb9.Text);
            numbers[9] = Convert.ToInt32(tb10.Text);
            Parallel.For(0, 9, CalculateNumbers2);
            tb1.Text = numbers[0].ToString();
            tb2.Text = numbers[1].ToString();
            tb3.Text = numbers[2].ToString();
            tb4.Text = numbers[3].ToString();
            tb5.Text = numbers[4].ToString();
            tb6.Text = numbers[5].ToString();
            tb7.Text = numbers[6].ToString();
            tb8.Text = numbers[7].ToString();
            tb9.Text = numbers[8].ToString();
            tb10.Text = numbers[9].ToString();
        }

    }
}
