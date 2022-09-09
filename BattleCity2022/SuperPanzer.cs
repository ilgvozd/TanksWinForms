using System.Windows.Forms;

namespace BattleCity2022
{
    class SuperPanzer : IIPanzer // Класс, описывающий супертанк
    {
		// Конструктор
        public SuperPanzer(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls)
        {
            MyPanzer.BackgroundImage = Properties.Resources.SuperPanzer;
            MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            strength = 3; // Мощность танка = 3
        }

		// Переопределенный метод уничтожения танка
        override public void destroy()
        {
			// Если танк не уничтожен и у него осталась последняя жизнь
            if (!dead && strength == 1)
            {
                MyPanzer.BackgroundImage = Properties.Resources.Dead; // Меняем изображение на уничтоженный танк
                dead = true; // переменная смерть = истина
            }
            else
            {
                if (strength == 3) // Если жизнь полная
                    MyPanzer.BackgroundImage = Properties.Resources.FastPanzer; // Танк переходит во вторую стадию, сменив изображение
                if (strength == 2)
                    MyPanzer.BackgroundImage = Properties.Resources.Enemy; // Танк переходит в третью стадию, сменив изображение
				strength--;
            }
            if (direct == direction.left)
                MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
            else if (direct == direction.right)
                MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
            else if (direct == direction.down)
                MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
        }
    }
}