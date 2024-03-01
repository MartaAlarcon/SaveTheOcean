using System; 
namespace vet
{
    public class Program
    {
        const int ONE = 1, TWO = 2, TXP = 45, VXP = 80;

        public static void Main()
        {
            const string MsgWelcome = "Save the ocean!\nQuè vols fer?\n1.Jugar\n2.Sortir";
            const string MsgOption = "Perfecte! Què vols ser?\r\n1. Tècnic (45 XP)\r\n2. Veterinari (80 XP)";
            const string MsgThanks = "Gràcies! Fins aviat";
            const string MsgName = "Genial! I el teu nom?";
            string name;
            int option;
            int playerEXP;
            int newAfectionDegree;
            Random random = new Random();
            int rescueNum = random.Next(999);
            int afectionDegree = random.Next(1, 100);
            int animalOption = random.Next(1,4);
            
            do
            {
                Console.WriteLine(MsgWelcome);
                option = Convert.ToInt32(Console.ReadLine());

            } while (!Option(option));

            if (option == TWO) 
            {
                Console.WriteLine(MsgThanks); //Sortir
            }
            else
            {
                do
                {
                    Console.WriteLine(MsgOption);
                    option = Convert.ToInt32(Console.ReadLine());

                } while (!Option(option));
                if (option == ONE) { playerEXP = TXP; }
                else { playerEXP = VXP; }
                Console.WriteLine(MsgName);
                name = Console.ReadLine();
                Console.WriteLine($"Hola, {name}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:");
                Console.WriteLine();
                switch (animalOption)
                {
                    case 1:
                        Turtle turtle = new Turtle("15/05/2023", "Casimiro  ", "Gavà          ", "Tortuga Marina     ", "Tortuga Careta  ", 7);
                        PrintValues(turtle, rescueNum, afectionDegree);
                        Console.WriteLine($"La tortuga té un grau d’afectació (GA) del {afectionDegree}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?");
                        do
                        {
                            option = Convert.ToInt32(Console.ReadLine());

                        } while (!Option(option));
                        newAfectionDegree = (turtle.NewAfectionDegree(afectionDegree, option));
                        calculateXP(playerEXP, newAfectionDegree);
                        Console.WriteLine(MsgThanks);
                        break;
                    case 2:
                        Seabird seabird = new Seabird("5/2/2024", "Bibi      ", "Badalona      ", "Aus Marines        ", "Golondrina      ", 15.2);
                        PrintValues(seabird, rescueNum, afectionDegree);
                        Console.WriteLine($"L'au té un grau d’afectació (GA) del {afectionDegree}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?");
                        do
                        {
                            option = Convert.ToInt32(Console.ReadLine());

                        } while (!Option(option));
                        newAfectionDegree = (seabird.NewAfectionDegree(afectionDegree, option));
                        calculateXP(playerEXP, newAfectionDegree);
                        Console.WriteLine(MsgThanks);
                        break;
                    case 3:
                        Cetacean cetacean = new Cetacean("4/3/2022", "Loli      ", "Cadaquès      ", "Cetaci             ", "Dofí llistat    ", 15.2);
                        PrintValues(cetacean, rescueNum, afectionDegree);
                        Console.WriteLine($"El dofí té un grau d’afectació (GA) del {afectionDegree}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?");
                        do
                        {
                            option = Convert.ToInt32(Console.ReadLine());

                        } while (!Option(option));
                        newAfectionDegree = (cetacean.NewAfectionDegree(afectionDegree, option));
                        calculateXP(playerEXP, newAfectionDegree);
                        Console.WriteLine(MsgThanks);
                        break;
                }
            }
            
        }
        public static void calculateXP(int playerEXP, int newAfectionDegree)
        {
            if (newAfectionDegree <= 5)
            {
                Console.WriteLine($"El tractament aplicat ha reduït el GA fins al {newAfectionDegree}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP: {playerEXP + 50}XP");
            }
            else
            {
                Console.WriteLine($"El tractament aplicat ha reduït el GA fins al 19%. No ha estat prou efectiu. La teva experiència s’ha reduït en -20XP: {playerEXP - 20}");
            }

        }
        public static bool Option(int option)
        {
            if (option == ONE || option == TWO)
            {
                return true;
            }
            else { return false; }
        }

        public static void PrintValues(Animal animal, int rescueNum, int afectionDegree)
        {
            const string MsgDocument = "Aquí tens la seva fitxa, per a més informació:";
            Console.WriteLine($"+----------------------------------------------------------------+\r\n|                          RESCAT                                |\r\n+----------------------------------------------------------------+\r\n|# Rescat    |Data rescat |Superfamília      | GA |Localització  |\r\n+----------------------------------------------------------------+\r\n|RES{rescueNum}      |{animal.date}   |{animal.family}| {afectionDegree} |{animal.place}|\r\n+----------------------------------------------------------------+");
            Console.WriteLine();
            Console.WriteLine(MsgDocument);
            Console.WriteLine();
            Console.WriteLine($"+----------------------------------------------------------------+\r\n|                          FITXA                                 |\r\n+----------------------------------------------------------------+\r\n|# Nom     |Superfamília        |Espècie         |Pes aproximat  |\r\n+----------------------------------------------------------------+\r\n|{animal.name}|{animal.family}|{animal.species}|{animal.weight}kg         |\r\n+----------------------------------------------------------------+");
        }
    }
}