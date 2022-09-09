using System;
using System.Drawing;

namespace BattleCity2022
{
    public class MyEventArgs : EventArgs // Класс для работы с событиями
    {
        public int x,y;
        public bool collis;
        public int dx, dy;
        public int size;
        public Rectangle bounds;
        public bool friendly;
    }
}