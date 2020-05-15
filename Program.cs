using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuário, o que você pensa sobre mim? Você é muito sem graça!");
            Console.WriteLine("- E sabe o que eu penso de você?");
            string caractere = Console.ReadLine();
            caractere = caractere.Remove(10);
            Console.WriteLine(caractere + "... NÃO, PERA.\nTô nervoso");




        }
    }
}
