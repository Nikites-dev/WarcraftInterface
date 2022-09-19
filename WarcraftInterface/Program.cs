using WarcraftInterface.Interface;
using WarcraftInterface.Unit;

namespace WarcraftInterface{

internal partial class Program
{
    public static void Main(string[] args)
    {
        var makarov = new HandGun(11) { Damage = 23};
        makarov.Fire();
        makarov.AutoShoot();
        makarov.Reload();
        
        var makarovSingle = (IWeapon)makarov;
        makarovSingle.Fire();
        
        var makarovAuto = (IAutoShootGun)makarov;
        makarovAuto.AutoShoot();


        var butterfly = new Knife();
        butterfly.Throw();
        butterfly.Fire();
        butterfly.MeleeAttack();

        var butterflyTrow = (IThrowWeapon) butterfly;
        butterflyTrow.Throw();

        var butterflyMelee = (IMeleeAttack) butterfly;
        butterflyMelee.MeleeAttack();

        Shooterman shooterman = new Shooterman();
        
        shooterman.Fire(makarovSingle);
        shooterman.Throw(butterflyTrow);
        shooterman.Reload(makarovAuto);
    }

}}