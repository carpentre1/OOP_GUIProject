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

        public Card(string _suit, string _value)
        {
            suit = _suit;
            value = _value;
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

        public void Build()
        {
            
        }
        public void Shuffle()
        {

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
            Form1.labelPlayerScore.text = player.score.ToString();
        }
    }
}
