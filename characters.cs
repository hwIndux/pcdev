using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Program

    //角色类 记录角色属性变量（发展力dvlpPower;政治影响力pltcPower；属性变量：意识形态|发展状态|） 
    //      提供分数算法（角色.发展力dvlpPower = 角色基础值 + 意识形态力 + 经济发展力 + 额外效果）；
{
    public class Character
    {
        public int dvplPower;
        public int ideoPower;
        public int ecoPower;
        public int warStatus;
        public int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // int [0] id, int [1] ideoPower, int [2] ecoPower, int [3] warStatus
        public Character[] characterList = 
        {
            new Character() { dvplPower = 5, ideoPower = 3, ecoPower = 3, warStatus = 0 },
            new Character() { dvplPower = 6, ideoPower = 2, ecoPower = 2, warStatus = 0 },
            new Character() { dvplPower = 4, ideoPower = 4, ecoPower = 4, warStatus = 0 },
            new Character() { dvplPower = 7, ideoPower = 1, ecoPower = 5, warStatus = 3 },
        };

       
        
        public Character() 
        { 



        }



    }






}
