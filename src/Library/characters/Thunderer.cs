using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Dwarven Thunderer
    /// </summary>
    public class Thunderer : Character
    {
        public Thunderer(string name)
            : base(name)
        {
            this.Health = 100;
            this.AddItem(new MusketeerKit());
        }
    }
}