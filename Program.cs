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
            Card card = new Card();
            flow.playerNum = flow.GetPlayerNum();//获取玩家数量

            int playerNum = flow.playerNum;//类间变量传递
            flow.pointPool = 100 * flow.playerNum;// 分数池

            Console.WriteLine("player number is " + flow.playerNum);

            (string[] playerList, List<Player> players) = player.BuildPlayer(playerNum);//准备玩家信息 根据玩家数量创建玩家数据库 玩家选择角色并根据角色为数据库赋值

            //flow.players = players;
            // flow.playerList = playerList;
            

            Console.WriteLine("桌游模式【1】 or pc模式【2】？");
            int gameMode = int.Parse(Console.ReadLine());
            switch (gameMode)
            {
                case 1://桌游模式 
                    Console.WriteLine("桌游模式启动中");
                    flow.SelectCharacter(playerList, players);





                    break;
                case 2:
                    Console.WriteLine("pc模式启动中");
                    flow.GiveCharacter(playerList, players);

                    break;
                default:
                    Console.WriteLine("输入有误，默认桌游模式启动");
                    break;
            }
            for (int i = 0; i < flow.playerNum; i++)
            {
                Console.WriteLine("玩家 " + playerList[i] + " 的发展力是: " + players[i].dvplPower);
            }
            Console.WriteLine(players[1].ecoPower + "," + players[1].ideoPower + ","+ players[1].ideology);
            int cardChoice = flow.PlayIssueCard(players);
            flow.ApplyIssueEffect(cardChoice, players);
            Console.WriteLine("player:" + playerList[0] + "'s current ecoPower = " + players[0].ecoPower);
            Console.WriteLine(players[1].ecoPower + "," + players[1].ideoPower);


        }
    }
}
