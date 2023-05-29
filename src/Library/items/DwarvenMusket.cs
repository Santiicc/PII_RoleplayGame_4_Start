namespace RoleplayGame.Items
{
     public class DwarvenMusket : IAttackItem
    {
        
        public int AttackPower 
        {
            get
            {
                return 75;
            } 
        }
        
        public override string ToString()
        {
            return "Dwarven Musket";
        }
    }
}
