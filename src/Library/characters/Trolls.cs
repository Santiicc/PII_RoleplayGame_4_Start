using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Trolls
    /// </summary>
    public class Trolls : Character
    {
        public Trolls (string name) : base (name)
        {
            this.AddItem(new Staff());
            this.AddItem(new Armor());
            
        }
    }
}
