using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Player
    {

        public string name;
        public int dvplPower;
        public int ideoPower;
        public int ecoPower;
        public int warStatus;

        
        public void Prepare()
        {

            string[] playerList = new string[flow.playerNum];

            for (int i = 0; i < playerNum; i++)
            {
                Console.WriteLine("input player " + (i + 1) + " name:");
                playerList[i] = Console.ReadLine(); //玩家名称在playerList数组中
            }
            Console.WriteLine("Players are:");
            for (int i = 0; i < playerNum; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ": " + playerList[i]);
            }
            Console.WriteLine("构建玩家数据库中");
            List<Player> players = new List<Player>();
            for (int i = 0; i < playerNum; i++)
            {
                string playerName = $"player{i + 1}";
                Player Players = new Player
                {
                    name = playerList[i],
                    dvplPower = 5,
                    ideoPower = 3,
                    ecoPower = 3,
                    warStatus = 0
                };
                players.Add(Players);
                Console.WriteLine($"Created Player: {Players.name}, DvlpPower: {Players.dvplPower}, ideoPower: {Players.ideoPower}, ecoPower, warStatus: {Players.warStatus}");

            }

    }
}
