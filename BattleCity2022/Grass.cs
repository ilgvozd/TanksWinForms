using System.Windows.Forms;

namespace BattleCity2022
{
    class Grass : Steal // Класс, описывающий препятствие - Куст
    {
        // Конструктор
        public Grass(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls)
        {
            block.BackgroundImage = Properties.Resources.Grass;
            block.BringToFront(); // Помещаем элемент в начало порядка, чтобы танки проходили под кустами
        }
    }
}