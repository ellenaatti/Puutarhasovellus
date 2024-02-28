namespace Putarhasovellus2
{
    partial class Conifer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conifer));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            takaisinbtn = new Button();
            katajalabel = new Label();
            kuusilabel = new Label();
            tuijatlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(627, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 242);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // takaisinbtn
            // 
            takaisinbtn.BackColor = Color.LightGreen;
            takaisinbtn.Location = new Point(746, 720);
            takaisinbtn.Name = "takaisinbtn";
            takaisinbtn.Size = new Size(143, 48);
            takaisinbtn.TabIndex = 22;
            takaisinbtn.Text = "takaisin";
            takaisinbtn.UseVisualStyleBackColor = false;
            takaisinbtn.Click += Backbtn_Click;
            // 
            // katajalabel
            // 
            katajalabel.AutoSize = true;
            katajalabel.BackColor = Color.LightGreen;
            katajalabel.Location = new Point(259, 30);
            katajalabel.Name = "katajalabel";
            katajalabel.Size = new Size(311, 325);
            katajalabel.TabIndex = 23;
            katajalabel.Text = resources.GetString("katajalabel.Text");
            // 
            // kuusilabel
            // 
            kuusilabel.AutoSize = true;
            kuusilabel.BackColor = Color.LightGreen;
            kuusilabel.Location = new Point(279, 374);
            kuusilabel.Name = "kuusilabel";
            kuusilabel.Size = new Size(291, 375);
            kuusilabel.TabIndex = 24;
            kuusilabel.Text = resources.GetString("kuusilabel.Text");
            // 
            // tuijatlabel
            // 
            tuijatlabel.AutoSize = true;
            tuijatlabel.BackColor = Color.LightGreen;
            tuijatlabel.Location = new Point(600, 287);
            tuijatlabel.Name = "tuijatlabel";
            tuijatlabel.Size = new Size(289, 425);
            tuijatlabel.TabIndex = 25;
            tuijatlabel.Text = resources.GetString("tuijatlabel.Text");
            // 
            // Conifer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(913, 780);
            Controls.Add(tuijatlabel);
            Controls.Add(kuusilabel);
            Controls.Add(katajalabel);
            Controls.Add(takaisinbtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Conifer";
            Text = "havut";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button takaisinbtn;
        private Label katajalabel;
        private Label kuusilabel;
        private Label tuijatlabel;
    }
}