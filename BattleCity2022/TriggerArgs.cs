using System;

namespace BattleCity2022
{
    public class TriggerArgs : EventArgs // Класс, описывающий координаты  "умного" танка, и задает его направление
    {
        public int x;
        public int y;
        public bool A, W, S, D;
    }
}