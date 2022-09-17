namespace WarcraftInterface;

internal partial class Program
{
    public static void Main(string[] args)
    {
        var makarov = new HandGun(11) { Damage = 23};
        makarov.Fire();
        makarov.AutoShoot();
        makarov.Reload();

        var makarovSingle = (IWeapon)makarov;
        //makarovSingle.Fire();

        var makarovAuto = (IAutoShootGun)makarov;
        // makarovAuto.AutoShoot();


        var butterfly = new Knife();
        butterfly.Throw();
        butterfly.Fire();


    }

}