namespace BattleCity2022
{
	partial class menu
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
			this.StartGame = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Label();
			this.Single = new System.Windows.Forms.Label();
			this.Coop = new System.Windows.Forms.Label();
			this.Options = new System.Windows.Forms.Label();
			this.helpLabel = new System.Windows.Forms.Label();
			this.AboutGameLAbel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// StartGame
			// 
			this.StartGame.AutoSize = true;
			this.StartGame.BackColor = System.Drawing.Color.White;
			this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.StartGame.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartGame.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.StartGame.Location = new System.Drawing.Point(689, 9);
			this.StartGame.Name = "StartGame";
			this.StartGame.Size = new System.Drawing.Size(223, 48);
			this.StartGame.TabIndex = 0;
			this.StartGame.Text = "Начать игру";
			this.StartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartGame_MouseClick);
			this.StartGame.MouseLeave += new System.EventHandler(this.StartGame_MouseLeave);
			this.StartGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartGame_MouseMove);
			// 
			// Exit
			// 
			this.Exit.AutoSize = true;
			this.Exit.BackColor = System.Drawing.Color.Transparent;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Exit.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Exit.Location = new System.Drawing.Point(819, 592);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(93, 34);
			this.Exit.TabIndex = 1;
			this.Exit.Text = "Выход";
			this.Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseClick);
			this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
			this.Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseMove);
			// 
			// Single
			// 
			this.Single.AutoSize = true;
			this.Single.BackColor = System.Drawing.Color.White;
			this.Single.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Single.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Single.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Single.ForeColor = System.Drawing.Color.Orange;
			this.Single.Location = new System.Drawing.Point(732, 66);
			this.Single.Name = "Single";
			this.Single.Size = new System.Drawing.Size(139, 48);
			this.Single.TabIndex = 2;
			this.Single.Text = "1 игрок";
			this.Single.Visible = false;
			this.Single.Click += new System.EventHandler(this.Single_Click);
			this.Single.MouseLeave += new System.EventHandler(this.Single_MouseLeave);
			this.Single.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Single_MouseMove);
			// 
			// Coop
			// 
			this.Coop.AutoSize = true;
			this.Coop.BackColor = System.Drawing.Color.White;
			this.Coop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Coop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Coop.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Coop.ForeColor = System.Drawing.Color.DodgerBlue;
			this.Coop.Location = new System.Drawing.Point(720, 119);
			this.Coop.Name = "Coop";
			this.Coop.Size = new System.Drawing.Size(164, 48);
			this.Coop.TabIndex = 3;
			this.Coop.Text = "2 игрока";
			this.Coop.Visible = false;
			this.Coop.Click += new System.EventHandler(this.Coop_Click);
			this.Coop.MouseLeave += new System.EventHandler(this.Coop_MouseLeave);
			this.Coop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Coop_MouseMove);
			// 
			// Options
			// 
			this.Options.AutoSize = true;
			this.Options.BackColor = System.Drawing.Color.White;
			this.Options.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Options.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Options.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Options.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Options.Location = new System.Drawing.Point(12, 592);
			this.Options.Name = "Options";
			this.Options.Size = new System.Drawing.Size(141, 34);
			this.Options.TabIndex = 4;
			this.Options.Text = "Настройки";
			this.Options.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Options_MouseClick);
			this.Options.MouseLeave += new System.EventHandler(this.Options_MouseLeave);
			this.Options.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Options_MouseMove);
			// 
			// helpLabel
			// 
			this.helpLabel.AutoSize = true;
			this.helpLabel.BackColor = System.Drawing.Color.White;
			this.helpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.helpLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.helpLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.helpLabel.Location = new System.Drawing.Point(12, 9);
			this.helpLabel.Name = "helpLabel";
			this.helpLabel.Size = new System.Drawing.Size(153, 34);
			this.helpLabel.TabIndex = 5;
			this.helpLabel.Text = "Инструкция";
			this.helpLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.helpLabel_MouseClick);
			this.helpLabel.MouseLeave += new System.EventHandler(this.helpLabel_MouseLeave);
			this.helpLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.helpLabel_MouseMove);
			// 
			// AboutGameLAbel
			// 
			this.AboutGameLAbel.AutoSize = true;
			this.AboutGameLAbel.BackColor = System.Drawing.Color.White;
			this.AboutGameLAbel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AboutGameLAbel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AboutGameLAbel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AboutGameLAbel.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.AboutGameLAbel.Location = new System.Drawing.Point(12, 55);
			this.AboutGameLAbel.Name = "AboutGameLAbel";
			this.AboutGameLAbel.Size = new System.Drawing.Size(114, 34);
			this.AboutGameLAbel.TabIndex = 6;
			this.AboutGameLAbel.Text = "Справка";
			this.AboutGameLAbel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutGameLAbel_MouseClick);
			this.AboutGameLAbel.MouseLeave += new System.EventHandler(this.AboutGameLAbel_MouseLeave);
			this.AboutGameLAbel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AboutGameLAbel_MouseMove);
			// 
			// menu
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(924, 635);
			this.Controls.Add(this.AboutGameLAbel);
			this.Controls.Add(this.helpLabel);
			this.Controls.Add(this.Options);
			this.Controls.Add(this.Coop);
			this.Controls.Add(this.Single);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.StartGame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BattleVillage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label StartGame;
		private System.Windows.Forms.Label Exit;
		private System.Windows.Forms.Label Single;
		private System.Windows.Forms.Label Coop;
		private System.Windows.Forms.Label Options;
		private System.Windows.Forms.Label helpLabel;
		private System.Windows.Forms.Label AboutGameLAbel;
	}
}

