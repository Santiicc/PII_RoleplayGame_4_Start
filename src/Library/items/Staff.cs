namespace RoleplayGame.Items
{
    public class Staff: IAttackItem, IDefenseItem
    {
        public int AttackPower
        {
            get
            {
                return 100;
            } 
        }

        public int DefensePower
        {
            get
            {
                return 100;
            }
        }
    }
}
