namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class MagicHat : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value>int</value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value>int</value>
        public int DefensePower
        {
            get
            {
                return 55;
            }
        }

        public override string ToString()
        {
            return "MagicHat";
        }
    }
}