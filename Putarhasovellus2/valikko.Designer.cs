namespace Putarhasovellus2
{
    partial class valikko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(valikko));
            Pensat = new Button();
            Pensaat = new Button();
            Liljat = new Button();
            Köynnökset = new Button();
            Kesäkukat = new Button();
            Hyötykasvit = new Button();
            Huonekasvit = new Button();
            Havukasvit = new Button();
            Kasvit = new Label();
            SuspendLayout();
            // 
            // Pensat
            // 
            Pensat.BackColor = Color.Plum;
            Pensat.Location = new Point(386, 349);
            Pensat.Margin = new Padding(2);
            Pensat.Name = "Pensat";
            Pensat.Size = new Size(148, 46);
            Pensat.TabIndex = 26;
            Pensat.Text = "Perennat";
            Pensat.UseVisualStyleBackColor = false;
            Pensat.Click += Pensat_Click;
            // 
            // Pensaat
            // 
            Pensaat.BackColor = Color.SeaGreen;
            Pensaat.Location = new Point(386, 166);
            Pensaat.Margin = new Padding(2);
            Pensaat.Name = "Pensaat";
            Pensaat.Size = new Size(148, 46);
            Pensaat.TabIndex = 25;
            Pensaat.Text = "Pensaat";
            Pensaat.UseVisualStyleBackColor = false;
            Pensaat.Click += Pensaat_Click;
            // 
            // Liljat
            // 
            Liljat.BackColor = Color.DarkViolet;
            Liljat.Location = new Point(386, 258);
            Liljat.Margin = new Padding(2);
            Liljat.Name = "Liljat";
            Liljat.Size = new Size(148, 46);
            Liljat.TabIndex = 24;
            Liljat.Text = "Liljat";
            Liljat.UseVisualStyleBackColor = false;
            Liljat.Click += Liljat_Click;
            // 
            // Köynnökset
            // 
            Köynnökset.BackColor = Color.ForestGreen;
            Köynnökset.Location = new Point(386, 70);
            Köynnökset.Margin = new Padding(2);
            Köynnökset.Name = "Köynnökset";
            Köynnökset.Size = new Size(148, 46);
            Köynnökset.TabIndex = 23;
            Köynnökset.Text = "Köynnökset";
            Köynnökset.UseVisualStyleBackColor = false;
            // Köynnökset.Click += koynnokset_Click;
            // 
            // Kesäkukat
            // 
            Kesäkukat.BackColor = Color.LightCoral;
            Kesäkukat.Location = new Point(51, 349);
            Kesäkukat.Margin = new Padding(2);
            Kesäkukat.Name = "Kesäkukat";
            Kesäkukat.Size = new Size(148, 46);
            Kesäkukat.TabIndex = 22;
            Kesäkukat.Text = "Kesäkukat";
            Kesäkukat.UseVisualStyleBackColor = false;
            Kesäkukat.Click += kesakukat_Click;
            // 
            // Hyötykasvit
            // 
            Hyötykasvit.BackColor = Color.LemonChiffon;
            Hyötykasvit.Location = new Point(51, 258);
            Hyötykasvit.Margin = new Padding(2);
            Hyötykasvit.Name = "Hyötykasvit";
            Hyötykasvit.Size = new Size(148, 46);
            Hyötykasvit.TabIndex = 21;
            Hyötykasvit.Text = "Hyötykasvit";
            Hyötykasvit.UseVisualStyleBackColor = false;
            Hyötykasvit.Click += hyotykasvit_Click;
            // 
            // Huonekasvit
            // 
            Huonekasvit.BackColor = Color.PaleGreen;
            Huonekasvit.Location = new Point(51, 166);
            Huonekasvit.Margin = new Padding(2);
            Huonekasvit.Name = "Huonekasvit";
            Huonekasvit.Size = new Size(148, 46);
            Huonekasvit.TabIndex = 20;
            Huonekasvit.Text = "Huonekasvit";
            Huonekasvit.UseVisualStyleBackColor = false;
            Huonekasvit.Click += Huonekasvit_Click;
            // 
            // Havukasvit
            // 
            Havukasvit.BackColor = Color.ForestGreen;
            Havukasvit.Location = new Point(51, 70);
            Havukasvit.Margin = new Padding(2);
            Havukasvit.Name = "Havukasvit";
            Havukasvit.Size = new Size(148, 46);
            Havukasvit.TabIndex = 19;
            Havukasvit.Text = "Havukasvit";
            Havukasvit.UseVisualStyleBackColor = false;
            Havukasvit.Click += Havukasvit_Click;
            // 
            // Kasvit
            // 
            Kasvit.AutoSize = true;
            Kasvit.BackColor = Color.White;
            Kasvit.Location = new Point(272, 20);
            Kasvit.Margin = new Padding(2, 0, 2, 0);
            Kasvit.Name = "Kasvit";
            Kasvit.Size = new Size(38, 15);
            Kasvit.TabIndex = 18;
            Kasvit.Text = "Kasvit";
            // 
            // valikko
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(564, 438);
            Controls.Add(Pensat);
            Controls.Add(Pensaat);
            Controls.Add(Liljat);
            Controls.Add(Köynnökset);
            Controls.Add(Kesäkukat);
            Controls.Add(Hyötykasvit);
            Controls.Add(Huonekasvit);
            Controls.Add(Havukasvit);
            Controls.Add(Kasvit);
            Margin = new Padding(2);
            Name = "valikko";
            Text = "valikko";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pensat;
        private Button Pensaat;
        private Button Liljat;
        private Button Köynnökset;
        private Button Kesäkukat;
        private Button Hyötykasvit;
        private Button Huonekasvit;
        private Button Havukasvit;
        private Label Kasvit;
    }
}