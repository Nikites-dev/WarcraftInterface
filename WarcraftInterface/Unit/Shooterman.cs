using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarcraftInterface.Interface;

namespace WarcraftInterface.Unit
{
    
    public class Shooterman
    {
        List<IWeapon> Weapons { get; set; }

        public Shooterman()
        {
            Weapons = new List<IWeapon>();
        }

        public int Damage { get; set; }

        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowWeapon weapon)
        {
            weapon.Throw();
        }

        public void MeleeAttack(IMeleeAttack meleeAttack)
        {
            meleeAttack.MeleeAttack();
        }

        public void Reload(IReloadWeapon weapon)
        {
            weapon.Reload();
        }
    }
}
