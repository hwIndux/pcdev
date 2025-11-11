using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    //流程控制类 记录一些流程影响变量（玩家数量|分数池|记牌器|记分器|等） 提供一些流程控制方法 
    //        
    //流程Pre   确认玩家数量 初始化分数池; 分配玩家编号 确认顺序； 发放初始卡牌；
    //流程Round 开启阶段：根据顺序确定本轮host玩家; host选择icard打出；host选择剩余玩家操作顺序；
    //         行动阶段：玩家2选择行动（）；玩家3选择行动（）...；记录行动效果；
    //         结算阶段：玩家1选择投票人员；记录投票与结果；部分行动卡在此时发动；执行本轮icard & acard效果；分数分配与记录；
    //流程结算  游戏结束条件达成（pointPool = 0）；计算额外效果；计算最终分数；宣布胜利者；
    //         
    public class Flow
    {
        public int playerNum;
        public int pointPool;
        public int givePoint;
       // public string[] playerList;
       // public List<Player> players;
        
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

        public void GiveCharacter(string[] playerList, List<Player> players) //PC模式方法 为每位玩家随机分配角色 并把角色属性赋值给玩家
        {
           
            var availableCharacters = Character.characterList.Skip(1).ToList(); //跳过第0个空角色，获取可用角色列表为availableCharacters
            Random random = new Random();
            List<Character> shuffledCharacters = availableCharacters.OrderBy(c => random.Next()).ToList();// 使用 OrderBy(Guid.NewGuid()) 或 OrderBy(random.Next()) 进行随机打乱  
            for (int j = 0; j < playerNum; j++)
            {
                Console.WriteLine("正在为" + playerList[j] + "分配角色");
                Player currentPlayer = players[j];
                Character pickedCharacter = shuffledCharacters[j];              //再将随即打乱的角色按顺序分给玩家
                currentPlayer.characterName = pickedCharacter.characterName;     
                currentPlayer.dvplPower = pickedCharacter.dvplPower;
                currentPlayer.ideoPower = pickedCharacter.ideoPower;
                currentPlayer.ecoPower = pickedCharacter.ecoPower;
                currentPlayer.warStatus = pickedCharacter.warStatus;
                currentPlayer.ideology = pickedCharacter.ideology;
                currentPlayer.dvlpStatus = pickedCharacter.dvlpStatus;

                Console.WriteLine(playerList[j] + "分配到的角色是: " + pickedCharacter.characterName + " (发展力: " + pickedCharacter.dvplPower + ", 意识形态力: " + pickedCharacter.ideoPower + ", 经济力: " + pickedCharacter.ecoPower + ", 战争状态: " + pickedCharacter.warStatus + ")");


            }
           
        }


        public void SelectCharacter(string[] playerList, List<Player> players) //桌游模式方法 玩家选择角色
        {
            Console.WriteLine("玩家选择角色中");
            for (int i = 0; i < playerNum; i++)
            {
                Console.WriteLine("player " + (i + 1) + " 请选择你的角色（输入数字编号）：");
                
                int choice = int.Parse(Console.ReadLine());
                Character pickedCharacter = Character.characterList[choice];
                Player currentPlayer = players[i];
                currentPlayer.characterName = pickedCharacter.characterName;       
                currentPlayer.dvplPower = pickedCharacter.dvplPower;
                currentPlayer.ideoPower = pickedCharacter.ideoPower;
                currentPlayer.ecoPower = pickedCharacter.ecoPower;
                currentPlayer.warStatus = pickedCharacter.warStatus;
                currentPlayer.ideology = pickedCharacter.ideology;
                currentPlayer.dvlpStatus = pickedCharacter.dvlpStatus;

                Console.WriteLine("player " + (i + 1) + " 选择了角色: " + pickedCharacter.characterName);
            }
        }

        public int PlayIssueCard( List<Player> players)
        {
            Console.WriteLine("Choose an issue card to play:");
            int cardChoice = int.Parse(Console.ReadLine());
            issueCard currentIssue = Card.issueCards[cardChoice];
            Console.WriteLine("提出议题：" + currentIssue.issueName + "     内容为：" + currentIssue.issueNote);
            return cardChoice ;
        }
        public void ApplyIssueEffect(int cardChoice, List<Player> players)
        {
            issueCard currentIssue = Card.issueCards[cardChoice];
            foreach (var player in players)
            {
                // 根据玩家的意识形态应用卡牌效果
                player.ideoPower += currentIssue.ideoEffect[player.ideology];
                // 根据玩家的发展状态应用卡牌效果
                player.ecoPower += currentIssue.dvlpEffect[player.dvlpStatus];
                // 根据玩家的战争状态应用卡牌效果
                player.warStatus += currentIssue.warEffect[player.warStatus];

            }
        }
       




        public int GetPoint()
        {
            


            pointPool = pointPool - givePoint;

            return pointPool;
        }



    }
}
