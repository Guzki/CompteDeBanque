namespace CompteDeBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue a program de compte de banque.");
            Console.WriteLine("Quel est ton nom?");

            
            string? nom = Console.ReadLine();
            Console.WriteLine($"Nouveau compte créé au nom de : {nom}");

            Console.WriteLine("Qu'est-ce le solde du compte?");
            var soldeString = Console.ReadLine();
            decimal solde = Convert.ToDecimal(soldeString);
            Console.WriteLine($"Le compte {nom} à un solde de {solde}");

            while (true)
            {
                Console.WriteLine("r - retrait, d - dépot, q - quit");
                var réponse = Console.ReadLine();
                if (réponse == "r")
                {
                    Console.WriteLine("Combien veux-tu retirer?");
                    decimal retrait;
                    while (true)
                    {
                        try
                        {
                            retrait = Convert.ToDecimal(Console.ReadLine());
                            break;
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine("Rentre un numero");
                        }

                    }
                    if (retrait <= solde)
                    {
                        solde = solde - retrait;
                        Console.WriteLine($"Tu as maintenant {solde:C}");
                    }
                    else
                    {
                        Console.WriteLine("Pas assez d'argent.");
                    }

                } else if (réponse == "d")
                {
                    Console.WriteLine("depot");
                    Console.WriteLine("Combien veux-tu déposer");
                    // var depot = Console.ReadLine();
                    decimal depot = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"Vous voulez déposer {depot} dollars");
                    solde = solde + depot;

                    Console.WriteLine($"Votre solde est {solde:c}");


                } else if (réponse == "q")
                {
                    Console.WriteLine("quit");
                    break;
                }
            }
        }
    }
}

