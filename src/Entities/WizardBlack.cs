namespace wallet_jogo_rpg.src.Entities
{
    public class WizardBlack : Hero
    {
        public WizardBlack(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack()
        {
            return this.Name + " lançou magia.";
        }


        public string Attack(int Bonus)
        {
            String tipoMagia = "";

            if (Bonus < 7)
            { tipoMagia = "fraca"; }
            else if (Bonus < 15)
            { tipoMagia = "média"; }
            else
            { tipoMagia = "forte"; }

            return this.Name + " " + this.HeroType + " lançou uma magia " + tipoMagia + " com bonus de ataque de " + Bonus;
        }


    }
}