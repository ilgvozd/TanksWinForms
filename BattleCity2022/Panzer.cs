using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
    class Panzer // Класс, описывающий танки
    {
        protected int x, y; // Переменные координат x и y
		public int size; // Переменная описывающая размер танка
		public int HP = 3, strength = 1; // Переменные здоровья танка
		public bool dead = false; // Логическая переменная dead - смерть
        protected direction direct; // Поле direct перечесления direction
		protected PictureBox MyPanzer; // Переменная типа PictureBox
		protected bool may = false; // Логическая переменная may - мочь

		public static event PanzerEvent CheckCollis; // событие

		// Конструктор
        public Panzer(int x, int y, int size, Control.ControlCollection Controls)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            MyPanzer = new PictureBox();

			// Присваивание цвета танка, выбранного в настройках
			if (Properties.Settings.Default.ColorPlayer1 == "MyTank.png")
				MyPanzer.BackgroundImage = Properties.Resources.MyTank;
			else if (Properties.Settings.Default.ColorPlayer1 == "SecondPlayer.png")
				MyPanzer.BackgroundImage = Properties.Resources.SecondPlayer;
            else if (Properties.Settings.Default.ColorPlayer1 == "blueTank.png")
                MyPanzer.BackgroundImage = Properties.Resources.blueTank;
			else if (Properties.Settings.Default.ColorPlayer1 == "brown.png")
				MyPanzer.BackgroundImage = Properties.Resources.brown;
			else if (Properties.Settings.Default.ColorPlayer1 == "fioletoviy.png")
				MyPanzer.BackgroundImage = Properties.Resources.fioletoviy;
			else if (Properties.Settings.Default.ColorPlayer1 == "green.png")
				MyPanzer.BackgroundImage = Properties.Resources.green;
            else
                MyPanzer.BackgroundImage = Properties.Resources.MyTank;

            MyPanzer.BackgroundImageLayout = ImageLayout.Stretch;
            MyPanzer.BackColor = Color.Transparent;
            MyPanzer.Width = size;
            MyPanzer.Height = size;
            MyPanzer.Location = new System.Drawing.Point(x, y);
            Controls.Add(MyPanzer);
        }

		// Метод присваивания цвета танку второго игрока
        public void SecondPlayer()
        {
			if (Properties.Settings.Default.ColorPlayer2 == "SecondPlayer.png")
				MyPanzer.BackgroundImage = Properties.Resources.SecondPlayer;
            else if (Properties.Settings.Default.ColorPlayer2 == "MyTank.png")
                MyPanzer.BackgroundImage = Properties.Resources.MyTank;
            else if (Properties.Settings.Default.ColorPlayer2 == "blueTank.png")
                MyPanzer.BackgroundImage = Properties.Resources.blueTank;
			else if (Properties.Settings.Default.ColorPlayer2 == "brown.png")
				MyPanzer.BackgroundImage = Properties.Resources.brown;
			else if (Properties.Settings.Default.ColorPlayer2 == "fioletoviy.png")
				MyPanzer.BackgroundImage = Properties.Resources.fioletoviy;
			else if (Properties.Settings.Default.ColorPlayer2 == "green.png")
				MyPanzer.BackgroundImage = Properties.Resources.green;
            else
                MyPanzer.BackgroundImage = Properties.Resources.SecondPlayer;
		}

		// Метод вовращения координаты x
        public int GetX()
        {
            return x;
        }

		// Метод вовращения координаты y
		public int GetY()
        {
            return y;
        }

		// Метод получения размера и местоположения танка
		public Rectangle GetBounds()
        {
            return MyPanzer.Bounds;
        }

		// Метод вызова события
		public void CheckEvent(object sender, MyEventArgs e)
        {     
                CheckCollis?.Invoke(sender, e);
        }

		// Виртуальный метод движения танка
        virtual public void move(Keys e)
        {
            if (!dead) // Если танк не уничтожен
            {
                MyEventArgs arg = new MyEventArgs();

                if (e == Keys.W) // Если нажата клавиша W
                {
                    arg.x = x;
                    arg.y = y;
                    arg.dx = x;
                    arg.dy = y - 5;
                    arg.size = size;
                    Rectangle bounds = new Rectangle(MyPanzer.Bounds.Left, MyPanzer.Bounds.Top - 2, MyPanzer.Bounds.Width, MyPanzer.Bounds.Height - 2);
                    arg.bounds = bounds;
                    CheckEvent(this, arg);
                    if(!arg.collis)
                    {
                        y -= 5;
                        MyPanzer.Top -= 5;
                    }

                    if (direct == direction.left) // Если направление было влево
                        MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone); // Переворачиваем изображение на 90 градусов
                    else if (direct == direction.down) // Если направление было вниз
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone); // Переворачиваем изображение на 180 градусов
					else if (direct == direction.right) // Если направление было вправо
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone); // Переворачиваем изображение на 270 градусов
					MyPanzer.Refresh();
                    direct = direction.up; // Присваивание к переменной направление - направление вверх
                }
                if (e == Keys.S) // Если нажата клавиша S
				{
                    arg.x = x;
                    arg.y = y;
                    arg.dx = x;
                    arg.dy = y + 5;
                    arg.size = size;
                    Rectangle bounds = new Rectangle(MyPanzer.Bounds.Left, MyPanzer.Bounds.Top + 2, MyPanzer.Bounds.Width, MyPanzer.Bounds.Height + 2);
                    arg.bounds = bounds;
                    CheckEvent(this, arg);
                    if (!arg.collis)
                    {
                        y += 5;
                        MyPanzer.Top += 5;
                    }
                    if (direct == direction.left) // Если направление было влево
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone); // Переворачиваем изображение на 270 градусов
					else if (direct == direction.up) // Если направление было вверх
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone); // Переворачиваем изображение на 180 градусов
					else if (direct == direction.right) // Если направление было вправо
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone); // Переворачиваем изображение на 90 градусов
					MyPanzer.Refresh();
                    direct = direction.down; // Присваивание к переменной направление - направление вниз
				}
                if (e == Keys.A) // Если нажата клавиша A
				{
                    arg.x = x;
                    arg.y = y;
                    arg.dx = x - 5;
                    arg.dy = y;
                    arg.size = size;
                    Rectangle bounds = new Rectangle(MyPanzer.Bounds.Left - 2, MyPanzer.Bounds.Top, MyPanzer.Bounds.Width - 2, MyPanzer.Bounds.Height);
                    arg.bounds = bounds;
                    CheckEvent(this, arg);
                    if (!arg.collis)
                    {
                        x -= 5;
                        MyPanzer.Left -= 5;
                    }
                    if (direct == direction.right) // Если направление было вправо
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone); // Переворачиваем изображение на 180 градусов
					else if (direct == direction.up) // Если направление было вверх
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone); // Переворачиваем изображение на 270 градусов
					else if (direct == direction.down) // Если направление было вниз
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone); // Переворачиваем изображение на 90 градусов
					MyPanzer.Refresh();
                    direct = direction.left; // Присваивание к переменной направление - направление влево
				}
                if (e == Keys.D) // Если нажата клавиша D
				{
                    arg.x = x;
                    arg.y = y;
                    arg.dx = x + 5;
                    arg.dy = y;
                    arg.size = size;
                    Rectangle bounds = new Rectangle(MyPanzer.Bounds.Left + 2, MyPanzer.Bounds.Top, MyPanzer.Bounds.Width + 2, MyPanzer.Bounds.Height);
                    arg.bounds = bounds;
                    CheckEvent(this, arg);
                    if (!arg.collis)
                    {
                        x += 5;
                        MyPanzer.Left += 5;
                    }
                    if (direct == direction.left) // Если направление было влево
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone); // Переворачиваем изображение на 180 градусов
					else if (direct == direction.up) // Если направление было вверх
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone); // Переворачиваем изображение на 90 градусов
					else if (direct == direction.down) // Если направление было вниз
						MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone); // Переворачиваем изображение на 270 градусов
					MyPanzer.Refresh();
                    direct = direction.right; // Присваивание к переменной направление - направление вправо
				}
            }
        }

		// Виртуальный метод уничтожения танка
        virtual public void destroy()
        {
            if (!dead)
            {
                MyPanzer.BackgroundImage = Properties.Resources.Dead; // Меняем изображение танка на картинку уничтоженнного танка
                if (direct == direction.left) // Если направление было влево
					MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone); // Переворачиваем изображение на 270 градусов
				else if (direct == direction.right) // Если направление было вправо
					MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone); // Переворачиваем изображение на 90 градусов
				else if (direct == direction.down) // Если направление было вниз
					MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone); // Переворачиваем изображение на 180 градусов
				dead = true; // Переменная смерть = истина
            }
        }

		// Метод смены положения танка
        public void Replace(int x, int y)
        {
            MyPanzer.Location = new System.Drawing.Point(x, y);
            this.x = x;
            this.y = y;
        }

		// Метод выстрела танка
		public Bullet shoot(bool friendly)
        {
            Bullet shot = new Bullet(1000, 1000, 0, direct, friendly);
            if (!dead) // Если танк не уничтожен
            {
                if (direct == direction.down)
                    shot = new Bullet(x + size / 2 - 2, y + size + 3, 6, direct, friendly);
                else if (direct == direction.up)
                    shot = new Bullet(x + size / 2 - 2, y-5, 6, direct, friendly);
                else if (direct == direction.right)
                    shot = new Bullet(x + size+3, y, 6, direct, friendly);
                else if (direct == direction.left)
                    shot = new Bullet(x-5, y, 6, direct, friendly);
            }
            return shot;
        }

    }
}