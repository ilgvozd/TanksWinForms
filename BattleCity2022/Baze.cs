using System.Windows.Forms;

namespace BattleCity2022
{
    class Baze : Block // Класс, описывающий препятствие - База
    {
        // Конструктор
        public Baze(int x, int y, int size, Control.ControlCollection Controls) : base(x, y, size, Controls)
        {
            block.BackgroundImage = Properties.Resources.baze;
            block.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}