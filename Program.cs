using System.Net.Security;

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
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Vill du istället få tillgång till coola funktioner som programmet erbjuder?");
            Console.WriteLine("Välj då 3 eller 4¨: ");
            Console.WriteLine("3. Visa ett meddelande 10 gånger");
            Console.WriteLine("4. Dela upp en mening i ord och visa var tredje ord i versaler");
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
                        // logic that asks user for the number of people in the group
                        // and calculates the total price based on the number of people and their ages

                        Console.Write("Var god och ange antalet personer i sällskapet: ");
                        string groupSizeInput = Console.ReadLine();
                        Console.WriteLine("Du har angett " + groupSizeInput + " personer i sällskapet.");

                        // For each person in the group, create a list and ask for their ages
                        Console.WriteLine("Ange åldrarna för varje person i sällskapet, separerade med kommatecken:");
                        Console.WriteLine("Exempel: 18, 25, 30, 65");
                        Console.WriteLine("Om du inte vill ange ålder för en person, skriv 'n/a' för den personen.");

                        string agesInput = Console.ReadLine();
                        string[] agesArray = agesInput.Split(',').Select(age => age.Trim()).ToArray();

                        // Convert the ages to integers, using 120 as default for 'n/a'
                        for (int i = 0; i < agesArray.Length; i++)
                        {
                            if (agesArray[i].ToLower() == "n/a")
                            {
                                agesArray[i] = "120"; // Default price for unspecified age
                            }
                        }

                        int[] ages = agesArray.Select(age => int.TryParse(age, out int parsedAge) ? parsedAge : 120).ToArray();
                        int totalPrice = 0;
                        foreach (int personAge in ages)
                        {
                            if (personAge <= 20)
                            {
                                totalPrice += 80; // Youth price
                            }
                            else if (personAge >= 21 && personAge < 65)
                            {
                                totalPrice += 120; // Adult price
                            }
                            else if (personAge >= 65)
                            {
                                totalPrice += 90; // Senior price
                            }
                        }

                        // Display the total price for the group
                        Console.WriteLine("Totalt pris för sällskapet: " + totalPrice + " kr");
                        Console.WriteLine("Totalt antal personer i sällskapet: " + agesArray.Length);
                        Console.WriteLine("Du har angett följande åldrar för sällskapet: " + string.Join(", ", agesArray));
                        break; // Exit the application
                    
                    
                    case "3":
                        // logic to take user input and display that message 10 times to the console
                        Console.Write("Var god och ange ett meddelande: ");
                        string message = Console.ReadLine();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Meddelandet kommer nu att visas 10 gånger:");
                        // run tests on message verifying that it is not null or empty
                        if (string.IsNullOrEmpty(message))
                        {
                            Console.WriteLine("Meddelandet får inte vara tomt. Försök igen.");
                            continue; // Skip to the next iteration of the loop
                        }


                        // Using a foor loop display the message 10 times, without line breaks
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(message + " ");
                        }
                        Console.WriteLine(); // Add a new line after displaying the message 10 times

                        break;
                    case "4":
                        // logic that takes user input, stores it in a var and then split words in the string on every space
                        // and then displays each word on a new line
                        Console.WriteLine("Du har valt att dela upp en mening i ord.");
                        Console.Write("Var god och ange en mening: ");
                        var sentence = Console.ReadLine();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Mening: " + sentence);
                        // check if sentence has atleast 3 words, if not, ask for  new sentence
                        if (string.IsNullOrWhiteSpace(sentence) || sentence.Split(' ').Length < 3)
                        {
                            Console.WriteLine("Mening måste innehålla minst tre ord. Försök igen.");
                            continue; // Skip to the next iteration of the loop
                        }

                        // Split the sentence into words then iterate over the words, display each 3rd word in uppercase
                        string[] words = sentence.Split(' ');

                        Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Var tredje ord i meningen i versaler: ");
                            for (int i = 2; i < words.Length; i += 3) // Start from index 2 (3rd word) and increment by 3
                            {
                                Console.WriteLine(words[i].ToUpper());
                            }
                        Console.WriteLine(); // Add a new line after displaying the words

                        break;

                    default:
                        Console.WriteLine("Var god välj alternativ 1-2 för biopriser och 3-4 för roliga funktioner :)");
                        break;
                }

                // Prompt for the next action
                Console.WriteLine("");
                Console.WriteLine("### Välkommen till Biograf Lava! ###");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Sök information om individuella biljettpriser");
                Console.WriteLine("2. Sök information om biljettpriser för sällskap");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Vill du istället få tillgång till coola funktioner som programmet erbjuder?");
                Console.WriteLine("Välj då 3 eller 4¨: ");
                Console.WriteLine("3. Visa ett meddelande 10 gånger");
                Console.WriteLine("4. Dela upp en mening i ord och visa var tredje ord i versaler");
                choice = Console.ReadLine();
            }
        }
    }
}
