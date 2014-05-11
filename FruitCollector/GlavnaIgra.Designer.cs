namespace FruitCollector
{
    partial class GlavnaIgra
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
            this.components = new System.ComponentModel.Container();
            this.FinalCountDown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lHits = new System.Windows.Forms.Label();
            this.lHitss = new System.Windows.Forms.Label();
            this.lPoints1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.IgrajPak = new System.Windows.Forms.Panel();
            this.Poeni = new System.Windows.Forms.Label();
            this.Ime1 = new System.Windows.Forms.Label();
            this.Komentar = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.vnesiIme = new System.Windows.Forms.Label();
            this.IgrajPak.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinalCountDown
            // 
            this.FinalCountDown.BackColor = System.Drawing.Color.Transparent;
            this.FinalCountDown.Font = new System.Drawing.Font("Buxton Sketch", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCountDown.ForeColor = System.Drawing.Color.Gold;
            this.FinalCountDown.Location = new System.Drawing.Point(275, 147);
            this.FinalCountDown.Name = "FinalCountDown";
            this.FinalCountDown.Size = new System.Drawing.Size(316, 129);
            this.FinalCountDown.TabIndex = 0;
            this.FinalCountDown.Text = "Viktor";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(628, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "LIVES";
            // 
            // lHits
            // 
            this.lHits.AutoSize = true;
            this.lHits.BackColor = System.Drawing.Color.Transparent;
            this.lHits.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHits.ForeColor = System.Drawing.Color.Gold;
            this.lHits.Location = new System.Drawing.Point(606, 42);
            this.lHits.Name = "lHits";
            this.lHits.Size = new System.Drawing.Size(48, 23);
            this.lHits.TabIndex = 4;
            this.lHits.Text = "Hits :";
            // 
            // lHitss
            // 
            this.lHitss.AutoSize = true;
            this.lHitss.BackColor = System.Drawing.Color.Transparent;
            this.lHitss.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHitss.Location = new System.Drawing.Point(660, 37);
            this.lHitss.Name = "lHitss";
            this.lHitss.Size = new System.Drawing.Size(26, 26);
            this.lHitss.TabIndex = 6;
            this.lHitss.Text = "0";
            
            // 
            // lPoints1
            // 
            this.lPoints1.AutoSize = true;
            this.lPoints1.BackColor = System.Drawing.Color.Transparent;
            this.lPoints1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPoints1.Location = new System.Drawing.Point(106, 42);
            this.lPoints1.Name = "lPoints1";
            this.lPoints1.Size = new System.Drawing.Size(26, 26);
            this.lPoints1.TabIndex = 7;
            this.lPoints1.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // IgrajPak
            // 
            this.IgrajPak.BackColor = System.Drawing.Color.Gold;
            this.IgrajPak.Controls.Add(this.Poeni);
            this.IgrajPak.Controls.Add(this.Ime1);
            this.IgrajPak.Controls.Add(this.Komentar);
            this.IgrajPak.Controls.Add(this.Quit);
            this.IgrajPak.Controls.Add(this.PlayAgain);
            this.IgrajPak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IgrajPak.Location = new System.Drawing.Point(216, 32);
            this.IgrajPak.Name = "IgrajPak";
            this.IgrajPak.Size = new System.Drawing.Size(262, 359);
            this.IgrajPak.TabIndex = 8;
            this.IgrajPak.Visible = false;
            // 
            // Poeni
            // 
            this.Poeni.AutoSize = true;
            this.Poeni.BackColor = System.Drawing.Color.Transparent;
            this.Poeni.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poeni.Location = new System.Drawing.Point(189, 199);
            this.Poeni.Name = "Poeni";
            this.Poeni.Size = new System.Drawing.Size(26, 26);
            this.Poeni.TabIndex = 12;
            this.Poeni.Text = "0";
            // 
            // Ime1
            // 
            this.Ime1.BackColor = System.Drawing.Color.Transparent;
            this.Ime1.Font = new System.Drawing.Font("Ravie", 14.25F);
            this.Ime1.Location = new System.Drawing.Point(26, 199);
            this.Ime1.Name = "Ime1";
            this.Ime1.Size = new System.Drawing.Size(135, 45);
            this.Ime1.TabIndex = 11;
            this.Ime1.Text = "ime";
            // 
            // Komentar
            // 
            this.Komentar.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Komentar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Komentar.Location = new System.Drawing.Point(26, 20);
            this.Komentar.Name = "Komentar";
            this.Komentar.Size = new System.Drawing.Size(215, 179);
            this.Komentar.TabIndex = 2;
            this.Komentar.Text = "Komentar";
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Quit.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quit.Location = new System.Drawing.Point(26, 300);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(215, 33);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "main manu";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PlayAgain.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayAgain.Location = new System.Drawing.Point(26, 260);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(215, 33);
            this.PlayAgain.TabIndex = 0;
            this.PlayAgain.Text = "PlayAgain";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.ForeColor = System.Drawing.Color.Gold;
            this.Points.Location = new System.Drawing.Point(12, 42);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(88, 29);
            this.Points.TabIndex = 5;
            this.Points.Text = "Points : ";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.BackColor = System.Drawing.Color.Transparent;
            this.Ime.Font = new System.Drawing.Font("Buxton Sketch", 18F);
            this.Ime.ForeColor = System.Drawing.Color.Gold;
            this.Ime.Location = new System.Drawing.Point(12, 9);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(72, 29);
            this.Ime.TabIndex = 9;
            this.Ime.Text = "Player:";
            // 
            // vnesiIme
            // 
            this.vnesiIme.AutoSize = true;
            this.vnesiIme.BackColor = System.Drawing.Color.Transparent;
            this.vnesiIme.Font = new System.Drawing.Font("Ravie", 14.25F);
            this.vnesiIme.Location = new System.Drawing.Point(90, 9);
            this.vnesiIme.Name = "vnesiIme";
            this.vnesiIme.Size = new System.Drawing.Size(58, 26);
            this.vnesiIme.TabIndex = 10;
            this.vnesiIme.Text = "ime";
            // 
            // GlavnaIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitCollector.Properties.Resources.grassZasekoga66KRAJ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 477);
            this.Controls.Add(this.vnesiIme);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.IgrajPak);
            this.Controls.Add(this.lPoints1);
            this.Controls.Add(this.lHitss);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.lHits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinalCountDown);
            this.Name = "GlavnaIgra";
            this.Text = "GlavnaIgra";
           
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GlavnaIgra_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GlavnaIgra_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlavnaIgra_KeyPress);
            this.Resize += new System.EventHandler(this.GlavnaIgra_Resize);
            this.IgrajPak.ResumeLayout(false);
            this.IgrajPak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinalCountDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lHits;
        private System.Windows.Forms.Label lHitss;
        private System.Windows.Forms.Label lPoints1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel IgrajPak;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Label Komentar;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label vnesiIme;
        private System.Windows.Forms.Label Poeni;
        private System.Windows.Forms.Label Ime1;
    }
}