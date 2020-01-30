using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = "2^3+5"; // 54,5
            var result = Evaluate(expression);
            Console.WriteLine(result);
        }
        static double Evaluate(string expression)
        {
            var allowedOperators = "+-/*^";
            var numbers = new Stack<double>();
            var operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var @char = expression[i];
                if (@char == '(')
                {
                    operators.Push(@char);
                }
                else if (@char == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        var op = operators.Pop();
                        var param2 = numbers.Pop();
                        var param1 = numbers.Pop();
                        var newValue = ApplyOperation(op, param1, param2);
                        numbers.Push(newValue);
                    }
                    operators.Pop();
                }
                else if (allowedOperators.Contains(@char))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(@char))
                    {
                        var op = operators.Pop();
                        var param2 = numbers.Pop();
                        var param1 = numbers.Pop();
                        var newValue = ApplyOperation(op, param1, param2);
                        numbers.Push(newValue);
                    }
                    operators.Push(@char);
                }
                else if (char.IsDigit(@char) || @char == '.')  // Проверяваме дали чара е цифра или точка...
                {
                    var number = new StringBuilder();  // Правим си стринг билдър.
                    while (char.IsDigit(@char) || @char == '.')  // Докато чара е цифра или точка...
                    {
                        number.Append(@char);   // Апендваме всеки чар към стринг билдъра за да получим цялата цифра.
                        i++;           // Вървим напред към следващия чар за да видим дали и той е цифра и ако е да го апенднем към текущата цифра.
                        if (i == expression.Length)   // Ако индекса е равен на дължината на чаровете в "expression" да брейкне цикъла.
                        {
                            break;
                        }
                        @char = expression[i]; // чара е текущият символ от "expression".
                    }
                    i--;
                    numbers.Push(double.Parse(number.ToString()));  // Когато е брейнало цикъла (стигнали сме дължината на "expression"), пушваме числото в стека, който пази числата.
                }
            }

            while (operators.Count > 0)
            {
                var op = operators.Pop();
                var param2 = numbers.Pop();
                var param1 = numbers.Pop();
                var newValue = ApplyOperation(op, param1, param2);
                numbers.Push(newValue);
            }

            return numbers.Pop();
        }

        static double ApplyOperation(char operation, double operand1, double operand2)
        {
            switch (operation)
            {
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '*': return operand1 * operand2;
                case '/': return operand1 / operand2;
                case '^': return Math.Pow(operand1, operand2);
                default: return 0.0;
            }
        }

        static int Priority(char operation)
        {
            switch (operation)
            {
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                case '^': return 3;
                default: return 0;
            }
        }
    }
}
