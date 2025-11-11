using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Player
    {
        public int playerID;
        public string playerName;
        public string characterName;
        public int dvplPower;
        public int ideoPower;
        public int ecoPower;
        public int warStatus;
        public int ideology;//0-blue 1-red 2-yellow 3-green 4-
        public int dvlpStatus;//0-developed 1-developing 2-underdeveloped
        public (string[], List<Player> playerObjects)   BuildPlayer(int playerNum)//准备玩家信息 根据玩家数量创建玩家数据库 玩家选择角色并根据角色为数据库赋值
        {

            string[] playerList = new string[playerNum];
            List<Player> players = new List<Player>(); //players 存储所有玩家数值的列表
            for (int i = 0; i < playerNum; i++)
            {
                Console.WriteLine("input player " + (i + 1) + " name:");
                playerList[i] = Console.ReadLine(); //playerList数组存储玩家输入的名称
                Player player0 = new Player
                {
                    playerID = 0,
                    playerName = playerList[i],
                    characterName = "null",
                    dvplPower = 0,
                    ideoPower = 0,
                    ecoPower = 0,
                    warStatus = 0,
                    ideology = 0,
                    dvlpStatus = 0
                };
                players.Add(player0);
            }
        
            Console.WriteLine("构建玩家数据库中");


           
            Console.WriteLine("玩家数据库构建完成");



            return (playerList, players);
          
        }

    }
}
