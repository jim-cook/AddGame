using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
        begin:
            int score = 0;
            int sum = 0;
            int rdn = 0;
            int x = 0;
            Random rd = new Random();
            Console.WriteLine("请输入一个数字使其与给定数字相加为100！输入end，不论大小写均可退出游戏！");

            
            do
            {
                
                Console.WriteLine("给定数字为：");
                rdn = rd.Next(0, 101);
                Console.WriteLine(rdn);
                Console.WriteLine("请输入你的答案：");
                string str1 = Console.ReadLine();

                if (str1.ToLower() == "end")
                {
                    goto end;
                }

                try
                {
                    x = int.Parse(str1);
                }
                catch 
                {
                    Console.WriteLine("你输入的数字不符合规则，请重新输入！");
                    continue;
                }

                sum = rdn + x;

                if (sum==100)
                {
                    score++;
                    Console.WriteLine("恭喜你，答对了！");
                }
                else
                {
                    Console.WriteLine("答案不对哦，再接再厉！");
                }
            } while (sum==100);
            end:
            Console.WriteLine("你的最终分数为：");
            Console.WriteLine(score);
            Console.WriteLine("想要继续游戏可以输入start，不论大小写，彻底退出游戏请输入非start的任意内容！");
            string str2 = Console.ReadLine();
            if (str2.ToLower()=="start")
            {
                goto begin;
            }
        }
    }
}
