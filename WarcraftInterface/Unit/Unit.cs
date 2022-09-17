using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftInterface.Unit
{
    public class Unit
    {
        public int Name { get; set; }
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
