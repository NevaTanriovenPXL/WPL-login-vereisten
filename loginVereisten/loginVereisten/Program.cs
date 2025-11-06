namespace loginVereisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usernameInput;
            string passwordInput;

            const string user = "Admin", password = "P@sswoord123";
            int tries = 0;
            while (tries < 3)
            {
                Console.Write("Gebruikersnaam: ");
                usernameInput = Console.ReadLine();

                Console.Write("Wachtwoord: ");
                passwordInput = Console.ReadLine();

                if (usernameInput == user && passwordInput == password)
                {
                    Console.WriteLine($"Welkom {usernameInput}");
                }
                tries++;
                Console.WriteLine($"Foutieve login.\n{3 - tries} pogingen over.");
            }




        }
    }
}
