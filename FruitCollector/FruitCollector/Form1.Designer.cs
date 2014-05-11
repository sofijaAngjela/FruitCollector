namespace FruitCollector
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.QuitB = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.FruitSaladButton = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Naslov = new System.Windows.Forms.Label();
            this.pbPehar = new System.Windows.Forms.PictureBox();
            this.lHighScore = new System.Windows.Forms.Label();
            this.high = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPehar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FruitCollector.Properties.Resources.ov20;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.high);
            this.panel1.Controls.Add(this.lHighScore);
            this.panel1.Controls.Add(this.pbPehar);
            this.panel1.Controls.Add(this.panelStart);
            this.panel1.Controls.Add(this.panelInfo);
            this.panel1.Controls.Add(this.Naslov);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 477);
            this.panel1.TabIndex = 0;
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.Transparent;
            this.panelStart.Controls.Add(this.label1);
            this.panelStart.Controls.Add(this.tbName);
            this.panelStart.Controls.Add(this.StartGame);
            this.panelStart.Location = new System.Drawing.Point(403, 164);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(270, 114);
            this.panelStart.TabIndex = 2;
            this.panelStart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12.5F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a name:";
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbName.Location = new System.Drawing.Point(9, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 20);
            this.tbName.TabIndex = 5;
            this.tbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseClick);
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseDown);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Gold;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.Location = new System.Drawing.Point(9, 79);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(258, 32);
            this.StartGame.TabIndex = 4;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            this.StartGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartGame_KeyDown);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.QuitB);
            this.panelInfo.Controls.Add(this.Help);
            this.panelInfo.Controls.Add(this.FruitSaladButton);
            this.panelInfo.Controls.Add(this.NewGame);
            this.panelInfo.Location = new System.Drawing.Point(51, 164);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(311, 273);
            this.panelInfo.TabIndex = 1;
            // 
            // QuitB
            // 
            this.QuitB.BackColor = System.Drawing.Color.Gold;
            this.QuitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitB.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuitB.Location = new System.Drawing.Point(24, 200);
            this.QuitB.Name = "QuitB";
            this.QuitB.Size = new System.Drawing.Size(258, 32);
            this.QuitB.TabIndex = 3;
            this.QuitB.Text = "Quit";
            this.QuitB.UseVisualStyleBackColor = false;
            this.QuitB.Click += new System.EventHandler(this.QuitB_Click);
            this.QuitB.MouseEnter += new System.EventHandler(this.QuitB_MouseEnter);
            this.QuitB.MouseLeave += new System.EventHandler(this.QuitB_MouseLeave);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Gold;
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.Location = new System.Drawing.Point(24, 137);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(258, 32);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            this.Help.MouseEnter += new System.EventHandler(this.Help_MouseEnter);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            // 
            // FruitSaladButton
            // 
            this.FruitSaladButton.BackColor = System.Drawing.Color.Gold;
            this.FruitSaladButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FruitSaladButton.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FruitSaladButton.Location = new System.Drawing.Point(24, 82);
            this.FruitSaladButton.Name = "FruitSaladButton";
            this.FruitSaladButton.Size = new System.Drawing.Size(258, 32);
            this.FruitSaladButton.TabIndex = 1;
            this.FruitSaladButton.Text = "Mix a Fruit Salad";
            this.FruitSaladButton.UseVisualStyleBackColor = false;
            this.FruitSaladButton.Click += new System.EventHandler(this.FruitSaladButton_Click);
            this.FruitSaladButton.MouseEnter += new System.EventHandler(this.FruitSaladButton_MouseEnter);
            this.FruitSaladButton.MouseLeave += new System.EventHandler(this.FruitSaladButton_MouseLeave);
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.Gold;
            this.NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGame.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.Location = new System.Drawing.Point(24, 20);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(258, 32);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            this.NewGame.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.NewGame.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.Transparent;
            this.Naslov.Font = new System.Drawing.Font("Buxton Sketch", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Naslov.ForeColor = System.Drawing.Color.Gold;
            this.Naslov.Location = new System.Drawing.Point(84, 23);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(278, 119);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Naslov";
            // 
            // pbPehar
            // 
            this.pbPehar.BackColor = System.Drawing.Color.Transparent;
            this.pbPehar.Image = global::FruitCollector.Properties.Resources.goblet1;
            this.pbPehar.Location = new System.Drawing.Point(563, 23);
            this.pbPehar.Name = "pbPehar";
            this.pbPehar.Size = new System.Drawing.Size(107, 65);
            this.pbPehar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPehar.TabIndex = 3;
            this.pbPehar.TabStop = false;
            this.pbPehar.Click += new System.EventHandler(this.pbPehar_Click);
            // 
            // lHighScore
            // 
            this.lHighScore.AutoSize = true;
            this.lHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lHighScore.Font = new System.Drawing.Font("Curlz MT", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHighScore.ForeColor = System.Drawing.Color.Gold;
            this.lHighScore.Location = new System.Drawing.Point(421, 23);
            this.lHighScore.Name = "lHighScore";
            this.lHighScore.Size = new System.Drawing.Size(136, 33);
            this.lHighScore.TabIndex = 4;
            this.lHighScore.Text = "High scores";
            // 
            // high
            // 
            this.high.AutoSize = true;
            this.high.Location = new System.Drawing.Point(427, 74);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(27, 13);
            this.high.TabIndex = 5;
            this.high.Text = "high";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 477);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPehar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button QuitB;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button FruitSaladButton;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPehar;
        private System.Windows.Forms.Label lHighScore;
        private System.Windows.Forms.Label high;
    }
}

