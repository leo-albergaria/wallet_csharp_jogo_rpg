using System;
using wallet_jogo_rpg.src.Entities;

namespace wallet_jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            Knight arus = new Knight("Arus", 32, "Knight");
            WizardWhite WizardWhite1 = new WizardWhite("Jennica", 23, "White Wizard");
            WizardWhite WizardWhite2 = new WizardWhite("Kiara", 14, "White Wizard");
            WizardBlack WizardBlack1 = new WizardBlack("Pitako", 43, "Black Wizard");
            Ninja Ninja = new Ninja("Oriko", 23, "Ninja");

            System.Console.WriteLine(arus.Attack());
            System.Console.WriteLine(WizardWhite1.Attack(randNum.Next(10)));
            System.Console.WriteLine(WizardWhite2.Attack(randNum.Next(10)));
            System.Console.WriteLine(WizardBlack1.Attack(randNum.Next(20)));
            System.Console.WriteLine(Ninja.Attack());

        }

    }
}