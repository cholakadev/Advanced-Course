using System;
using System.Collections.Generic;

namespace Match_Breckets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)  // Обикаляме дължината на инпута.
            {
                var @char = input[i];   // Присвояваме всеки символ към отделна променлива.

                if (@char == '(')   // Ако символа е отваряща скоба...
                {
                    stack.Push(i);  // Пушваме в стека. (Срещаме 2 отворени скоби една след друга)
                }
                else if (@char == ')')  // Ако пък символа е затваряща скоба...
                {
                    var leftIndex = stack.Pop();   // Взимаме индекса на предходната отваряща скоба от стека и след като го обработим го трием.(Преди тази отваряща скоба има още 1 за големия израз, която стои и чака да попаднем на затваеяща)
                    var expression = input.Substring(leftIndex, i - leftIndex + 1);   // От инпута взимаме израза м/у двете скоби.
                    Console.WriteLine(expression);  // Печатаме на конзолата.
                }
            }
        }
    }
}
