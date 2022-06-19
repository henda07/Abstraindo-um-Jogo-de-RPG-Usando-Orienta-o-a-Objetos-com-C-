// See https://aka.ms/new-console-template for more information
using Abstraindo_um_Jogo_de_RPG.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main (string[]args)
        {
            Knight arus = new Knight("Arus", 42, "Knight");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            WhiteWizard white_wizard = new WhiteWizard("Jenica", 42, "White Wizard");
            BlackWizard black_wizard = new BlackWizard("Topapa", 42, "Black Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(white_wizard.Attack(1));
            Console.WriteLine(white_wizard.Attack(7));
            Console.WriteLine(black_wizard.Attack(1));
            Console.WriteLine(black_wizard.Attack(7));
        }
    }
}