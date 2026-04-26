using System;
using System.Text.RegularExpressions;

namespace SingleDigitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 個位數計算機 ===");
            Console.WriteLine("請輸入算式 (例如: 3 + 5, 9 - 2, 4 * 7, 8 / 2)");
            Console.WriteLine("輸入 'exit' 離開程式");
            Console.WriteLine("-------------------");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;
                if (input.Trim().ToLower() == "exit") break;

                // 移除所有空白以方便解析
                string expr = input.Replace(" ", "");

                // 使用正規表達式匹配：一個數字 + 運算符 + 一個數字
                Match match = Regex.Match(expr, @"^(\d)([\+\-\*/])(\d)$");

                if (match.Success)
                {
                    int num1 = int.Parse(match.Groups[1].Value);
                    string op = match.Groups[2].Value;
                    int num2 = int.Parse(match.Groups[3].Value);

                    try
                    {
                        double result = Calculate(num1, op, num2);
                        Console.WriteLine("= " + result);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("錯誤：除數不能為零！");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("錯誤：" + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("錯誤：請輸入正確的算式！本計算機僅支援「兩個個位數字」的四則運算 (例如: 1+2)。");
                }
            }
        }

        static double Calculate(int a, string op, int b)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": 
                    if (b != 0) return (double)a / b; 
                    else throw new DivideByZeroException();
                default: throw new InvalidOperationException("未知的運算符號");
            }
        }
    }
}
