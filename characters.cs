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

        public string characterName;
        public int dvplPower;
        public int ideoPower;
        public int ecoPower;
        public int warStatus;
        public int ideology;//0-blue 1-red 2-yellow 3-green 4-
        public int dvlpStatus;//0-developed 1-developing 2-underdeveloped



        public static Character[] characterList =
        {

            new Character() { characterName = "null", dvplPower = 5, ideoPower = 3, ecoPower = 3, warStatus = 0, dvlpStatus = 0, ideology = 0},//第0行为空
            new Character() { characterName = "Trump", dvplPower = 6, ideoPower = 3, ecoPower = 3, warStatus = 0,dvlpStatus = 0, ideology = 0 },//Trump
            new Character() { characterName = "Starlin", dvplPower = 4, ideoPower = 2, ecoPower = 2, warStatus = 0, dvlpStatus = 1, ideology = 1},//Starlin
            new Character() { characterName = "Hilter", dvplPower = 7, ideoPower = 1, ecoPower = 2, warStatus = 1, dvlpStatus = 1, ideology = 2 },//Hilter

        };



        public Character()

        {

        }







    }













}

