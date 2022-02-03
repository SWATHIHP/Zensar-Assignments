using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Cricket
    {
        public int sum;
        public double average;
        int[] score_array;

        public void Pointscalculation(int no_of_matches)
        {
            score_array = new int[no_of_matches];
            Console.WriteLine("Enter the score of match {0}: ", no_of_matches);
            Console.WriteLine();
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter the Score {0} Match : ", i + 1);
                score_array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < score_array.Length; i++)
            {
                sum = sum + score_array[i];
            }
            Console.WriteLine("Sum of Scores in all the Matches : {0} ", sum);
            average = (double)sum / score_array.Length;
            Console.WriteLine("Average of Scores in all the Matches : {0} ", average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfMatches;
            Console.WriteLine("Enter the number of Match Score to be entered.");
            NoOfMatches = int.Parse(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.Pointscalculation(NoOfMatches);
        }
    }
}
