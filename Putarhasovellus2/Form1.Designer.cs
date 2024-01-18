namespace Putarhasovellus2
{
    partial class Eka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            valikkobtn = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // valikkobtn
            // 
            valikkobtn.Location = new Point(313, 288);
            valikkobtn.Name = "valikkobtn";
            valikkobtn.Size = new Size(177, 51);
            valikkobtn.TabIndex = 13;
            valikkobtn.Text = "Kasvivalikkoon";
            valikkobtn.UseVisualStyleBackColor = true;
            valikkobtn.Click += valikkobtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 191);
            label3.Name = "label3";
            label3.Size = new Size(677, 25);
            label3.TabIndex = 12;
            label3.Text = "Sovellus on apuna kasvien hankintaan. Kasveista löytyy myös tietoja ja hoito-ohjeita.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGreen;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(240, 91);
            label1.Name = "label1";
            label1.Size = new Size(316, 25);
            label1.TabIndex = 11;
            label1.Text = "Tervetuloa Pekan puutarhasovellukeen!";
            // 
            // Eka
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(valikkobtn);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Eka";
            Text = "eka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button valikkobtn;
        private Label label3;
        private Label label1;
    }
}
