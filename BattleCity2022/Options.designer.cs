namespace BattleCity2022
{
	partial class Options
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.ColorField = new System.Windows.Forms.Label();
			this.BackMenu = new System.Windows.Forms.Label();
			this.leftMap = new System.Windows.Forms.Button();
			this.rightMap = new System.Windows.Forms.Button();
			this.leftTank1Color = new System.Windows.Forms.Button();
			this.rightTank1Color = new System.Windows.Forms.Button();
			this.pictureBoxMap = new System.Windows.Forms.PictureBox();
			this.pictureBoxColorTank1 = new System.Windows.Forms.PictureBox();
			this.LabelColor = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxColorTank2 = new System.Windows.Forms.PictureBox();
			this.rightTank2Color = new System.Windows.Forms.Button();
			this.leftTank2Color = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorTank1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorTank2)).BeginInit();
			this.SuspendLayout();
			// 
			// ColorField
			// 
			this.ColorField.AutoSize = true;
			this.ColorField.Font = new System.Drawing.Font("Impact", 20.25F);
			this.ColorField.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.ColorField.Location = new System.Drawing.Point(434, 79);
			this.ColorField.Name = "ColorField";
			this.ColorField.Size = new System.Drawing.Size(240, 34);
			this.ColorField.TabIndex = 0;
			this.ColorField.Text = "Цвет игрового поля";
			this.ColorField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorField_MouseClick);
			this.ColorField.MouseLeave += new System.EventHandler(this.ColorField_MouseLeave);
			this.ColorField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorField_MouseMove);
			// 
			// BackMenu
			// 
			this.BackMenu.AutoSize = true;
			this.BackMenu.Font = new System.Drawing.Font("Impact", 20.25F);
			this.BackMenu.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.BackMenu.Location = new System.Drawing.Point(13, 408);
			this.BackMenu.Name = "BackMenu";
			this.BackMenu.Size = new System.Drawing.Size(180, 34);
			this.BackMenu.TabIndex = 1;
			this.BackMenu.Text = "Назад в меню";
			this.BackMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackMenu_MouseClick);
			this.BackMenu.MouseLeave += new System.EventHandler(this.BackMenu_MouseLeave);
			this.BackMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackMenu_MouseMove);
			// 
			// leftMap
			// 
			this.leftMap.BackColor = System.Drawing.Color.Transparent;
			this.leftMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftMap.BackgroundImage")));
			this.leftMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.leftMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.leftMap.FlatAppearance.BorderSize = 0;
			this.leftMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leftMap.Location = new System.Drawing.Point(31, 72);
			this.leftMap.Name = "leftMap";
			this.leftMap.Size = new System.Drawing.Size(75, 61);
			this.leftMap.TabIndex = 2;
			this.leftMap.UseVisualStyleBackColor = false;
			this.leftMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leftMap_MouseClick);
			// 
			// rightMap
			// 
			this.rightMap.BackColor = System.Drawing.Color.Transparent;
			this.rightMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightMap.BackgroundImage")));
			this.rightMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rightMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.rightMap.FlatAppearance.BorderSize = 0;
			this.rightMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rightMap.Location = new System.Drawing.Point(290, 72);
			this.rightMap.Name = "rightMap";
			this.rightMap.Size = new System.Drawing.Size(75, 61);
			this.rightMap.TabIndex = 3;
			this.rightMap.UseVisualStyleBackColor = false;
			this.rightMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rightMap_MouseClick);
			// 
			// leftTank1Color
			// 
			this.leftTank1Color.BackColor = System.Drawing.Color.Transparent;
			this.leftTank1Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftTank1Color.BackgroundImage")));
			this.leftTank1Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.leftTank1Color.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.leftTank1Color.FlatAppearance.BorderSize = 0;
			this.leftTank1Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leftTank1Color.Location = new System.Drawing.Point(31, 227);
			this.leftTank1Color.Name = "leftTank1Color";
			this.leftTank1Color.Size = new System.Drawing.Size(75, 61);
			this.leftTank1Color.TabIndex = 4;
			this.leftTank1Color.UseVisualStyleBackColor = false;
			this.leftTank1Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leftTank1Color_MouseClick);
			// 
			// rightTank1Color
			// 
			this.rightTank1Color.BackColor = System.Drawing.Color.Transparent;
			this.rightTank1Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightTank1Color.BackgroundImage")));
			this.rightTank1Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rightTank1Color.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.rightTank1Color.FlatAppearance.BorderSize = 0;
			this.rightTank1Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rightTank1Color.Location = new System.Drawing.Point(290, 227);
			this.rightTank1Color.Name = "rightTank1Color";
			this.rightTank1Color.Size = new System.Drawing.Size(75, 61);
			this.rightTank1Color.TabIndex = 5;
			this.rightTank1Color.UseVisualStyleBackColor = false;
			this.rightTank1Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rightTank1Color_MouseClick);
			// 
			// pictureBoxMap
			// 
			this.pictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxMap.Location = new System.Drawing.Point(112, 60);
			this.pictureBoxMap.Name = "pictureBoxMap";
			this.pictureBoxMap.Size = new System.Drawing.Size(172, 91);
			this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMap.TabIndex = 6;
			this.pictureBoxMap.TabStop = false;
			// 
			// pictureBoxColorTank1
			// 
			this.pictureBoxColorTank1.Location = new System.Drawing.Point(112, 212);
			this.pictureBoxColorTank1.Name = "pictureBoxColorTank1";
			this.pictureBoxColorTank1.Size = new System.Drawing.Size(172, 91);
			this.pictureBoxColorTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxColorTank1.TabIndex = 7;
			this.pictureBoxColorTank1.TabStop = false;
			// 
			// LabelColor
			// 
			this.LabelColor.Location = new System.Drawing.Point(701, 79);
			this.LabelColor.Name = "LabelColor";
			this.LabelColor.Size = new System.Drawing.Size(34, 34);
			this.LabelColor.TabIndex = 8;
			this.LabelColor.Text = "          ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Impact", 20.25F);
			this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label1.Location = new System.Drawing.Point(310, 331);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 34);
			this.label1.TabIndex = 9;
			this.label1.Text = "Подтвердить";
			this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
			this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			// 
			// pictureBoxColorTank2
			// 
			this.pictureBoxColorTank2.Location = new System.Drawing.Point(521, 212);
			this.pictureBoxColorTank2.Name = "pictureBoxColorTank2";
			this.pictureBoxColorTank2.Size = new System.Drawing.Size(172, 91);
			this.pictureBoxColorTank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxColorTank2.TabIndex = 12;
			this.pictureBoxColorTank2.TabStop = false;
			// 
			// rightTank2Color
			// 
			this.rightTank2Color.BackColor = System.Drawing.Color.Transparent;
			this.rightTank2Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightTank2Color.BackgroundImage")));
			this.rightTank2Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rightTank2Color.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.rightTank2Color.FlatAppearance.BorderSize = 0;
			this.rightTank2Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rightTank2Color.Location = new System.Drawing.Point(699, 227);
			this.rightTank2Color.Name = "rightTank2Color";
			this.rightTank2Color.Size = new System.Drawing.Size(75, 61);
			this.rightTank2Color.TabIndex = 11;
			this.rightTank2Color.UseVisualStyleBackColor = false;
			this.rightTank2Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rightTank2Color_MouseClick);
			// 
			// leftTank2Color
			// 
			this.leftTank2Color.BackColor = System.Drawing.Color.Transparent;
			this.leftTank2Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftTank2Color.BackgroundImage")));
			this.leftTank2Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.leftTank2Color.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.leftTank2Color.FlatAppearance.BorderSize = 0;
			this.leftTank2Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leftTank2Color.Location = new System.Drawing.Point(440, 227);
			this.leftTank2Color.Name = "leftTank2Color";
			this.leftTank2Color.Size = new System.Drawing.Size(75, 61);
			this.leftTank2Color.TabIndex = 10;
			this.leftTank2Color.UseVisualStyleBackColor = false;
			this.leftTank2Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leftTank2Color_MouseClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Impact", 20.25F);
			this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label2.Location = new System.Drawing.Point(64, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(263, 34);
			this.label2.TabIndex = 13;
			this.label2.Text = "Выбор игрового поля";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Impact", 20.25F);
			this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label3.Location = new System.Drawing.Point(116, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 34);
			this.label3.TabIndex = 14;
			this.label3.Text = "Цвет танка 1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Impact", 20.25F);
			this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label4.Location = new System.Drawing.Point(531, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 34);
			this.label4.TabIndex = 15;
			this.label4.Text = "Цвет танка 2";
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBoxColorTank2);
			this.Controls.Add(this.rightTank2Color);
			this.Controls.Add(this.leftTank2Color);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LabelColor);
			this.Controls.Add(this.pictureBoxColorTank1);
			this.Controls.Add(this.pictureBoxMap);
			this.Controls.Add(this.rightTank1Color);
			this.Controls.Add(this.leftTank1Color);
			this.Controls.Add(this.rightMap);
			this.Controls.Add(this.leftMap);
			this.Controls.Add(this.BackMenu);
			this.Controls.Add(this.ColorField);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
			this.Load += new System.EventHandler(this.Options_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorTank1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorTank2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label ColorField;
		private System.Windows.Forms.Label BackMenu;
		private System.Windows.Forms.Button leftMap;
		private System.Windows.Forms.Button rightMap;
		private System.Windows.Forms.Button leftTank1Color;
		private System.Windows.Forms.Button rightTank1Color;
		private System.Windows.Forms.PictureBox pictureBoxMap;
		private System.Windows.Forms.PictureBox pictureBoxColorTank1;
		private System.Windows.Forms.Label LabelColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxColorTank2;
		private System.Windows.Forms.Button rightTank2Color;
		private System.Windows.Forms.Button leftTank2Color;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}