using static Program.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine(players[1].ecoPower + "," + players[1].ideoPower + "," + players[1].ideology);


            //进入回合
            int round = 0;
            while(flow.pointPool > 0)
            {
                Console.WriteLine("当前分数池剩余: " + flow.pointPool);
                
                Console.WriteLine("第 " + (round + 1) + " 轮开始");

                int selectHost = round % flow.playerNum;
                Console.WriteLine("本轮host玩家是: " + playerList[selectHost]);

                Console.WriteLine("玩家 " + playerList[selectHost] + " 请选择一张议题卡打出:");
                int cardChoice = flow.PlayIssueCard();
                Console.WriteLine("玩家 " + playerList[selectHost] + " 选择了议题卡: " + Card.issueCards[cardChoice].issueName);
                Console.WriteLine("议题内容为: " + Card.issueCards[cardChoice].issueNote);


                Console.Write("请host在：");
                for (int i = 0; i < flow.playerNum; i++)
                {
                    if (i != selectHost)
                    {
                        Console.Write((i + 1) + "号玩家 " + playerList[i] + " ，");
                    }
                }
                Console.Write("中选择发言顺序：");

                int[] order = new int[flow.playerNum - 1];
                for (int i = 0; i < flow.playerNum - 1; i++)
                {
                    order[i] = int.Parse(Console.ReadLine()) - 1;
                }
                Console.WriteLine("发言顺序确定为：");
                for (int i = 0; i < flow.playerNum - 1; i++)
                {
                    Console.Write((order[i] + 1) + "号玩家 " + playerList[order[i]] + " ，");
                }

                flow.Movement(order, playerList);
                
                flow.ApplyIssueEffect(cardChoice, players);

                
    

              //  flow.ApplyIssueEffect(cardChoice, players);

                round++;
             
                
            }


           
            Console.WriteLine("player:" + playerList[0] + "'s current ecoPower = " + players[0].ecoPower);
            Console.WriteLine(players[1].ecoPower + "," + players[1].ideoPower);


        }
    }
}
