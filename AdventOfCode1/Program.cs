using System;
class Program
{
    static void Main()
    {
        const int Range = 100;
        int position = 50;
        int zeroCount = 0;

        while (true)
        {
            Console.WriteLine("Enter rotation: ");
            string input = Console.ReadLine();
 
            char direction = input[0];

            string numbers = input.Substring(1);
            int.TryParse(numbers, out int amount);
 
            int difference = (direction == 'R') ? amount : -amount;
 
            position = UpdatePosition(position + difference, Range);
 
            Console.WriteLine($"Position: {position}");
            if (position == 0)
            {
                zeroCount++;
                Console.WriteLine($"Zero reached. Zero count: {zeroCount}");
            }
        }
    }
    static int UpdatePosition(int value, int mod)
    {
        return ((value % mod) + mod) % mod;
    }
}