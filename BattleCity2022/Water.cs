using System.Windows.Forms;

namespace BattleCity2022
{
    class Water : Steal // Класс, описывающий препятствие - вода
    {
        // Конструктор
        public Water(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls)
        {
            block.BackgroundImage = Properties.Resources.Water;
        }
    }
}