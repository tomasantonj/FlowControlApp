namespace FlowControlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Application is gonna offer a menu to the user
            Console.WriteLine("");
            Console.WriteLine("### Välkommen till Biograf Lava! ###");
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Sök information om individuella biljettpriser");
            Console.WriteLine("2. Sök information om biljettpriser för sällskap");
            Console.Write("Välj 1 eller 2. ");
            string choice = Console.ReadLine();

            // create an infinite loop to keep the application running until the user chooses to exit
            
            while (true)
            {
                switch (choice)
                {
                    case "1":
                        // Logic that asks user for his age
                        Console.Write("Var god och ange din ålder: ");
                        string age = Console.ReadLine();

                        // convert age from string to integer
                        Console.WriteLine("Du är " + age + "år gammal. Se priser nedan: ");

                        // Logic that checks the age and displays the corresponding ticket price
                        if (int.TryParse(age, out int ageInt))
                        {
                            if (ageInt <= 20)
                            {
                                Console.WriteLine("Ungdomspris: 80 kr");
                            }
                            else if (ageInt >= 21 && ageInt < 65)
                            {
                                Console.WriteLine("Vuxenpris: 120 kr");
                            }
                            else if (ageInt >= 65)
                            {
                                Console.WriteLine("Seniorpris: 90 kr");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ogiltig ålder angiven. Försök igen.");
                        }

                        break;
                    case "2":
                        Console.WriteLine("");
                        break; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                // Prompt for the next action
                Console.WriteLine("");
                Console.WriteLine("### Välkommen till Biograf Lava! ###");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Sök information om individuella biljettpriser");
                Console.WriteLine("2. Sök information om biljettpriser för sällskap");
                Console.Write("Välj 1 eller 2. ");
                choice = Console.ReadLine();
            }
        }
    }
}
