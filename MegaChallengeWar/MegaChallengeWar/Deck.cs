using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace MegaChallengeWar
{
    public class Deck
    {
        private List<Card> _deck = new List<Card>();
        private Random _random = new Random();
        StringBuilder _sb = new StringBuilder();
    
        public Deck()
        {
         
            string[] suits = new string[]{ "Diamonds", "Hearts", "Spades", "Clubs" };
            string[] kinds = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach(var kind in kinds)
                { 
                
                    _deck.Add(new Card() { Suit = suit, CardName = kind });
                }
            }

        }

        public string Deal(Player player1, Player player2)
        {
            while(_deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);
            }
            return _sb.ToString();
         }

        private void dealCard(Player player)
        {
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            _sb.Append("<br/>");
            _sb.Append(player.PlayerName);
            _sb.Append(" is dealt the ");
            _sb.Append(card.CardName);
            _sb.Append(" of ");
            _sb.Append(card.Suit);
        }
    }
}