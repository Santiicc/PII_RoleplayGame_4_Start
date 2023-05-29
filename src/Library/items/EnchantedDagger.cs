namespace RoleplayGame.Items
{
    /// <summary>
    /// EnchantedDagger incrementa el valor de ataque
    /// </summary>
    public class EnchantedDagger : IAttackItem
    {
    /// <summary>
    /// el poder de ataque
    /// </summary>
    /// <value></value>
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }
        public override string ToString()
        {
            return "Magic";
        }
    }
}
