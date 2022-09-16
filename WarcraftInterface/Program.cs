namespace WarcraftInterface;

internal class Program
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

    interface IWeapon
    {
        public int Damage { get; set; }

        public void Fire();
    }

    interface ISingleShootGun : IReloadWeapon
    {
        public void SingleShoot();
    }

    interface IThrowWeapon
    {
        void Throw();
    }

    interface IAutoShootGun : IReloadWeapon
    {
        public void AutoShoot();
    }

    interface IReloadWeapon
    {
       public int CurrentMagazineSize { get; set; }
       public int MaxMagazineSize { get; set; }
       public void Reload();
    }

    interface Repair
    {
        public int State { get; set; }
        public void Repair();
    }




    class Knife : IWeapon, IThrowWeapon
    {
        public int Damage { get; set; }
        public int State { get; set; }

        public Knife()
        {

        }

        public void Fire()
        {
            Console.WriteLine("Тыщ!");
        }

        public void Throw()
        {
            Console.WriteLine("Хтыщ!");
        }
    }

    class HandGun: IWeapon, IAutoShootGun
    {
        public int Damage { get; set;}
        public int CurrentMagazineSize { get; set;}
        public int MaxMagazineSize { get; set;}
        public int State{ get; set;}

        public HandGun(int magazineSize)
        {
            MaxMagazineSize = magazineSize;
            CurrentMagazineSize = magazineSize;
        }

        public void Repair()
        {
            State += 1;
            Console.WriteLine("пистолет отремонтирован!");
        }

        public void Upgrade()
        {
            Damage += 10;
            Console.WriteLine("пистолет улучшен!");
        }

        public void Fire()
        {
            Console.WriteLine("ту!");
        }

        public void AutoShoot()
        {
            Console.WriteLine("ту! ту! ту! ту!");
        }

        public void Reload()
        {
            Console.WriteLine("пистолет перезаряжен!");
        }
    }

}