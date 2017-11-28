using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Deck objDeck = new Deck();
        }

        public void UpdateScore(Player player, Dealer dealer)
        {
            labelPlayerScore.Text = player.score.ToString();
        }

        public void UpdateText(Participant buddy, string phrase)
        {

        }

        private void buttonHit_Click(object sender, EventArgs e)//player hits, drawing a card
        {

        }

        private void buttonStand_Click(object sender, EventArgs e)//player stands, drawing no more
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)//acknowledge info after standing
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)//begin the game
        {

        }//sub classes, interfaces, etc count for the 6 classes
        //final: output different ice cream cones using a provided UML
    }
    public class Card
    {
        public string suit = "none";//clubs, spades, diamonds, hearts
        public string value = "none";//ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
        int intValue = 0;


        public Card(int _intValue, string _suit)
        {
            suit = _suit;
            intValue = _intValue;
            switch (intValue)
            {
                case 1: { value = "ace"; return; }
                case 2: { value = "two"; return; }
                case 3: { value = "three"; return; }
                case 4: { value = "four"; return; }
                case 5: { value = "five"; return; }
                case 6: { value = "six"; return; }
                case 7: { value = "seven"; return; }
                case 8: {value = "eight"; return; }
                case 9: {value = "nine"; return; }
                case 10: {value = "ten"; return; }
                case 11: {value = "jack"; return; }
                case 12: {value = "queen"; return; }
                case 13: {value = "king"; return; }
                default: return;
            }
        }

        public string CardName()
        {
            return value + " of " + suit;
        }

        public int Value()
        {
            switch (value)
            {
                case "ace": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                case "ten": return 10;
                case "jack": return 11;
                case "queen": return 12;
                case "king": return 13;
                default: return 0;
            }
        }
    }
    public class Deck
    {
        List<Card> colDeck;
        private Random rng;

        public Deck()
        {
            colDeck = new List<Card>();
            this.rng = new Random();
        }

        public void AddCard(Card c)
        {
            colDeck.Add(c);
        }
        public List<Card> ReturnDeck()
        {
            return colDeck;
        }
        public void SetDeck(List<Card> col)
        {
            colDeck = col;
        }
        public void Build()
        {
            List<Card> CardList = new List<Card>();//add every card made to this list to keep track

            //string fullList = "";//add the name of every card to this string to spit them all out at once

            int numCards = 52;//total number of cards to create
            int curCard = 13;//the value that will be assigned to each card as it's created
            int curDeck = 4;//the deck to assign each card to as it's created

            string[] Decks = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
            while (numCards > 0)
            {
                Card newCard = new Card(curCard, Decks[curDeck]);
                //Console.WriteLine("Created " + newCard.name + ".");
                //CardList.Add(newCard); fullList += newCard.name + ", ";
                numCards -= 1;
                curCard -= 1;
                if (curCard == 0)
                {
                    curCard = 13;//start doing the next deck, starting with card #13 in that deck
                    curDeck -= 1;
                }
            }
        }
        public List<Card> Shuffle()
        {
            int n = colDeck.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = colDeck[k];
                colDeck[k] = colDeck[n];
                colDeck[n] = value;
            }
            return colDeck;
        }
        public Card GetCard(int index)
        {
            return colDeck[index];
        }
    }
    public abstract class Participant
    {
        public int score;
        public void CalculateScore(int amount)
        {
            score += amount;
        }

        public bool HasGoneOver()
        {
            if (score > 21)
            {
                return true;
            }
            else return false;
        }
    }
    public class Player : Participant
    {

    }
    public class Dealer : Participant
    {
        public bool ShouldStand()
        {
            if(score < 17)
            {
                return false;
            }
            return true;
        }
    }
    public class UICommands
    {
        int wins = 0;
        int losses = 0;
        public void UpdateAll(Player player)
        {
            //Form1.labelPlayerScore.text = player.score.ToString();
        }
    }
}
