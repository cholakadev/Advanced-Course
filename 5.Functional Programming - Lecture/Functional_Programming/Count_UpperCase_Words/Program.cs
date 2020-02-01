using System;
using System.Linq;

namespace Count_UpperCase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var words = text.Split(' ', 
                StringSplitOptions.RemoveEmptyEntries);

            var capitalWords = words.Where(word => char.IsUpper(word[0]));

            foreach (var word in capitalWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
