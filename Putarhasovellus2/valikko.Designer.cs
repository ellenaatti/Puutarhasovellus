namespace Putarhasovellus2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Kasvit = new Label();
            listBox1 = new ListBox();
            button8 = new Button();
            SuspendLayout();
            // 
            // Kasvit
            // 
            Kasvit.AutoSize = true;
            Kasvit.BackColor = Color.FromArgb(255, 192, 255);
            Kasvit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kasvit.Location = new Point(250, 9);
            Kasvit.Margin = new Padding(2, 0, 2, 0);
            Kasvit.Name = "Kasvit";
            Kasvit.Size = new Size(87, 37);
            Kasvit.TabIndex = 18;
            Kasvit.Text = "Kasvit";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 192, 255);
            listBox1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 46;
            listBox1.Items.AddRange(new object[] { "Huonekasvit", "Kesäkukat", "Liljat", "Havut" });
            listBox1.Location = new Point(125, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 188);
            listBox1.TabIndex = 19;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 192, 255);
            button8.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(250, 276);
            button8.Name = "button8";
            button8.Size = new Size(102, 37);
            button8.TabIndex = 20;
            button8.Text = "Sivulle";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 325);
            Controls.Add(button8);
            Controls.Add(listBox1);
            Controls.Add(Kasvit);
            Margin = new Padding(2);
            Name = "Menu";
            Text = "valikko";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Kasvit;
        private ListBox listBox1;
        private Button button8;
    }
}