namespace BattleCity2022
{
	partial class AboutGame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutGame));
			this.BackMenu = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// BackMenu
			// 
			this.BackMenu.AutoSize = true;
			this.BackMenu.Font = new System.Drawing.Font("Impact", 20.25F);
			this.BackMenu.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.BackMenu.Location = new System.Drawing.Point(608, 407);
			this.BackMenu.Name = "BackMenu";
			this.BackMenu.Size = new System.Drawing.Size(180, 34);
			this.BackMenu.TabIndex = 3;
			this.BackMenu.Text = "Назад в меню";
			this.BackMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackMenu_MouseClick);
			this.BackMenu.MouseLeave += new System.EventHandler(this.BackMenu_MouseLeave);
			this.BackMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackMenu_MouseMove);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.Location = new System.Drawing.Point(172, 73);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.ShortcutsEnabled = false;
			this.richTextBox1.Size = new System.Drawing.Size(452, 34);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "Игра с графическим интерфейсом \"Танчики\"";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox2.Location = new System.Drawing.Point(172, 113);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.ShortcutsEnabled = false;
			this.richTextBox2.Size = new System.Drawing.Size(452, 216);
			this.richTextBox2.TabIndex = 5;
			this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
			// 
			// AboutGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkKhaki;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.BackMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AboutGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "О программе";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutGame_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label BackMenu;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}