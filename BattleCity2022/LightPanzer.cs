using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
    class LightPanzer : Panzer // Класс, описывающий LightPanzer
    {
        protected int count = 0, dir = 0, wait = 0;
        protected Random rand = new Random(DateTime.Now.Millisecond);

		// Конструктор
        public LightPanzer(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls)
        {
            MyPanzer.BackgroundImage = Properties.Resources.Enemy;
            MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            direct = direction.down;
        }

		// Метод движения танка LightPanzer
        protected void moving(ref int value, ref int dir)
        {
            MyEventArgs arg = new MyEventArgs();

            if (dir == 0) // W
            {
                arg.x = x;
                arg.y = y;
                arg.dx = x;
                arg.dy = y - 5;
                arg.size = size;
                Rectangle bounds = new Rectangle(MyPanzer.Bounds.Left, MyPanzer.Bounds.Top - 2, MyPanzer.Bounds.Width, MyPanzer.Bounds.Height - 2);
                arg.bounds = bounds;
                CheckEvent(this, arg);
                if (!arg.collis)
                {
                    y -= 5;
                    MyPanzer.Top -= 5;
                }
                else wait++;
                if (direct == direction.left)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                else if (direct == direction.down)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                else if (direct == direction.right)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                MyPanzer.Refresh();
                direct = direction.up;
                count++;
            }
            if (dir == 1) // S
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
                else wait++;
                if (direct == direction.left)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                else if (direct == direction.up)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                else if (direct == direction.right)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                MyPanzer.Refresh();
                direct = direction.down;
                count++;
            }
            if (dir == 2) // A
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
                else wait++;
                if (direct == direction.right)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                else if (direct == direction.up)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                else if (direct == direction.down)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                MyPanzer.Refresh();
                direct = direction.left;
                count++;
            }
            if (dir == 3) // D
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
                else wait++;
                if (direct == direction.left)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                else if (direct == direction.up)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                else if (direct == direction.down)
                    MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                MyPanzer.Refresh();
                direct = direction.right;
                count++;
            }
        }
		
		// Переопределенный метод передвижения танка
        override public void move(Keys e)
        {
            MyEventArgs arg = new MyEventArgs();

            if (!dead) // Если танк не уничтожен
            {
                int value = rand.Next(0, 4); // Случайным образом генерируется цифра от 1 до 4, которая означает направление танка

                if (count >= 30 || wait >= 3)
                {
                    dir = value;
                    count = 0;
                    wait = 0;
                }
                moving(ref value, ref dir);
            }
        }
    }
}
