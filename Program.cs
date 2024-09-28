namespace ChessBoard_Sami_Harun_NET24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ställer in konsolens teckenkodning för att stödja Unicode-tecken
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Tar emot storleken på schackbrädan
            Console.WriteLine("Hej! Skriv in en siffra för schackbrädan.");
            int size = int.Parse(Console.ReadLine());

            // Tar emot tecken från användaren för första och andra rutorna
            Console.WriteLine("Skriv in ditt första tecken?");
            string firstSign = Console.ReadLine();

            Console.WriteLine("Skriv in ditt andra tecken?");
            string secondSign = Console.ReadLine();

            // Skriver ut schackbrädan
            PrintChessBoard(size, firstSign, secondSign);
        }

        // Funktion för att skriva ut schackbrädan
        static void PrintChessBoard(int size, string firstSign, string secondSign)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    // Väljer vilket tecken som ska skrivas ut beroende på rad och kolumn
                    Console.Write((row + col) % 2 == 0 ? firstSign : secondSign);
                }
                // Skriver ut en ny rad efter varje rad på brädan
                Console.WriteLine();
            }

        }
    }
}
