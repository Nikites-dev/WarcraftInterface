using WarcraftInterface.Interface;

namespace WarcraftInterface.Unit
{
    public class Engineer
    {
        public void Reapir(IRepair repair)
        {
            repair.Repair();
        }

        public void Upgrade(IUpgrade upgrade)
        {
            upgrade.Upgrade();
        }
    }
}