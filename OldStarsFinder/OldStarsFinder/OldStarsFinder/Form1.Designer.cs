namespace OldStarsFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picStarsBitmap = new System.Windows.Forms.PictureBox();
            this.butFindOldStars = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbTasks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStarsBitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of bitmaps to divide into for processing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Old Start Count";
            // 
            // picStarsBitmap
            // 
            this.picStarsBitmap.Image = ((System.Drawing.Image)(resources.GetObject("picStarsBitmap.Image")));
            this.picStarsBitmap.InitialImage = null;
            this.picStarsBitmap.Location = new System.Drawing.Point(50, 159);
            this.picStarsBitmap.Name = "picStarsBitmap";
            this.picStarsBitmap.Size = new System.Drawing.Size(536, 269);
            this.picStarsBitmap.TabIndex = 2;
            this.picStarsBitmap.TabStop = false;
            // 
            // butFindOldStars
            // 
            this.butFindOldStars.Location = new System.Drawing.Point(416, 55);
            this.butFindOldStars.Name = "butFindOldStars";
            this.butFindOldStars.Size = new System.Drawing.Size(104, 23);
            this.butFindOldStars.TabIndex = 3;
            this.butFindOldStars.Text = "Old Stars Finder";
            this.butFindOldStars.UseVisualStyleBackColor = true;
            this.butFindOldStars.Click += new System.EventHandler(this.butFindOldStars_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(152, 87);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 20);
            this.tbCount.TabIndex = 4;
            // 
            // tbTasks
            // 
            this.tbTasks.Location = new System.Drawing.Point(284, 55);
            this.tbTasks.Name = "tbTasks";
            this.tbTasks.Size = new System.Drawing.Size(100, 20);
            this.tbTasks.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTasks);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.butFindOldStars);
            this.Controls.Add(this.picStarsBitmap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OldStarsFinder";
            ((System.ComponentModel.ISupportInitialize)(this.picStarsBitmap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picStarsBitmap;
        private System.Windows.Forms.Button butFindOldStars;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbTasks;
    }
}

