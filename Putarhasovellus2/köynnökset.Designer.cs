namespace Putarhasovellus2
{
    partial class Koynnokset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Koynnokset));
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            takaisinbtn = new Button();
            yksivuotinenkoynnosLabe = new Label();
            monivuotinenkoynnosLabel = new Label();
            karhotlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 323);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(155, 278);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 240);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(451, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // takaisinbtn
            // 
            takaisinbtn.Location = new Point(670, 532);
            takaisinbtn.Name = "takaisinbtn";
            takaisinbtn.Size = new Size(137, 73);
            takaisinbtn.TabIndex = 14;
            takaisinbtn.Text = "takaisin";
            takaisinbtn.UseVisualStyleBackColor = true;
            takaisinbtn.Click += Backbtn_Click;
            // 
            // yksivuotinenkoynnosLabe
            // 
            yksivuotinenkoynnosLabe.AutoSize = true;
            yksivuotinenkoynnosLabe.Location = new Point(194, 329);
            yksivuotinenkoynnosLabe.Name = "yksivuotinenkoynnosLabe";
            yksivuotinenkoynnosLabe.Size = new Size(185, 25);
            yksivuotinenkoynnosLabe.TabIndex = 15;
            yksivuotinenkoynnosLabe.Text = "Yksivuotinen köynnös";
            // 
            // monivuotinenkoynnosLabel
            // 
            monivuotinenkoynnosLabel.AutoSize = true;
            monivuotinenkoynnosLabel.Location = new Point(233, 56);
            monivuotinenkoynnosLabel.Name = "monivuotinenkoynnosLabel";
            monivuotinenkoynnosLabel.Size = new Size(195, 25);
            monivuotinenkoynnosLabel.TabIndex = 16;
            monivuotinenkoynnosLabel.Text = "Monivuotinen köynnös";
            // 
            // karhotlabel
            // 
            karhotlabel.AutoSize = true;
            karhotlabel.Location = new Point(451, 236);
            karhotlabel.Name = "karhotlabel";
            karhotlabel.Size = new Size(64, 25);
            karhotlabel.TabIndex = 17;
            karhotlabel.Text = "Kärhöt";
            // 
            // Koynnokset
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 621);
            Controls.Add(karhotlabel);
            Controls.Add(monivuotinenkoynnosLabel);
            Controls.Add(yksivuotinenkoynnosLabe);
            Controls.Add(takaisinbtn);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "Koynnokset";
            Text = "köynnökset";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button takaisinbtn;
        private Label yksivuotinenkoynnosLabe;
        private Label monivuotinenkoynnosLabel;
        private Label karhotlabel;
    }
}