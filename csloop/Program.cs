using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //long start = DateTime.Now.Ticks;
            //long count = 0;
            //while(start + (10000000) > DateTime.Now.Ticks)
            //{
            //    count++;
            //}
            //Console.WriteLine(count + "만큼 반복함");
            //string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            /* foreach (string item in array)
            {
                Console.WriteLine(item);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(100);
                x++;
            }
                while (true)
                {
                ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.WriteLine("위로 이동");
                            break;
                        case ConsoleKey.RightArrow:
                            Console.WriteLine("오른쪽로 이동");
                            break;
                        case ConsoleKey.DownArrow:
                            Console.WriteLine("아래로 이동");
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.WriteLine("왼쪽로 이동");
                            break;
                        case ConsoleKey.X:
                            break;
                    }
                } */

            /*for(int i = 0; i< 10; i++)
            {
                for (int  j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.Write('\n');
            }*/

            /*for(int i = 0; i< 10; i++)
            {
                for (int  j = 0; j < 10-i; j++)
                    Console.Write(" ");
                for(int j = 0; j<i+1; j++)
                    Console.Write("*");
                Console.Write('\n');
            }*/

            /*while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료) : ");
                int input = int.Parse(Console.ReadLine());
                if(input %2 == 0)
                {
                    break;
                }
            }*/
            /*for(int i = 1; i<10; i++)
            {
                if(i%2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/
            /*string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());*/

            /*string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });
            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }*/

           /* string input = " test        \n";
            Console.WriteLine("::" + input.Trim() + "::");
            //Console.Read();

            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));*/
            int[] array1 = new int[10];
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            int i = 0;
            while (i < 10) { Console.Write("출력"); i++; }
        }
    }
}    
