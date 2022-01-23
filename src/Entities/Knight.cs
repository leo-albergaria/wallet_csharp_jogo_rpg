namespace wallet_jogo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack()
        {
            return this.Name + " " + this.HeroType + " atacou com sua espada.";
        }
    }
}