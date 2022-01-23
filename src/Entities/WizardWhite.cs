namespace wallet_jogo_rpg.src.Entities
{
    public class WizardWhite : Hero
    {
        public WizardWhite(string Name, int Level, string HeroType)
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

            if (Bonus < 3)
            { tipoMagia = "fraca"; }
            else if (Bonus < 6)
            { tipoMagia = "média"; }
            else
            { tipoMagia = "forte"; }

            return this.Name + " " + this.HeroType + " lançou uma magia " + tipoMagia + " com bonus de ataque de " + Bonus;
        }


    }
}