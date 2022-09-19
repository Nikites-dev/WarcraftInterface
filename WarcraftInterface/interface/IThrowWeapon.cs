namespace WarcraftInterface.Interface {
    
    public interface IThrowWeapon
    {
        public int ThrowDamage{ get; set; }

        public void Throw();
    }
}