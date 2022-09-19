using System;

namespace WarcraftInterface{

internal partial class Program
{
    class HandGun : IWeapon, IAutoShootGun
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
            CurrentMagazineSize -= 1;
            Console.WriteLine("ту!: "  + Convert.ToString(CurrentMagazineSize));
        }

        public void AutoShoot()
        {
            CurrentMagazineSize -= 4;
            Console.WriteLine("ту! ту! ту! ту!"  + Convert.ToString(CurrentMagazineSize));
        }

        public void Reload()
        {
            CurrentMagazineSize = MaxMagazineSize;
            Console.WriteLine(GetType().Name + " перезаряжен!: " + CurrentMagazineSize);
        }
    }

}}