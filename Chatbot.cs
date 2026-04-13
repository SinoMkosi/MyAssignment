namespace MyAssignment
{
    using System;

    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            UIHelper.ShowLogo();

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Enter your name: ");
                userName = Console.ReadLine();
            }

            Console.WriteLine($"\nHello {userName}! How can I assist you today?\n");

            ChatLoop();
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter something.");
                    continue;
                }

                string response = Responses.GetResponse(input);
                Console.WriteLine(response);
            }
        }
    }
}