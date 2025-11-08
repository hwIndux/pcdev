using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Flow
    {
        public int playerNum;
        public int pointRemain;
        public int givePoint;

        public Flow()
        {
            this.playerNum = 0;

        }
        public int GetPlayerNum() 
        {
            Console.WriteLine("input player number:");
            playerNum = int.Parse(Console.ReadLine());
            return playerNum;
        }


        public int GetPoint()
        {
            pointRemain = pointRemain - givePoint;
            return pointRemain;
        }







    }
}
