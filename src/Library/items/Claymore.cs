namespace RoleplayGame.Items
{
    /// <summary>
    /// EnchantedDagger incrementa el valor de ataque
    /// </summary>
    public class Claymore : IAttackItem
    {
    /// <summary>
    /// el poder de ataque
    /// </summary>
    /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }
    }
}