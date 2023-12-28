namespace rock_paper_scissors_game;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Rock Paper Scissors Game";

        int playerScore = 0;
        int botScore = 0;
        Random random = new Random();
        bool playAgain = true;
        string answer;
        string player;
        string bot;

        while (playAgain)
        {
            player = "";
            bot = "";
            answer = "";

            while (player != "r" && player != "p" && player != "s") {
            Console.WriteLine("\nType r for rock, p for paper or s for scissors.");
            player = Console.ReadLine();
            player = player.ToLower();
            }

            switch (random.Next(1, 4)) //bot will pick one of the three cases here.
            {
                case 1: bot = "r";
                break;
                case 2: bot = "p";
                break;
                case 3: bot = "s";
                break;
            }

            Console.WriteLine("Player chose: " + player);
            Console.WriteLine("Bot chose: " + bot);

            switch (player)
            {
                case "r":
                    if (bot == "r") {
                        Console.WriteLine("TIE!");
                    }
                    else if (bot == "p") {
                        Console.WriteLine("YOU LOSE!");
                        botScore++;
                    }
                    else { //Scissors is the only one left
                        Console.WriteLine("YOU WIN!");
                        playerScore++;
                    }
                    break;
                case "p":
                    if (bot == "r") {
                        Console.WriteLine("YOU WIN!");
                        playerScore++;
                    }
                    else if (bot == "p") {
                        Console.WriteLine("TIE!");
                    }
                    else {
                        Console.WriteLine("YOU LOSE!");
                        botScore++;
                    }
                    break;
                default: //The only option left if not r or p = s.
                    if (bot == "r") {
                        Console.WriteLine("YOU LOSE!");
                        botScore++;
                    }
                    else if (bot == "p") {
                        Console.WriteLine("YOU WIN!");
                        playerScore++;
                    }
                    else {
                        Console.WriteLine("TIE!");
                    }
                    break;
            }
                Console.WriteLine("Player score: " + playerScore + ". Bot score: " + botScore);
                Console.WriteLine("Press any key to play again or type " + "QUIT " + "to stop.");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "QUIT") {
                    playAgain = false;
                } else {
                    playAgain = true;
                }

            }
        Console.WriteLine("Thanks for playing!");
        Console.ReadKey();
    }
}
