using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CalculateNumbers4
{
    public partial class Form1 : Form
    {
        long total = 0;
        int[] numbers = new int[10];
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
            Parallel.For(0, 9, CalculateNumbers4);
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
        private void CalculateNumbers4(int i, ParallelLoopState pls)
        {
            Parallel.For<long>(0, 10,
                () => 0,
                (j, loop, subtotal) =>
                {
                    int result = numbers[j];
                    for (int k = 1; k <= 10; k++)
                    {
                        result *= k;
                    }
                    numbers[j] = result;
                    subtotal += result;
                    return subtotal;
                },
                (finalResult) => Interlocked.Add(ref total, finalResult)
            );
            tbSum.Text = total.ToString();
        }
    }
}
