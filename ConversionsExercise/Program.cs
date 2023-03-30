namespace ConversionsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Įveskite skaičių: ");

                int number = int.Parse(Console.ReadLine());
                string hexadecimal = ConvertToBase(number, 16);
                string oct = ConvertToBase(number, 8);
                string binary = ConvertToBase(number, 2);
                Console.WriteLine("Hexadecimal: " + hexadecimal);
                Console.WriteLine("Oct: " + oct);
                Console.WriteLine("Binary: " + binary);
                Console.WriteLine();
            }

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
    }
}