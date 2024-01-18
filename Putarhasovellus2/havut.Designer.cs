namespace Putarhasovellus2
{
    partial class Havut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Havut));
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
            pictureBox3.Location = new Point(539, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 240);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 368);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 277);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // takaisinbtn
            // 
            takaisinbtn.Location = new Point(621, 660);
            takaisinbtn.Name = "takaisinbtn";
            takaisinbtn.Size = new Size(143, 70);
            takaisinbtn.TabIndex = 22;
            takaisinbtn.Text = "takaisin";
            takaisinbtn.UseVisualStyleBackColor = true;
            takaisinbtn.Click += Backbtn_Click;
            // 
            // katajalabel
            // 
            katajalabel.AutoSize = true;
            katajalabel.Location = new Point(256, 60);
            katajalabel.Name = "katajalabel";
            katajalabel.Size = new Size(249, 275);
            katajalabel.TabIndex = 23;
            katajalabel.Text = "Kataja                                      \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // kuusilabel
            // 
            kuusilabel.AutoSize = true;
            kuusilabel.Location = new Point(241, 368);
            kuusilabel.Name = "kuusilabel";
            kuusilabel.Size = new Size(264, 275);
            kuusilabel.TabIndex = 24;
            kuusilabel.Text = "Kuusi                                          \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // tuijatlabel
            // 
            tuijatlabel.AutoSize = true;
            tuijatlabel.Location = new Point(541, 333);
            tuijatlabel.Name = "tuijatlabel";
            tuijatlabel.Size = new Size(228, 300);
            tuijatlabel.TabIndex = 25;
            tuijatlabel.Text = "Tuija                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Havut
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 742);
            Controls.Add(tuijatlabel);
            Controls.Add(kuusilabel);
            Controls.Add(katajalabel);
            Controls.Add(takaisinbtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Havut";
            Text = "havut";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button takaisinbtn;
        private Label katajalabel;
        private Label kuusilabel;
        private Label tuijatlabel;
    }
}