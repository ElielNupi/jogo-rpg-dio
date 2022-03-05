using System;
using src.Entities;
namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("");
            System.Console.WriteLine("Testando Classe Guerreiro: ");
            System.Console.WriteLine("");
            Warrior Teste = new Warrior("Roberto", 14);
            System.Console.WriteLine("Testando ataque: ");
            System.Console.WriteLine(Teste.Attack());
            System.Console.WriteLine("");
            System.Console.WriteLine("Testando Defesa: ");
            System.Console.WriteLine(Teste.Deffend());
            System.Console.WriteLine("");
            
            System.Console.WriteLine("Testando Classe Mago");
            System.Console.WriteLine("");
            Mage Eliel = new Mage("Eliel", 18);
            System.Console.WriteLine("Testando ataque: ");
            System.Console.WriteLine(Eliel.Attack());
            System.Console.WriteLine("");
            System.Console.WriteLine("Testando Ataque com outras mágias (1 - Ataque de fogo, 2 - Ataque elétrico)");
            System.Console.WriteLine(Eliel.Attack(1));
            System.Console.WriteLine(Eliel.Attack(2));
            System.Console.WriteLine("");
            System.Console.WriteLine("Testando Defesa: ");
            System.Console.WriteLine(Eliel.Deffend());
            System.Console.WriteLine("");
        }
    }
}
