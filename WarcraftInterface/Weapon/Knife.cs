namespace WarcraftInterface;

internal partial class Program
{
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

}