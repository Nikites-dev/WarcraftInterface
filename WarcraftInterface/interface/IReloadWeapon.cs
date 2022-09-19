namespace WarcraftInterface {
    public interface IReloadWeapon
    {
        public int CurrentMagazineSize { get; set; }
        public int MaxMagazineSize { get; set; }
        public void Reload();
    }
}