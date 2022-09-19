namespace WarcraftInterface
{
    public interface IRepair
    {
        public int State { get; set; }
        public void Repair();
    }
}