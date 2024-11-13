// See https://aka.ms/new-console-template for more information
using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // 隨機生成 1 到 100 之間的數字
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("歡迎來到猜數字遊戲！");
            Console.WriteLine("我已經選了一個 1 到 100 之間的數字。來猜猜看吧！");

            while (guess != targetNumber)
            {
                Console.Write("請輸入你的猜測：");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess > targetNumber)
                    {
                        Console.WriteLine("太高了！再試一次。");
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("太低了！再試一次。");
                    }
                    else
                    {
                        Console.WriteLine($"恭喜！你猜中了！答案是 {targetNumber}。");
                        Console.WriteLine($"你一共猜了 {attempts} 次。");
                    }
                }
                else
                {
                    Console.WriteLine("請輸入一個有效的數字！");
                }
            }
        }
    }
}

