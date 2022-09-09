using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
    class Block // Класс описывающий блоки
    {
		public bool flag = false; // Переменная для определения какая база уничтожена
        protected int x, y; // Переменные координат x и y
        protected int strength = 3; // Переменная здоровья преграды
        public int size, width, height; // Переменные описывающие размер блоков
        protected PictureBox block; // Переменная типа PictureBox

        // Конструктор
        public Block(int x, int y, int size, Control.ControlCollection Controls)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            block = new PictureBox();
            block.Width = size;
            block.Height = size;
            block.BackgroundImage = Properties.Resources.Brick;
            block.BackgroundImageLayout = ImageLayout.None;
            block.Location = new System.Drawing.Point(x, y);
            Controls.Add(block);
            width = size;
            height = size;
        }

        // Метод получения размера и местоположения блока
        public Rectangle GetBounds()
        {
            return block.Bounds;
        }

        // Виртуальный метод уничтожения блока
        virtual public void destroy(Keys side)
        {
            // Если здоровье блока не равно 0
            if (strength != 0)
            {
                // Если блок сверху
                if (side == Keys.W)
                {
                    block.Height -= 10; // Уменьшаем высоту на 10
                    height -= 10;
                }
                else if (side == Keys.S) // Если препятствие снизу от танка
                {
                    y += 10; // переносим препятствие на 10 вниз 
                    block.Height -= 10; // Уменьшаем высоту препятствия на 10
                    height -= 10;
                }
                else if (side == Keys.D) // Если препятствие справа от танка
                {
                    x += 10; // переносим препятствие на 10 вправо 
                    block.Width -= 10; // уменьшаем ширину препятствия на 10
                    width -= 10;
                }
                else if (side == Keys.A) // Если препятствие слева от танка
                {
                    block.Width -= 10; // уменьшаем ширину препятствия на 10
                    width -= 10;
                }
                strength--; // отнимаем одну единицу здоровья у препятствия
                block.Location = new System.Drawing.Point(x, y);
            }
            else // Если здоровье препятствия = 0
            {
               x = -40; y = -40; // До конца уничтожаем препятствие
               block.Location = new System.Drawing.Point(x, y);
            }
        }
    }
}