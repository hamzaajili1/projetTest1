using projectTest1;
using System;

namespace projectTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le premier nombre :");
            int nombre1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre :");
            int nombre2 = Convert.ToInt32(Console.ReadLine());

            int resultat = Calculatrice.Addition(nombre1, nombre2);

            Console.WriteLine("Le résultat de l'addition de " + nombre1 + " et " + nombre2 + " est : " + resultat);
            Console.WriteLine("Appudfgdfyez une tosdgfsdgsduche pour fermer...");
            Console.ReadKey();
        }
    }
}
