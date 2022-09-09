using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
	class Bonus // Класс описывающий бонус
	{
		protected int x, y; // Переменные координат x и y
		public int size, width, height; // Переменные, описывающие размер бонуса
		protected PictureBox recoveryHP; // Переменная типа PictureBox

		// Конструктор
		public Bonus(int x, int y, int size, Control.ControlCollection Controls)
		{
			this.x = x;
			this.y = y;
			this.size = size;
			recoveryHP = new PictureBox();
			
			recoveryHP.Width = size;
			recoveryHP.Height = size;
			recoveryHP.BackgroundImage = Properties.Resources.bonusHeart;
			recoveryHP.BackgroundImageLayout = ImageLayout.Stretch;
			recoveryHP.Location = new System.Drawing.Point(x, y);
			width = size;
			height = size;
			recoveryHP.SendToBack();
			Controls.Add(recoveryHP);
		}

		// Метод получения размера и местоположения блока
		public Rectangle GetBounds()
		{
			return recoveryHP.Bounds;
		}

		// Метод смены местоположения бонуса
		public void Replace(int x, int y)
		{
			recoveryHP.Location = new System.Drawing.Point(x, y);
			this.x = x;
			this.y = y;
		}
	}
}