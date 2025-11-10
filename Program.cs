using static Program.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
namespace Program
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Flow flow = new Flow();
            Player player = new Player();
            flow.playerNum = flow.GetPlayerNum();//获取玩家数量
            flow.pointPool = 100 * flow.playerNum;// 分数池

            Console.WriteLine("player number is " + flow.playerNum);

            player.Prepare();

        }
    }
}
