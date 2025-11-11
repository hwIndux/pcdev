using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
    
{
    using static Character;



    public class Card
    {
        
        
        public int cardId;
        
        //Card card = new Card();
        public static List<issueCard> issueCards = new List<issueCard>()
        {
            new issueCard() {cardId = 0, issueName = "null", issueNote = "null", ideoEffect = new int[5]{0,0,0,0,0}, dvlpEffect = new int[3]{0,0,0}, warEffect = new int[2]{0, 0}},
            new issueCard() {cardId = 1, issueName = "反垄断法案", issueNote = "限制大企业垄断市场，促进经济公平发展", ideoEffect = new int[5]{-1, 1, 1, 0, 0}, dvlpEffect = new int[3]{-1, 1, 2}, warEffect = new int[]{0, 0} },
        };



        public void BuildCard()
        {

        }

    }
    
    public class issueCard : Card
    {
        public string issueName;
        public string issueNote;
        public int[] ideoEffect = new int[5];//对应五种意识形态的影响力加成
        public int[] dvlpEffect = new int[3];//对应三种发展状态的影响力加成 
        public int[] warEffect;//战争状态影响加成
        public issueCard()
        {

        }
    }
}
