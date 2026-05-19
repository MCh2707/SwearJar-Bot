using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SwearJarConsole
{
    class Program
    {
        static UserProfile user = new UserProfile { Name = "User123", SwearCount = 0 };

        static List<string> badWords = new List<string> { "bad1", "bad2", "bad3" };

        static void Main(string[] args)
        {
         
            while (true)
            {
                Console.Write($"{user.Name}: ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit") break;

                if (IsSwearing(input))
                {
                    user.SwearCount++;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"SwearJar: bad word count: {user.SwearCount}");
                    Console.ResetColor();
                }
            }
        }

        static bool IsSwearing(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return false;

            string cleanMessage = Regex.Replace(message.ToLower(), @"[^\w\d]", "");

            return badWords.Any(word => cleanMessage.Contains(word.ToLower()));
        }
    }

    public class UserProfile
    {
        public string Name { get; set; }
        public int SwearCount { get; set; }
    }
}