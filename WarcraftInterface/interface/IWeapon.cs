namespace WarcraftInterface{
    public interface IWeapon
    {
        public int Damage { get; set; }

        public void Fire();
    }
}