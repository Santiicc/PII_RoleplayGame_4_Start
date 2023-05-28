namespace RoleplayGame.Items
{
    public class ShieldAxe : IAttackItem, IDefenseItem
    {
        private Axe axe;
        private Shield shield;

        public int AttackPower
        {
            get { return axe.AttackPower; }
        }

        public int DefensePower
        {
            get { return shield.DefensePower; }
        }

        public ShieldAxe()
        {
            axe = new Axe();
            shield = new Shield();
        }
    }
}
