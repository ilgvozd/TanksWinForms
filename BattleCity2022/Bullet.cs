using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
    class Bullet
    {
        private int x, y, size; // Переменные координат x и y, size - размер снаряда
        private direction direct; // Поле direct перечесления direction
        public bool go = false, may = false, friendly = false; // Логические переменные

        private PictureBox shot; // Переменная типа PictureBox

        public static event BulletEvent CheckCollis; // событие

        // Конструктор
        public Bullet(int x, int y, int size, direction direct, bool side)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.direct = direct;
            friendly = side;
        }

		// Метод получения размера и местоположения снаряда
		public Rectangle GetBounds()
        {
            Rectangle bounds = new Rectangle(shot.Bounds.Left - 20, shot.Bounds.Top - 20, shot.Bounds.Width + 16, shot.Bounds.Height + 16);
            return bounds;
        }

		// Метод вызова события
        public void CheckEvent(object sender, MyEventArgs e)
        {
            CheckCollis?.Invoke(sender, e);
        }

		// Метод изображения снаряда при выстреле
        public void show(Control.ControlCollection Controls)
        {
            shot = new PictureBox();
            shot.Width = size;
            shot.Height = size;
            shot.BackgroundImage = Properties.Resources.Bullet;
            shot.BackgroundImageLayout = ImageLayout.Stretch;
            shot.BackColor = Color.Black;
            Controls.Add(shot);
            shot.Show();
            shot.BringToFront();
            if (direct == direction.left || direct == direction.right)
                y += 18;
            shot.Location = new System.Drawing.Point(x, y);
            go = true;

        }

		// Метод движения снаряда
		public void move()
        {
            MyEventArgs arg = new MyEventArgs();

            if (direct == direction.up) // Если направление наверх
            {
                arg.x = x;
                arg.y = y;
                arg.dx = x;
                arg.dy = y - 10;
                arg.size = size;
                Rectangle bounds = new Rectangle(shot.Bounds.Left, shot.Bounds.Top - 5, shot.Bounds.Width, shot.Bounds.Height - 5);
                arg.bounds = bounds;
                arg.friendly = friendly;
                CheckEvent(this, arg);
                if(!arg.collis)
                {
                    y -= 10;
                    shot.Top -= 10;
                }
                else
                {
                    hide();
                }
            }
            else if (direct == direction.left) // Если направление налево
            {
                arg.x = x;
                arg.y = y;
                arg.dx = x - 10;
                arg.dy = y;
                arg.size = size;
                Rectangle bounds = new Rectangle(shot.Bounds.Left-5, shot.Bounds.Top, shot.Bounds.Width-5, shot.Bounds.Height);
                arg.bounds = bounds;
                arg.friendly = friendly;
                CheckEvent(this, arg);
                if(!arg.collis)
                {
                    x -= 10;
                    shot.Left -= 10;
                }
                else
                {
                    hide();
                }
            }
            else if (direct == direction.right) // Если направление направо
			{
                arg.x = x;
                arg.y = y;
                arg.dx = x + 10;
                arg.dy = y;
                arg.size = size;
                Rectangle bounds = new Rectangle(shot.Bounds.Left + 5, shot.Bounds.Top, shot.Bounds.Width + 5, shot.Bounds.Height);
                arg.bounds = bounds;
                arg.friendly = friendly;
                CheckEvent(this, arg);
                if(!arg.collis)
                {
                    x += 10;
                    shot.Left += 10;
                }
                else
                {
                    hide();
                }
            }
            else if (direct == direction.down) // Если направление вниз
			{
                arg.x = x;
                arg.y = y;
                arg.dx = x;
                arg.dy = y + 10;
                arg.size = size;
                Rectangle bounds = new Rectangle(shot.Bounds.Left, shot.Bounds.Top + 5, shot.Bounds.Width, shot.Bounds.Height + 5);
                arg.bounds = bounds;
                arg.friendly = friendly;
                CheckEvent(this, arg);
                if(!arg.collis)
                {
                    y += 10;
                    shot.Top += 10;
                }
                else
                {
                    hide();
                }
            }
        }

		// Метод исчезновения снаряда
        public void hide()
        {
            shot.Hide();
            x = 1000;
            shot.Left += 2000;
            y = 1000;
            shot.Top += 2000;
            go = false;
        }
    }
}