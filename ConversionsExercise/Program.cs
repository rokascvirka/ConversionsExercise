namespace ConversionsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            
            while(isRunning)
            {
                string input = GetNumberFromUser();
                if (input == "QUIT") 
                {
                    isRunning = false;
                }
                else
                {
                    int number = int.Parse(input);

                    var options = DisplayOptions(number);
                    switch (options)
                    {
                        case "1":
                            string binary = ConvertToBase(number, 2);
                            Console.WriteLine("Binary: " + binary);
                            break;
                        case "2":
                            string oct = ConvertToBase(number, 8);
                            Console.WriteLine("Oct: " + oct);
                            break;
                        case "3":
                            string hexadecimal = ConvertToBase(number, 16);
                            Console.WriteLine("Hexadecimal: " + hexadecimal);
                            break;
                        case "QUIT":
                            isRunning = false;
                            break;

                    }
                    Console.WriteLine();
                }
            }

        }

        public static string GetNumberFromUser()
        {
            Console.WriteLine("Įveskite skaičių, kurį norite konvertuoti: ");
            string input = Console.ReadLine();
            if (input == "QUIT")
            {
                return "QUIT";
            }
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Įvestis negali būti tuščia. Bandykite dar kartą...");
                return GetNumberFromUser();
            }
            else
            {
                return input;
            }
        }

        public static string DisplayOptions(int number)
        {
            Console.WriteLine($"Skaičius {number}.{Environment.NewLine}Pasirinkite 1 - jeigu norite konvertuoti į binary,{Environment.NewLine}2 - jei norite konvertuoti į oct,{Environment.NewLine}3 - jeigu norite konvertuoti į hexadecimal,{Environment.NewLine}4 - išjungti programą.");
            var option = Console.ReadLine();
            if(IsNotEmpty(option, number))
            {
                return option;
            }
            return "Įvestis negali būti tuščia";
        }

        public static bool IsNotEmpty(string input, int number)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Įvestis negali būti tuščia. Bandykite dar kartą...");
                DisplayOptions(number);
            }
            return true;
        }
        public static string ConvertToBase(int decimalNumber, int baseNumber)
        {
            const string DIGITS = "0123456789ABCDEF";
            string result = string.Empty;

            if (decimalNumber == 0)
            {
                return "0";
            }

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseNumber;
                decimalNumber /= baseNumber;
                result = DIGITS[remainder] + result;
            }

            return result;
        }

        public static bool isOptionInvalid(string option, string[] validOptions)
        {
            if (validOptions.Contains(option))
            {
                return false;
            }
            return true;
        }
    }
}