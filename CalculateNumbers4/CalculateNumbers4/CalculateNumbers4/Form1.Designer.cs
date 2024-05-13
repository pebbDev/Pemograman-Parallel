namespace CalculateNumbers4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(290, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 35;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(99, 375);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(100, 20);
            this.tb10.TabIndex = 34;
            this.tb10.Text = "0";
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(99, 349);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(100, 20);
            this.tb9.TabIndex = 33;
            this.tb9.Text = "0";
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(99, 323);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(100, 20);
            this.tb8.TabIndex = 32;
            this.tb8.Text = "0";
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(99, 285);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(100, 20);
            this.tb7.TabIndex = 31;
            this.tb7.Text = "0";
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(99, 247);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(100, 20);
            this.tb6.TabIndex = 30;
            this.tb6.Text = "0";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(99, 212);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 20);
            this.tb5.TabIndex = 29;
            this.tb5.Text = "0";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(99, 176);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 28;
            this.tb4.Text = "0";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(99, 136);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 27;
            this.tb3.Text = "0";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(99, 96);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 26;
            this.tb2.Text = "0";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(99, 60);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 25;
            this.tb1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(300, 349);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 20);
            this.tbSum.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb9);
            this.Controls.Add(this.tb8);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ParallelMath4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label2;
    }
}

