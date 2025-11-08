using static Program.Character;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Program
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Flow flow = new Flow();
            flow.playerNum = flow.GetPlayerNum();//获取玩家数量
            flow.pointRemain = 50 * flow.playerNum;// 分数池

            Console.WriteLine("player number is " + flow.playerNum);
            Console.WriteLine("point remain is " + flow.pointRemain);















           

        }
    }
}
