namespace RoleplayGame.Items
{
    public class MusketeerKit : IAttackItem, IDefenseItem
    {
        private DwarvenMusket musket;
        private Helmet helmet;

        public int AttackPower
        {
            get { return musket.AttackPower; }
        }

        public int DefensePower
        {
            get { return helmet.DefensePower; }
        }

        public MusketeerKit()
        {
            musket = new DwarvenMusket();
            helmet = new Helmet();
        }
        public override string ToString()
        {
            return "Musket and helmet";
        }
        
    }
}
