namespace BattleCity2022
{
	partial class Field
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.Frags = new System.Windows.Forms.Label();
			this.Win = new System.Windows.Forms.Label();
			this.Lose = new System.Windows.Forms.Label();
			this.Pause = new System.Windows.Forms.Label();
			this.HP = new System.Windows.Forms.Label();
			this.Enemy_Respawn = new System.Windows.Forms.Timer(this.components);
			this.time = new System.Windows.Forms.Timer(this.components);
			this.Ctime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Bullets = new System.Windows.Forms.Timer(this.components);
			this.HP_2 = new System.Windows.Forms.Label();
			this.Respawn_bonuses = new System.Windows.Forms.Timer(this.components);
			this.WinPlayer1 = new System.Windows.Forms.Label();
			this.WinPlayer2 = new System.Windows.Forms.Label();
			this.PrintTime = new System.Windows.Forms.Label();
			this.HP_2_Im = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.heart = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.HP_2_Im)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 30;
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// Frags
			// 
			this.Frags.AutoSize = true;
			this.Frags.BackColor = System.Drawing.Color.Transparent;
			this.Frags.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Frags.ForeColor = System.Drawing.Color.LimeGreen;
			this.Frags.Location = new System.Drawing.Point(1004, 458);
			this.Frags.Name = "Frags";
			this.Frags.Size = new System.Drawing.Size(43, 34);
			this.Frags.TabIndex = 0;
			this.Frags.Text = "20";
			this.Frags.Visible = false;
			// 
			// Win
			// 
			this.Win.AutoSize = true;
			this.Win.BackColor = System.Drawing.Color.Transparent;
			this.Win.Font = new System.Drawing.Font("Impact", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Win.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.Win.Location = new System.Drawing.Point(215, 182);
			this.Win.Name = "Win";
			this.Win.Size = new System.Drawing.Size(498, 161);
			this.Win.TabIndex = 1;
			this.Win.Text = "ПОБЕДА";
			this.Win.Visible = false;
			// 
			// Lose
			// 
			this.Lose.AutoSize = true;
			this.Lose.BackColor = System.Drawing.Color.Transparent;
			this.Lose.Font = new System.Drawing.Font("Impact", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Lose.ForeColor = System.Drawing.Color.OrangeRed;
			this.Lose.Location = new System.Drawing.Point(171, 200);
			this.Lose.Name = "Lose";
			this.Lose.Size = new System.Drawing.Size(637, 145);
			this.Lose.TabIndex = 2;
			this.Lose.Text = "ПОРАЖЕНИЕ";
			this.Lose.Visible = false;
			// 
			// Pause
			// 
			this.Pause.AutoSize = true;
			this.Pause.BackColor = System.Drawing.Color.Transparent;
			this.Pause.Font = new System.Drawing.Font("Impact", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Pause.ForeColor = System.Drawing.Color.Yellow;
			this.Pause.Location = new System.Drawing.Point(264, 200);
			this.Pause.Name = "Pause";
			this.Pause.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Pause.Size = new System.Drawing.Size(409, 161);
			this.Pause.TabIndex = 3;
			this.Pause.Text = "ПАУЗА";
			this.Pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Pause.Visible = false;
			// 
			// HP
			// 
			this.HP.AutoSize = true;
			this.HP.BackColor = System.Drawing.Color.Transparent;
			this.HP.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HP.ForeColor = System.Drawing.Color.Crimson;
			this.HP.Location = new System.Drawing.Point(993, 62);
			this.HP.Name = "HP";
			this.HP.Size = new System.Drawing.Size(29, 34);
			this.HP.TabIndex = 4;
			this.HP.Text = "3";
			// 
			// Enemy_Respawn
			// 
			this.Enemy_Respawn.Interval = 2000;
			this.Enemy_Respawn.Tick += new System.EventHandler(this.Enemy_Respawn_Tick);
			// 
			// time
			// 
			this.time.Interval = 1000;
			this.time.Tick += new System.EventHandler(this.Time_Tick);
			// 
			// Ctime
			// 
			this.Ctime.AutoSize = true;
			this.Ctime.BackColor = System.Drawing.Color.Transparent;
			this.Ctime.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Ctime.ForeColor = System.Drawing.Color.DodgerBlue;
			this.Ctime.Location = new System.Drawing.Point(982, 18);
			this.Ctime.Name = "Ctime";
			this.Ctime.Size = new System.Drawing.Size(62, 34);
			this.Ctime.TabIndex = 7;
			this.Ctime.Text = "0:00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(981, 226);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 34);
			this.label1.TabIndex = 12;
			this.label1.Text = "P";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(928, 280);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 48);
			this.label2.TabIndex = 13;
			this.label2.Text = "W/A/S/D";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.LightGray;
			this.label3.Location = new System.Drawing.Point(943, 263);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "Перемещение";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.LightGray;
			this.label4.Location = new System.Drawing.Point(971, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 19);
			this.label4.TabIndex = 15;
			this.label4.Text = "Пауза";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.LightGray;
			this.label5.Location = new System.Drawing.Point(960, 326);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 19);
			this.label5.TabIndex = 16;
			this.label5.Text = "Стрелять";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.Lime;
			this.label6.Location = new System.Drawing.Point(953, 347);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 34);
			this.label6.TabIndex = 17;
			this.label6.Text = "SPACE";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.LightGray;
			this.label7.Location = new System.Drawing.Point(964, 380);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 19);
			this.label7.TabIndex = 22;
			this.label7.Text = "Рестарт";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.Lime;
			this.label8.Location = new System.Drawing.Point(980, 399);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 34);
			this.label8.TabIndex = 23;
			this.label8.Text = "R";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Bullets
			// 
			this.Bullets.Interval = 15;
			this.Bullets.Tick += new System.EventHandler(this.Bullets_Tick);
			// 
			// HP_2
			// 
			this.HP_2.AutoSize = true;
			this.HP_2.BackColor = System.Drawing.Color.Transparent;
			this.HP_2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HP_2.ForeColor = System.Drawing.Color.Orchid;
			this.HP_2.Location = new System.Drawing.Point(993, 98);
			this.HP_2.Name = "HP_2";
			this.HP_2.Size = new System.Drawing.Size(29, 34);
			this.HP_2.TabIndex = 24;
			this.HP_2.Text = "3";
			this.HP_2.Visible = false;
			// 
			// Respawn_bonuses
			// 
			this.Respawn_bonuses.Interval = 1000;
			this.Respawn_bonuses.Tick += new System.EventHandler(this.Respawn_bonuses_Tick);
			// 
			// WinPlayer1
			// 
			this.WinPlayer1.AutoSize = true;
			this.WinPlayer1.BackColor = System.Drawing.Color.Transparent;
			this.WinPlayer1.Font = new System.Drawing.Font("Impact", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WinPlayer1.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.WinPlayer1.Location = new System.Drawing.Point(12, 204);
			this.WinPlayer1.Name = "WinPlayer1";
			this.WinPlayer1.Size = new System.Drawing.Size(898, 145);
			this.WinPlayer1.TabIndex = 26;
			this.WinPlayer1.Text = "ПОБЕДА - ИГРОК 1";
			this.WinPlayer1.Visible = false;
			// 
			// WinPlayer2
			// 
			this.WinPlayer2.AutoSize = true;
			this.WinPlayer2.BackColor = System.Drawing.Color.Transparent;
			this.WinPlayer2.Font = new System.Drawing.Font("Impact", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WinPlayer2.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.WinPlayer2.Location = new System.Drawing.Point(10, 195);
			this.WinPlayer2.Name = "WinPlayer2";
			this.WinPlayer2.Size = new System.Drawing.Size(912, 145);
			this.WinPlayer2.TabIndex = 27;
			this.WinPlayer2.Text = "ПОБЕДА - ИГРОК 2";
			this.WinPlayer2.Visible = false;
			// 
			// PrintTime
			// 
			this.PrintTime.AutoSize = true;
			this.PrintTime.BackColor = System.Drawing.Color.Transparent;
			this.PrintTime.Font = new System.Drawing.Font("Impact", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PrintTime.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.PrintTime.Location = new System.Drawing.Point(217, 351);
			this.PrintTime.Name = "PrintTime";
			this.PrintTime.Size = new System.Drawing.Size(395, 82);
			this.PrintTime.TabIndex = 28;
			this.PrintTime.Text = "Время игры:";
			this.PrintTime.Visible = false;
			// 
			// HP_2_Im
			// 
			this.HP_2_Im.BackColor = System.Drawing.Color.Transparent;
			this.HP_2_Im.BackgroundImage = global::BattleCity2022.Properties.Resources.HP_2;
			this.HP_2_Im.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.HP_2_Im.Location = new System.Drawing.Point(939, 94);
			this.HP_2_Im.Name = "HP_2_Im";
			this.HP_2_Im.Size = new System.Drawing.Size(46, 38);
			this.HP_2_Im.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.HP_2_Im.TabIndex = 25;
			this.HP_2_Im.TabStop = false;
			this.HP_2_Im.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.BackgroundImage = global::BattleCity2022.Properties.Resources.Controls;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(959, 142);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(70, 69);
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::BattleCity2022.Properties.Resources.Time;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(940, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 40);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::BattleCity2022.Properties.Resources.Frags;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = global::BattleCity2022.Properties.Resources.Frags;
			this.pictureBox1.Location = new System.Drawing.Point(935, 456);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(62, 38);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// heart
			// 
			this.heart.BackColor = System.Drawing.Color.Transparent;
			this.heart.BackgroundImage = global::BattleCity2022.Properties.Resources.HP;
			this.heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.heart.Location = new System.Drawing.Point(939, 58);
			this.heart.Name = "heart";
			this.heart.Size = new System.Drawing.Size(46, 38);
			this.heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.heart.TabIndex = 5;
			this.heart.TabStop = false;
			// 
			// Field
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1062, 653);
			this.Controls.Add(this.PrintTime);
			this.Controls.Add(this.WinPlayer2);
			this.Controls.Add(this.WinPlayer1);
			this.Controls.Add(this.HP_2_Im);
			this.Controls.Add(this.HP_2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Ctime);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.heart);
			this.Controls.Add(this.HP);
			this.Controls.Add(this.Frags);
			this.Controls.Add(this.Win);
			this.Controls.Add(this.Pause);
			this.Controls.Add(this.Lose);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Field";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BattleCity";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Field_FormClosed);
			this.Load += new System.EventHandler(this.Field_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Field_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Field_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Field_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.HP_2_Im)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label Frags;
		private System.Windows.Forms.Label Win;
		public System.Windows.Forms.Label Lose;
		public System.Windows.Forms.Label Pause;
		private System.Windows.Forms.Label HP;
		private System.Windows.Forms.PictureBox heart;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer Enemy_Respawn;
		private System.Windows.Forms.Timer time;
		private System.Windows.Forms.Label Ctime;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Timer Bullets;
		private System.Windows.Forms.PictureBox HP_2_Im;
		private System.Windows.Forms.Label HP_2;
		private System.Windows.Forms.Timer Respawn_bonuses;
		private System.Windows.Forms.Label WinPlayer1;
		private System.Windows.Forms.Label WinPlayer2;
		private System.Windows.Forms.Label PrintTime;
	}
}