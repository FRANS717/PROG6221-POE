using System;

namespace PROG6221_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set console title and initial colors
            Console.Title = "Cybersecurity Awareness Chatbot";
            ConsoleHelper.SetConsoleColor(ConsoleColor.Cyan, ConsoleColor.Black);

            // Play voice greeting (WAV file)
            // IMPORTANT: Place your recorded greeting.wav file in the output directory 
            // (e.g., bin/Debug/net10.0/) or provide a full path.
            // Update the path below to point to your actual file.
            string audioFilePath = @"C:\Users\shimi\Videos\PROG6221 V1\PROG6221 V1\AUDIO.wav"; // Make sure the file is in the output folder
            AudioPlayer.PlayGreeting(audioFilePath);

            // Display ASCII art header
            ConsoleHelper.WriteColored(AsciiArt.GetArt(), ConsoleColor.Cyan);
            Console.WriteLine(); // add a newline after

            // Personalized welcome
            ConsoleHelper.WriteColored("Hello! I'm your Cybersecurity Awareness Assistant.\n", ConsoleColor.Green);
            ConsoleHelper.WriteColored("Please enter your name: ", ConsoleColor.Yellow);
            string userName = Console.ReadLine().Trim();

            // Validate name input (if empty, assign a default)
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Friend";
                ConsoleHelper.WriteColored("I'll call you Friend for now.\n", ConsoleColor.DarkYellow);
            }
            else
            {
                ConsoleHelper.WriteColored($"Nice to meet you, {userName}!\n", ConsoleColor.Green);
            }

            // Create the chatbot instance and start interaction
            Chatbot bot = new Chatbot(userName);
            bot.Start();

            // Goodbye message
            ConsoleHelper.WriteColored("\nThank you for using the Cybersecurity Awareness Chatbot. Stay safe online!\n", ConsoleColor.Magenta);
            ConsoleHelper.PrintSeparator('*');
            ConsoleHelper.SetConsoleColor(ConsoleColor.Gray, ConsoleColor.Black);
        }
    }
}