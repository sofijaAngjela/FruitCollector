namespace FruitCollector
{
    partial class FruitSaladGame
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
            this.GenerirajOvoshje = new System.Windows.Forms.Panel();
            this.Play = new System.Windows.Forms.Button();
            this.Sokrij = new System.Windows.Forms.Panel();
            this.Jabolki = new System.Windows.Forms.PictureBox();
            this.lblJagodi = new System.Windows.Forms.Label();
            this.lblJabolki = new System.Windows.Forms.Label();
            this.Jagodi = new System.Windows.Forms.PictureBox();
            this.lblKryshi = new System.Windows.Forms.Label();
            this.Banani = new System.Windows.Forms.PictureBox();
            this.lblBanani = new System.Windows.Forms.Label();
            this.Krushi = new System.Windows.Forms.PictureBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Ovoshje = new System.Windows.Forms.Label();
            this.lblJagodi1 = new System.Windows.Forms.Label();
            this.lblJabolki1 = new System.Windows.Forms.Label();
            this.lblKryshi1 = new System.Windows.Forms.Label();
            this.lblBanani1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.igrajPak1 = new System.Windows.Forms.Panel();
            this.Quit1 = new System.Windows.Forms.Button();
            this.PlayAgain1 = new System.Windows.Forms.Button();
            this.komentar1 = new System.Windows.Forms.Label();
            this.GenerirajOvoshje.SuspendLayout();
            this.Sokrij.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jabolki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jagodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Krushi)).BeginInit();
            this.igrajPak1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerirajOvoshje
            // 
            this.GenerirajOvoshje.BackColor = System.Drawing.Color.Gold;
            this.GenerirajOvoshje.Controls.Add(this.Play);
            this.GenerirajOvoshje.Controls.Add(this.Sokrij);
            this.GenerirajOvoshje.Controls.Add(this.Generate);
            this.GenerirajOvoshje.Controls.Add(this.Ovoshje);
            this.GenerirajOvoshje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerirajOvoshje.Location = new System.Drawing.Point(113, 59);
            this.GenerirajOvoshje.Name = "GenerirajOvoshje";
            this.GenerirajOvoshje.Size = new System.Drawing.Size(495, 359);
            this.GenerirajOvoshje.TabIndex = 9;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Play.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Play.Location = new System.Drawing.Point(120, 288);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(215, 33);
            this.Play.TabIndex = 11;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Sokrij
            // 
            this.Sokrij.Controls.Add(this.Jabolki);
            this.Sokrij.Controls.Add(this.lblJagodi);
            this.Sokrij.Controls.Add(this.lblJabolki);
            this.Sokrij.Controls.Add(this.Jagodi);
            this.Sokrij.Controls.Add(this.lblKryshi);
            this.Sokrij.Controls.Add(this.Banani);
            this.Sokrij.Controls.Add(this.lblBanani);
            this.Sokrij.Controls.Add(this.Krushi);
            this.Sokrij.Location = new System.Drawing.Point(20, 143);
            this.Sokrij.Name = "Sokrij";
            this.Sokrij.Size = new System.Drawing.Size(456, 100);
            this.Sokrij.TabIndex = 10;
            this.Sokrij.Visible = false;
            // 
            // Jabolki
            // 
            this.Jabolki.BackColor = System.Drawing.Color.Transparent;
            this.Jabolki.Image = global::FruitCollector.Properties.Resources.Bitmap2;
            this.Jabolki.Location = new System.Drawing.Point(13, 23);
            this.Jabolki.Name = "Jabolki";
            this.Jabolki.Size = new System.Drawing.Size(54, 50);
            this.Jabolki.TabIndex = 2;
            this.Jabolki.TabStop = false;
            this.Jabolki.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblJagodi
            // 
            this.lblJagodi.AutoSize = true;
            this.lblJagodi.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJagodi.Location = new System.Drawing.Point(398, 39);
            this.lblJagodi.Name = "lblJagodi";
            this.lblJagodi.Size = new System.Drawing.Size(56, 26);
            this.lblJagodi.TabIndex = 9;
            this.lblJagodi.Text = "label4";
            // 
            // lblJabolki
            // 
            this.lblJabolki.AutoSize = true;
            this.lblJabolki.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabolki.Location = new System.Drawing.Point(73, 39);
            this.lblJabolki.Name = "lblJabolki";
            this.lblJabolki.Size = new System.Drawing.Size(50, 26);
            this.lblJabolki.TabIndex = 6;
            this.lblJabolki.Text = "label1";
            // 
            // Jagodi
            // 
            this.Jagodi.BackColor = System.Drawing.Color.Transparent;
            this.Jagodi.Image = global::FruitCollector.Properties.Resources.Bitmap7;
            this.Jagodi.Location = new System.Drawing.Point(329, 23);
            this.Jagodi.Name = "Jagodi";
            this.Jagodi.Size = new System.Drawing.Size(54, 50);
            this.Jagodi.TabIndex = 5;
            this.Jagodi.TabStop = false;
            // 
            // lblKryshi
            // 
            this.lblKryshi.AutoSize = true;
            this.lblKryshi.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKryshi.Location = new System.Drawing.Point(288, 39);
            this.lblKryshi.Name = "lblKryshi";
            this.lblKryshi.Size = new System.Drawing.Size(57, 26);
            this.lblKryshi.TabIndex = 8;
            this.lblKryshi.Text = "label3";
            // 
            // Banani
            // 
            this.Banani.BackColor = System.Drawing.Color.Transparent;
            this.Banani.Image = global::FruitCollector.Properties.Resources.Bitmap3;
            this.Banani.Location = new System.Drawing.Point(127, 23);
            this.Banani.Name = "Banani";
            this.Banani.Size = new System.Drawing.Size(54, 50);
            this.Banani.TabIndex = 3;
            this.Banani.TabStop = false;
            // 
            // lblBanani
            // 
            this.lblBanani.AutoSize = true;
            this.lblBanani.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanani.Location = new System.Drawing.Point(187, 39);
            this.lblBanani.Name = "lblBanani";
            this.lblBanani.Size = new System.Drawing.Size(56, 26);
            this.lblBanani.TabIndex = 7;
            this.lblBanani.Text = "label2";
            // 
            // Krushi
            // 
            this.Krushi.BackColor = System.Drawing.Color.Transparent;
            this.Krushi.Image = global::FruitCollector.Properties.Resources.Bitmap5;
            this.Krushi.Location = new System.Drawing.Point(228, 23);
            this.Krushi.Name = "Krushi";
            this.Krushi.Size = new System.Drawing.Size(54, 50);
            this.Krushi.TabIndex = 4;
            this.Krushi.TabStop = false;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Generate.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Generate.Location = new System.Drawing.Point(120, 75);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(215, 33);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Ovoshje
            // 
            this.Ovoshje.AutoSize = true;
            this.Ovoshje.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ovoshje.Location = new System.Drawing.Point(142, 20);
            this.Ovoshje.Name = "Ovoshje";
            this.Ovoshje.Size = new System.Drawing.Size(174, 26);
            this.Ovoshje.TabIndex = 0;
            this.Ovoshje.Text = "Generate a fruit salad";
            // 
            // lblJagodi1
            // 
            this.lblJagodi1.AutoSize = true;
            this.lblJagodi1.BackColor = System.Drawing.Color.Transparent;
            this.lblJagodi1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJagodi1.Location = new System.Drawing.Point(631, 24);
            this.lblJagodi1.Name = "lblJagodi1";
            this.lblJagodi1.Size = new System.Drawing.Size(42, 20);
            this.lblJagodi1.TabIndex = 9;
            this.lblJagodi1.Text = "label4";
            // 
            // lblJabolki1
            // 
            this.lblJabolki1.AutoSize = true;
            this.lblJabolki1.BackColor = System.Drawing.Color.Transparent;
            this.lblJabolki1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJabolki1.Location = new System.Drawing.Point(377, 24);
            this.lblJabolki1.Name = "lblJabolki1";
            this.lblJabolki1.Size = new System.Drawing.Size(38, 20);
            this.lblJabolki1.TabIndex = 6;
            this.lblJabolki1.Text = "label1";
            // 
            // lblKryshi1
            // 
            this.lblKryshi1.AutoSize = true;
            this.lblKryshi1.BackColor = System.Drawing.Color.Transparent;
            this.lblKryshi1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKryshi1.Location = new System.Drawing.Point(546, 24);
            this.lblKryshi1.Name = "lblKryshi1";
            this.lblKryshi1.Size = new System.Drawing.Size(43, 20);
            this.lblKryshi1.TabIndex = 8;
            this.lblKryshi1.Text = "label3";
            // 
            // lblBanani1
            // 
            this.lblBanani1.AutoSize = true;
            this.lblBanani1.BackColor = System.Drawing.Color.Transparent;
            this.lblBanani1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBanani1.Location = new System.Drawing.Point(458, 24);
            this.lblBanani1.Name = "lblBanani1";
            this.lblBanani1.Size = new System.Drawing.Size(42, 20);
            this.lblBanani1.TabIndex = 7;
            this.lblBanani1.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // igrajPak1
            // 
            this.igrajPak1.BackColor = System.Drawing.Color.Gold;
            this.igrajPak1.Controls.Add(this.Quit1);
            this.igrajPak1.Controls.Add(this.PlayAgain1);
            this.igrajPak1.Controls.Add(this.komentar1);
            this.igrajPak1.Location = new System.Drawing.Point(635, 106);
            this.igrajPak1.Name = "igrajPak1";
            this.igrajPak1.Size = new System.Drawing.Size(262, 359);
            this.igrajPak1.TabIndex = 1;
            this.igrajPak1.Visible = false;
            // 
            // Quit1
            // 
            this.Quit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Quit1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quit1.Location = new System.Drawing.Point(26, 300);
            this.Quit1.Name = "Quit1";
            this.Quit1.Size = new System.Drawing.Size(215, 33);
            this.Quit1.TabIndex = 14;
            this.Quit1.Text = "main menu";
            this.Quit1.UseVisualStyleBackColor = false;
            this.Quit1.Click += new System.EventHandler(this.Quit1_Click);
            // 
            // PlayAgain1
            // 
            this.PlayAgain1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PlayAgain1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayAgain1.Location = new System.Drawing.Point(26, 260);
            this.PlayAgain1.Name = "PlayAgain1";
            this.PlayAgain1.Size = new System.Drawing.Size(215, 33);
            this.PlayAgain1.TabIndex = 13;
            this.PlayAgain1.Text = "Play again";
            this.PlayAgain1.UseVisualStyleBackColor = false;
            this.PlayAgain1.Click += new System.EventHandler(this.PlayAgain1_Click);
            // 
            // komentar1
            // 
            this.komentar1.Font = new System.Drawing.Font("Buxton Sketch", 20.25F);
            this.komentar1.Location = new System.Drawing.Point(20, 25);
            this.komentar1.Name = "komentar1";
            this.komentar1.Size = new System.Drawing.Size(209, 94);
            this.komentar1.TabIndex = 0;
            this.komentar1.Text = "Komentar";
            // 
            // FruitSaladGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitCollector.Properties.Resources.grassZasekoga66KRAJ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 477);
            this.Controls.Add(this.igrajPak1);
            this.Controls.Add(this.lblJagodi1);
            this.Controls.Add(this.lblJabolki1);
            this.Controls.Add(this.lblKryshi1);
            this.Controls.Add(this.lblBanani1);
            this.Controls.Add(this.GenerirajOvoshje);
            this.KeyPreview = true;
            this.Name = "FruitSaladGame";
            this.Text = "FruitSaladGame";
            this.Load += new System.EventHandler(this.FruitSaladGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FruitSaladGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FruitSaladGame_KeyDown);
            this.Resize += new System.EventHandler(this.FruitSaladGame_Resize);
            this.GenerirajOvoshje.ResumeLayout(false);
            this.GenerirajOvoshje.PerformLayout();
            this.Sokrij.ResumeLayout(false);
            this.Sokrij.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jabolki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jagodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Krushi)).EndInit();
            this.igrajPak1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GenerirajOvoshje;
        private System.Windows.Forms.Label Ovoshje;
        private System.Windows.Forms.PictureBox Jabolki;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Panel Sokrij;
        private System.Windows.Forms.Label lblJagodi;
        private System.Windows.Forms.Label lblJabolki;
        private System.Windows.Forms.PictureBox Jagodi;
        private System.Windows.Forms.Label lblKryshi;
        private System.Windows.Forms.PictureBox Banani;
        private System.Windows.Forms.Label lblBanani;
        private System.Windows.Forms.PictureBox Krushi;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label lblJagodi1;
        private System.Windows.Forms.Label lblJabolki1;
        private System.Windows.Forms.Label lblKryshi1;
        private System.Windows.Forms.Label lblBanani1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel igrajPak1;
        private System.Windows.Forms.Button PlayAgain1;
        private System.Windows.Forms.Label komentar1;
        private System.Windows.Forms.Button Quit1;
    }
}