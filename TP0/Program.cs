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

            Console.WriteLine("Entrez vos notes de Malagasy: ");
            MALG = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez vos notes de Francais: ");
            FRS = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Bonjour {nomEtudiant} matricule {matricule}!");

            Console.WriteLine(Moyenne(MATH, PC, SVT, MALG, FRS));
            float moyenne=Moyenne(MATH, PC, SVT, MALG, FRS);

            IsValidate(moyenne);

            Mention(moyenne);


            Console.ReadKey();
        }

        static float Moyenne(int MATH, int PC, int SVT, int MALG, int FRS)
        {
            return ((MATH + PC + SVT + MALG + FRS) / 5);
        }

        static void IsValidate(float Moyenne)
        {
            if (Moyenne >= 10)
            {
                Console.WriteLine("Felicitation vous avez validé");
            }
            else
            {
                Console.WriteLine("Malheureusement vous avez echoué");
            }
        }

        static void Mention(float Moyenne)
        {
            if ((Moyenne >= 10) && (Moyenne <= 11.99))
            {
                Console.WriteLine("Mention Passable.");
            }
            else if ((Moyenne >= 12) && (Moyenne <= 13.99))
            {
                Console.WriteLine("Mention Assez bien.");
            }
            else if ((Moyenne >= 14) && (Moyenne <= 15.99))
            {
                Console.WriteLine("Mention Bien.");
            }
            else if ((Moyenne > 16))
            {
                Console.WriteLine("Mention Très Bien.");
            }
            else
            {
                Console.WriteLine("Echec. ");
            }
        }
    }

}
