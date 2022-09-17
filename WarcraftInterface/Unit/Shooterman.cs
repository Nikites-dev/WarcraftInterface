using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftInterface.Unit
{


    public class Shooterman: Unit, IWeapon, IThrowWeapon
    {
        public Shooterman()
        {
            
        }

        public int Damage { get; set; }

        public void Fire()
        {
            Console.WriteLine("fire! fire!");
        }

        public void Throw()
        {
            Console.WriteLine("throw!");
        }
    }
}
