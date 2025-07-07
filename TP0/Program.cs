using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matricule, nomEtudiant;
            int MATH, PC, SVT, MALG, FRS;


            Console.WriteLine("Entrez le nom de l'etudiant: ");
            nomEtudiant = Console.ReadLine();

            Console.WriteLine("Entrez le matricule de l'etudiant: ");
            matricule = Console.ReadLine();

            Console.WriteLine("Entrez vos notes de Math: ");
            MATH = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Entrez vos notes de PC: ");
            PC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez vos notes de SVT: ");
            SVT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez vos notes de Math: ");
            MATH = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez vos notes de Math: ");
            MATH = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Bonjour {nomEtudiant} matricule {matricule}!");



            Console.ReadKey();
        }
    }
}
