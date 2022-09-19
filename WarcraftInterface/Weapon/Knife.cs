using System;
using WarcraftInterface.Interface;

namespace WarcraftInterface{

internal partial class Program
{
    class Knife : IWeapon, IThrowWeapon, IMeleeAttack
    {
        public int Damage { get; set; }
        public int State { get; set; }
        public int ThrowDamage { get; set; }

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

        public void MeleeAttack()
        {
            Console.WriteLine("Хтык!");
        }
    }

}}