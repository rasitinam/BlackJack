namespace adsascxzcxz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.winlosescreen = new System.Windows.Forms.Label();
            this.btndouble = new System.Windows.Forms.Button();
            this.split = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.dealertext = new System.Windows.Forms.Label();
            this.player1text = new System.Windows.Forms.Label();
            this.player2text = new System.Windows.Forms.Label();
            this.player3text = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.player1boom = new System.Windows.Forms.PictureBox();
            this.player2boom = new System.Windows.Forms.PictureBox();
            this.player3boom = new System.Windows.Forms.PictureBox();
            this.nullpicturebox = new System.Windows.Forms.PictureBox();
            this.player11text = new System.Windows.Forms.Label();
            this.player12text = new System.Windows.Forms.Label();
            this.player21text = new System.Windows.Forms.Label();
            this.player22text = new System.Windows.Forms.Label();
            this.player31text = new System.Windows.Forms.Label();
            this.player32text = new System.Windows.Forms.Label();
            this.hand = new System.Windows.Forms.PictureBox();
            this.esc = new System.Windows.Forms.Button();
            this.bettext1 = new System.Windows.Forms.Label();
            this.bettext2 = new System.Windows.Forms.Label();
            this.bettext3 = new System.Windows.Forms.Label();
            this.balancetext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndouble);
            this.groupBox1.Controls.Add(this.split);
            this.groupBox1.Controls.Add(this.stand);
            this.groupBox1.Controls.Add(this.hit);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(337, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // winlosescreen
            // 
            this.winlosescreen.AutoSize = true;
            this.winlosescreen.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winlosescreen.Location = new System.Drawing.Point(282, 315);
            this.winlosescreen.Name = "winlosescreen";
            this.winlosescreen.Size = new System.Drawing.Size(0, 45);
            this.winlosescreen.TabIndex = 5;
            this.winlosescreen.Visible = false;
            // 
            // btndouble
            // 
            this.btndouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndouble.Image = ((System.Drawing.Image)(resources.GetObject("btndouble.Image")));
            this.btndouble.Location = new System.Drawing.Point(15, 39);
            this.btndouble.Name = "btndouble";
            this.btndouble.Size = new System.Drawing.Size(82, 54);
            this.btndouble.TabIndex = 4;
            this.btndouble.UseVisualStyleBackColor = true;
            this.btndouble.Visible = false;
            this.btndouble.Click += new System.EventHandler(this.btndouble_Click);
            // 
            // split
            // 
            this.split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.split.Image = ((System.Drawing.Image)(resources.GetObject("split.Image")));
            this.split.Location = new System.Drawing.Point(310, 39);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(82, 54);
            this.split.TabIndex = 2;
            this.split.UseVisualStyleBackColor = true;
            this.split.Visible = false;
            this.split.Click += new System.EventHandler(this.split_Click);
            // 
            // stand
            // 
            this.stand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stand.Image = ((System.Drawing.Image)(resources.GetObject("stand.Image")));
            this.stand.Location = new System.Drawing.Point(211, 32);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(82, 69);
            this.stand.TabIndex = 1;
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // hit
            // 
            this.hit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hit.Image = ((System.Drawing.Image)(resources.GetObject("hit.Image")));
            this.hit.Location = new System.Drawing.Point(112, 32);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(82, 69);
            this.hit.TabIndex = 0;
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // dealertext
            // 
            this.dealertext.AutoSize = true;
            this.dealertext.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dealertext.Location = new System.Drawing.Point(482, 200);
            this.dealertext.Name = "dealertext";
            this.dealertext.Size = new System.Drawing.Size(124, 42);
            this.dealertext.TabIndex = 2;
            this.dealertext.Text = "CELAL";
            // 
            // player1text
            // 
            this.player1text.AutoSize = true;
            this.player1text.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1text.Location = new System.Drawing.Point(825, 500);
            this.player1text.Name = "player1text";
            this.player1text.Size = new System.Drawing.Size(52, 42);
            this.player1text.TabIndex = 3;
            this.player1text.Text = "P1";
            // 
            // player2text
            // 
            this.player2text.AutoSize = true;
            this.player2text.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2text.Location = new System.Drawing.Point(512, 500);
            this.player2text.Name = "player2text";
            this.player2text.Size = new System.Drawing.Size(58, 42);
            this.player2text.TabIndex = 4;
            this.player2text.Text = "P2";
            // 
            // player3text
            // 
            this.player3text.AutoSize = true;
            this.player3text.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player3text.Location = new System.Drawing.Point(204, 500);
            this.player3text.Name = "player3text";
            this.player3text.Size = new System.Drawing.Size(59, 42);
            this.player3text.TabIndex = 5;
            this.player3text.Text = "P3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(743, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(427, 557);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(252, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(121, 557);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(252, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // player1boom
            // 
            this.player1boom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player1boom.Image = ((System.Drawing.Image)(resources.GetObject("player1boom.Image")));
            this.player1boom.Location = new System.Drawing.Point(861, 613);
            this.player1boom.Name = "player1boom";
            this.player1boom.Size = new System.Drawing.Size(22, 25);
            this.player1boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1boom.TabIndex = 9;
            this.player1boom.TabStop = false;
            this.player1boom.Visible = false;
            // 
            // player2boom
            // 
            this.player2boom.Image = ((System.Drawing.Image)(resources.GetObject("player2boom.Image")));
            this.player2boom.Location = new System.Drawing.Point(539, 613);
            this.player2boom.Name = "player2boom";
            this.player2boom.Size = new System.Drawing.Size(22, 25);
            this.player2boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2boom.TabIndex = 10;
            this.player2boom.TabStop = false;
            this.player2boom.Visible = false;
            // 
            // player3boom
            // 
            this.player3boom.Image = ((System.Drawing.Image)(resources.GetObject("player3boom.Image")));
            this.player3boom.Location = new System.Drawing.Point(232, 613);
            this.player3boom.Name = "player3boom";
            this.player3boom.Size = new System.Drawing.Size(22, 25);
            this.player3boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player3boom.TabIndex = 11;
            this.player3boom.TabStop = false;
            this.player3boom.Visible = false;
            // 
            // nullpicturebox
            // 
            this.nullpicturebox.Location = new System.Drawing.Point(12, 71);
            this.nullpicturebox.Name = "nullpicturebox";
            this.nullpicturebox.Size = new System.Drawing.Size(17, 14);
            this.nullpicturebox.TabIndex = 12;
            this.nullpicturebox.TabStop = false;
            // 
            // player11text
            // 
            this.player11text.AutoSize = true;
            this.player11text.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player11text.Location = new System.Drawing.Point(917, 500);
            this.player11text.Name = "player11text";
            this.player11text.Size = new System.Drawing.Size(56, 29);
            this.player11text.TabIndex = 13;
            this.player11text.Text = "P1-1";
            this.player11text.Visible = false;
            // 
            // player12text
            // 
            this.player12text.AutoSize = true;
            this.player12text.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player12text.Location = new System.Drawing.Point(773, 500);
            this.player12text.Name = "player12text";
            this.player12text.Size = new System.Drawing.Size(60, 29);
            this.player12text.TabIndex = 14;
            this.player12text.Text = "P1-2";
            this.player12text.Visible = false;
            // 
            // player21text
            // 
            this.player21text.AutoSize = true;
            this.player21text.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player21text.Location = new System.Drawing.Point(590, 500);
            this.player21text.Name = "player21text";
            this.player21text.Size = new System.Drawing.Size(60, 29);
            this.player21text.TabIndex = 15;
            this.player21text.Text = "P2-1";
            this.player21text.Visible = false;
            // 
            // player22text
            // 
            this.player22text.AutoSize = true;
            this.player22text.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player22text.Location = new System.Drawing.Point(453, 500);
            this.player22text.Name = "player22text";
            this.player22text.Size = new System.Drawing.Size(64, 29);
            this.player22text.TabIndex = 16;
            this.player22text.Text = "P2-2";
            this.player22text.Visible = false;
            // 
            // player31text
            // 
            this.player31text.AutoSize = true;
            this.player31text.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player31text.Location = new System.Drawing.Point(285, 500);
            this.player31text.Name = "player31text";
            this.player31text.Size = new System.Drawing.Size(61, 29);
            this.player31text.TabIndex = 17;
            this.player31text.Text = "P3-1";
            this.player31text.Visible = false;
            // 
            // player32text
            // 
            this.player32text.AutoSize = true;
            this.player32text.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player32text.Location = new System.Drawing.Point(143, 500);
            this.player32text.Name = "player32text";
            this.player32text.Size = new System.Drawing.Size(65, 29);
            this.player32text.TabIndex = 18;
            this.player32text.Text = "P3-2";
            this.player32text.Visible = false;
            // 
            // hand
            // 
            this.hand.Image = ((System.Drawing.Image)(resources.GetObject("hand.Image")));
            this.hand.Location = new System.Drawing.Point(832, 426);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(69, 71);
            this.hand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hand.TabIndex = 19;
            this.hand.TabStop = false;
            // 
            // esc
            // 
            this.esc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esc.Location = new System.Drawing.Point(12, 102);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(10, 10);
            this.esc.TabIndex = 20;
            this.esc.Text = "button1";
            this.esc.UseVisualStyleBackColor = true;
            this.esc.Visible = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // bettext1
            // 
            this.bettext1.AutoSize = true;
            this.bettext1.Location = new System.Drawing.Point(861, 653);
            this.bettext1.Name = "bettext1";
            this.bettext1.Size = new System.Drawing.Size(0, 13);
            this.bettext1.TabIndex = 21;
            // 
            // bettext2
            // 
            this.bettext2.AutoSize = true;
            this.bettext2.Location = new System.Drawing.Point(535, 653);
            this.bettext2.Name = "bettext2";
            this.bettext2.Size = new System.Drawing.Size(0, 13);
            this.bettext2.TabIndex = 22;
            // 
            // bettext3
            // 
            this.bettext3.AutoSize = true;
            this.bettext3.Location = new System.Drawing.Point(228, 656);
            this.bettext3.Name = "bettext3";
            this.bettext3.Size = new System.Drawing.Size(0, 13);
            this.bettext3.TabIndex = 23;
            // 
            // balancetext
            // 
            this.balancetext.AutoSize = true;
            this.balancetext.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.25F);
            this.balancetext.Location = new System.Drawing.Point(12, 648);
            this.balancetext.Name = "balancetext";
            this.balancetext.Size = new System.Drawing.Size(17, 21);
            this.balancetext.TabIndex = 36;
            this.balancetext.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Balance";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(500, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 60);
            this.button1.TabIndex = 37;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.esc;
            this.ClientSize = new System.Drawing.Size(1121, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.winlosescreen);
            this.Controls.Add(this.balancetext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bettext3);
            this.Controls.Add(this.bettext2);
            this.Controls.Add(this.bettext1);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.player32text);
            this.Controls.Add(this.player31text);
            this.Controls.Add(this.player22text);
            this.Controls.Add(this.player21text);
            this.Controls.Add(this.player12text);
            this.Controls.Add(this.player11text);
            this.Controls.Add(this.nullpicturebox);
            this.Controls.Add(this.player3boom);
            this.Controls.Add(this.player2boom);
            this.Controls.Add(this.player1boom);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player3text);
            this.Controls.Add(this.player2text);
            this.Controls.Add(this.player1text);
            this.Controls.Add(this.dealertext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button split;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Label dealertext;
        private System.Windows.Forms.Label player1text;
        private System.Windows.Forms.Label player2text;
        private System.Windows.Forms.Label player3text;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox player1boom;
        private System.Windows.Forms.PictureBox player2boom;
        private System.Windows.Forms.PictureBox player3boom;
        private System.Windows.Forms.Button btndouble;
        private System.Windows.Forms.Label player11text;
        private System.Windows.Forms.Label player12text;
        private System.Windows.Forms.Label player21text;
        private System.Windows.Forms.Label player22text;
        private System.Windows.Forms.Label player31text;
        private System.Windows.Forms.Label player32text;
        private System.Windows.Forms.PictureBox hand;
        public System.Windows.Forms.PictureBox nullpicturebox;
        private System.Windows.Forms.Button esc;
        private System.Windows.Forms.Label bettext1;
        private System.Windows.Forms.Label bettext2;
        private System.Windows.Forms.Label bettext3;
        private System.Windows.Forms.Label balancetext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label winlosescreen;
        private System.Windows.Forms.Button button1;
    }
}

