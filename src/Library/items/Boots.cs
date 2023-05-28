namespace RoleplayGame.Items;
    /// <summary>
    /// Botas,incrementa la defensa.
    /// </summary>
    public class Boots : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value>int</value>
        public int DefensePower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Boots";
        }
    }