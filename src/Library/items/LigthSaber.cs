namespace RoleplayGame.Items
{
    /// <summary>
    /// LigthSaber incrementa el valor de ataque
    /// </summary>
    public class LigthSaber : IAttackItem
    {
        /// <summary>
        /// El poder de ataque 31
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 31;
            }
        }

        
        public override string ToString()
        {
            return "Magic";
        }
    }
}