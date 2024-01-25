namespace Putarhasovellus2
{
    partial class Valikko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valikko));
            Liljat = new Button();
            Kesäkukat = new Button();
            Huonekasvit = new Button();
            Havukasvit = new Button();
            Kasvit = new Label();
            SuspendLayout();
            // 
            // Liljat
            // 
            Liljat.BackColor = Color.DarkViolet;
            Liljat.Location = new Point(73, 274);
            Liljat.Name = "Liljat";
            Liljat.Size = new Size(211, 77);
            Liljat.TabIndex = 24;
            Liljat.Text = "Liljat";
            Liljat.UseVisualStyleBackColor = false;
            Liljat.Click += Button7_Click;
            // 
            // Kesäkukat
            // 
            Kesäkukat.BackColor = Color.LightCoral;
            Kesäkukat.Location = new Point(540, 274);
            Kesäkukat.Name = "Kesäkukat";
            Kesäkukat.Size = new Size(211, 77);
            Kesäkukat.TabIndex = 22;
            Kesäkukat.Text = "Kesäkukat";
            Kesäkukat.UseVisualStyleBackColor = false;
            Kesäkukat.Click += Button4_Click;
            // 
            // Huonekasvit
            // 
            Huonekasvit.BackColor = Color.PaleGreen;
            Huonekasvit.Location = new Point(540, 117);
            Huonekasvit.Name = "Huonekasvit";
            Huonekasvit.Size = new Size(211, 77);
            Huonekasvit.TabIndex = 20;
            Huonekasvit.Text = "Huonekasvit";
            Huonekasvit.UseVisualStyleBackColor = false;
            Huonekasvit.Click += Button2_Click;
            // 
            // Havukasvit
            // 
            Havukasvit.BackColor = Color.ForestGreen;
            Havukasvit.Location = new Point(73, 117);
            Havukasvit.Name = "Havukasvit";
            Havukasvit.Size = new Size(211, 77);
            Havukasvit.TabIndex = 19;
            Havukasvit.Text = "Havukasvit";
            Havukasvit.UseVisualStyleBackColor = false;
            Havukasvit.Click += Button1_Click;
            // 
            // Kasvit
            // 
            Kasvit.AutoSize = true;
            Kasvit.BackColor = Color.White;
            Kasvit.Location = new Point(389, 33);
            Kasvit.Name = "Kasvit";
            Kasvit.Size = new Size(58, 25);
            Kasvit.TabIndex = 18;
            Kasvit.Text = "Kasvit";
            // 
            // Valikko
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 445);
            Controls.Add(Liljat);
            Controls.Add(Kesäkukat);
            Controls.Add(Huonekasvit);
            Controls.Add(Havukasvit);
            Controls.Add(Kasvit);
            Name = "Valikko";
            Text = "valikko";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Liljat;
        private Button Kesäkukat;
        private Button Huonekasvit;
        private Button Havukasvit;
        private Label Kasvit;
    }
}