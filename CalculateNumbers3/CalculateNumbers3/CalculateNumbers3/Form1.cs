using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;


namespace CalculateNumbers3
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        ConcurrentQueue<Exception> exceptions = new ConcurrentQueue<Exception>();
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
            Parallel.For(0, 9, CalculateNumbers3);
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
            try
            {
                Parallel.For(0, 10, CalculateNumbers3);
                if (exceptions.Count > 0) throw new
               AggregateException(exceptions);
            }
            catch (AggregateException ae)
            {
                // This is where you can choose which exceptions to handle.
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is ArgumentException)
                    {
                        tbMessages.Text += ex.Message;
                        tbMessages.Text += "\r\n";
                    }
                    else
                        throw ex;
                }
            }
        }

        private void CalculateNumbers3(int i, ParallelLoopState
pls)
        {
            int j = numbers[i];
            try
            {
                for (int k = 1; k <= 10; k++)
                {
                    j *= k;
                    if (j > 5000000) throw new
                   ArgumentException(String.Format("The value of text box {0} is {1}", i, j));
                }
            }
            catch (Exception e)
            {
                exceptions.Enqueue(e);
            }
            numbers[i] = j;
        }

    }

}
