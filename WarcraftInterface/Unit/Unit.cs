using System;

namespace WarcraftInterface.Unit
{
    public class Unit
    {
        public String Name { get; set; }
        public int Level { get; set; }
        public int Cost { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public bool isDestroyed { get; set; }

        public Unit()
        {

        }
    }
}
