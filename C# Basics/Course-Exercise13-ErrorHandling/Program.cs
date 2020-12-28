using System;

namespace Course_Exercise13_ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice;
            bool error = true;
            byte parsedByte;
            do
            {
                try
                {
                    Console.WriteLine("Please make a selection to learn more information");
                    DisplayMenu();
                    menuChoice = (Console.ReadLine());

                    if (byte.TryParse(menuChoice, out parsedByte)){
                        switch (parsedByte)
                        {
                            case 1:
                                Trex();
                                break;
                            default:
                                throw new Exception($"{menuChoice} is not one of the choices.");
                                //break;
                        }
                        error = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Data Type Inputted");
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                }
            } while (error);

        }

        static void Trex()
        {
            Console.WriteLine();
            Console.WriteLine("Tyrannosaurus, meaning \"tyrant lizard\", from the Ancient Greek tyrannos, \"tyrant\", and sauros, \"lizard\" is a genus of coelurosaurian theropod dinosaur. The species Tyrannosaurus rex (rex meaning \"king\" in Latin), is one of the most well-represented of the large theropods. Tyrannosaurus lived throughout what is now western North America, on what was then an island continent known as Laramidia. Source: Wikipedia.");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1 - Tyrannosaurus rex\n2 - Stegosaurus\n3 - Velociraptor");
        }
}
}
