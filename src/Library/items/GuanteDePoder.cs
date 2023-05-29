namespace RoleplayGame.Items
{
    public class GuanteDePoder : IAttackItem, IDefenseItem
    {
        private int gems = 0;
        public int AttackPower
        {
            get { return gems * 50; }
        }

        public int DefensePower
        {
            get { return gems * 50; }
        }
        public void addGem(Gem gem){
            this.gems++;
        }
        public override string ToString()
        {
            return "Guante de poder";
        }
        
    }
}
