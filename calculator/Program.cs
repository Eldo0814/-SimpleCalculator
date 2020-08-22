using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
                //int numberは数字を入力したときに代入されます/If you enter a number, an int number will be assigned
                int number = 0;
                int number1 = 0;
            //言語の選択をする/Select a language
            Console.WriteLine("言語を選択してください/Select a language");
            Console.WriteLine("a=日本語 b=英語/a=Japanese b=English");
            switch (Console.ReadLine())
            {
                case "a":
                    goto jp;
                    break;
                case "b":
                    goto us;
                    break;
            }
            us:
                //Please enter a number
                Console.WriteLine("Please enter a number");
                number = Convert.ToInt32(Console.ReadLine());

                //Please enter another number
                Console.WriteLine("Please enter a number");
                number1 = Convert.ToInt32(Console.ReadLine());

                //Character drawing for which mode
                Console.WriteLine("Please enter another number");
                Console.WriteLine("a=addition b=subtraction c=multiplication d=division");

                //Code when calculating
                //Please select the mode when calculating
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine(number + number1);
                        break;
                    case "b":
                        Console.WriteLine(number - number1);
                        break;
                    case "c":
                        Console.WriteLine(number * number1);
                        break;
                    case "d":
                        Console.WriteLine(number % number1);
                        break;
                }

                //Whether to quit or try again

                Console.WriteLine("Whether to quit or try again");
                Console.WriteLine("a=down b=tru again");

                switch (Console.ReadLine())
                {
                    case "a":
                    goto end;
                        break;
                case "b":
                    goto us;
                    break;
            }
        jp:
            //数字を入力してください
            Console.WriteLine("数字を入力してください");
            number = Convert.ToInt32(Console.ReadLine());

            //もう一つの数字を入力してください
            Console.WriteLine("もう一つの数字を入力してください");
            number1 = Convert.ToInt32(Console.ReadLine());

            //どのモードにするかの文字描画
            Console.WriteLine("どのモードにするか選択してください");
            Console.WriteLine("a=足し算 b=引き算 c=掛け算 d=割り算");

            //計算するときのモードを選択してください
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine(number + number1);
                    break;
                case "b":
                    Console.WriteLine(number - number1);
                    break;
                case "c":
                    Console.WriteLine(number * number1);
                    break;
                case "d":
                    Console.WriteLine(number % number1);
                    break;
            }

            //終了するかもう一回するか

            Console.WriteLine("もう一度計算するか終了するか選択してください");
            Console.WriteLine("1=終了 2=もう一度計算をする");

            switch (Console.ReadLine())
            {
                case "a":
                    goto end;
                    break;
                case "b":
                    goto jp;
                    break;
            }
        end:;
        }
        }
    }
