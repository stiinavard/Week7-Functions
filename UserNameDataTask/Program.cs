using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime
            //programm palub kasutajal sisestada numbri 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kaustaja sisestab '2', siis kuvatakse kasutaja eesnime esimene täht
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '3':
                    UserNameLength(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '1':
                    BackwardsName(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;

            }
        }

        public static void UserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu eesnime pikkus on {userInput.Length} sümbolit.");
        }
        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void BackwardsName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
