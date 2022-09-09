using System.Windows.Forms;

namespace BattleCity2022
{
    class Steal : Block // Класс, описывающий препятствие - Стальная стена
    {
        // Конструктор
        public Steal(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls) 
        {
            block.BackgroundImage = Properties.Resources.Steal;
        }

        // Переопределенный метода уничтожения препятствия (Он пустой, потому что блок Steal не уничтожается)
		override public void destroy(Keys side)
		{

		}
	}
}