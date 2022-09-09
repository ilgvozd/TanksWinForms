using System.Windows.Forms;

namespace BattleCity2022
{
    class IIPanzer : LightPanzer
    {
        public static event Trigger CheckCoords; // событие

        TriggerArgs arg = new TriggerArgs();

		// Конструктор
        public IIPanzer(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls)
        {
            MyPanzer.BackgroundImage = Properties.Resources.IIPanzer;
            MyPanzer.BackgroundImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
        }

		// Метод вызова события
		public void CheckTriggerEvent(object sender, TriggerArgs e)
        {
            CheckCoords?.Invoke(sender, e);
        }

		// Переопределенный метод движения танка
        override public void move(Keys e)
        {
            if (!dead) // Если танк не уничтожен
            {
                int value = rand.Next(0, 4);
                arg.x = x;
                arg.y = y;
                CheckTriggerEvent(this, arg);
                if (arg.S) dir = 0;
                else if (arg.W) dir = 1;
                else if (arg.D) dir = 2;
                else if (arg.A) dir = 3;             
                else if (count >= 30 || wait >= 3)
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