using System;

namespace inluppg5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 30;
            nums[1] = 14;
            Console.WriteLine("Skriv in ett tal");
            nums[2] = int.Parse(Console.ReadLine());

            Console.Write("Talen är: " + nums[0]);
            for (int i  = 1; i < nums.Length; i++)
            {
                Console.Write(", " + nums[i]);
            }
        }
    }
}