using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_POO_CMaggi
{
    class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard Captain;
        public Player(int LP, int AP, Deck D, Hand H, Board B, SpecialCard SC)
        {
        int lifePoints = LP;
        int attackPoints = AP;
        Deck deck = D;
        Hand hand = H;
        Board board = B;
        SpecialCard Captain = SC;
        }

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int Attackpoints { get => attackPoints; set => attackPoints = value; }

        public Deck Deck { get => deck; set => deck = value; }
        public Hand Hand { get => hand; set => hand = value; }


        public void DrawCard()
        {

        }
        public void PlayCard(int cardId)
        {

        }
        public void ChangeCard(int cardId)
        {

        }
        public void FirstHand()
        {

        }
        public void ChooseCaptainCard(SpecialCard captainCard)
        {


        }

    }


}
