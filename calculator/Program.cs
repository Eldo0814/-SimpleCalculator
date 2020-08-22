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
            Console.WriteLine("1=日本語 2=英語/1=Japanese 2=English");
            switch (Console.ReadLine())
            {
                case "1":
                    goto jp;
                    break;
                case "2":
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
                Console.WriteLine("1=addition 2=subtraction 3=multiplication 4=division");

                //Code when calculating
                //Please select the mode when calculating
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(number + number1);
                        break;
                    case "2":
                        Console.WriteLine(number - number1);
                        break;
                    case "3":
                        Console.WriteLine(number * number1);
                        break;
                    case "4":
                        Console.WriteLine(number % number1);
                        break;
                }

                //Whether to quit or try again

                Console.WriteLine("Whether to quit or try again");
                Console.WriteLine("1=down 2=tru again");

                switch (Console.ReadLine())
                {
                    case "1":
                    goto end;
                        break;
                case "2":
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
            Console.WriteLine("1=足し算 2=引き算 3=掛け算 4=割り算");

            //計算するときのモードを選択してください
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(number + number1);
                    break;
                case "2":
                    Console.WriteLine(number - number1);
                    break;
                case "3":
                    Console.WriteLine(number * number1);
                    break;
                case "4":
                    Console.WriteLine(number % number1);
                    break;
            }

            //終了するかもう一回するか

            Console.WriteLine("もう一度計算するか終了するか選択してください");
            Console.WriteLine("1=終了 2=もう一度計算をする");

            switch (Console.ReadLine())
            {
                case "1":
                    goto end;
                    break;
                case "2":
                    goto jp;
                    break;
            }
        end:;
        }
        }
    }
