using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGUI//by Justin Carpenter
//card images pulled from wikipedia; the images are under a GNU lesser general public license, allowing free usage
{
    public partial class Form1 : Form
    {

        List<Participant> participants = new List<Participant>();
        List<Deck> decks = new List<Deck>();
        bool sessionOver = false;

        public Form1()
        {
            InitializeComponent();
            DisableButtons();
            BackColor = Color.Green;
            buttonContinue.Visible = false;
            ClearText();
        }

        public void UpdateScore(Participant participant, int value)
        {
            participant.score += value;
            if (participant is Dealer)
            {
                labelDealerScore.Text = participant.score.ToString();

            }
            else
            {
                labelPlayerScore.Text = participant.score.ToString();
            }
        }

        public void UpdateText(Participant participant, Card card)
        {
            if(participant is Dealer)
            {
                labelDrawnCardDealer.Text = "The dealer drew " + card.value + " of " + card.suit + ".";
            }
            else
            {
                labelDrawnCardPlayer.Text = "You drew " + card.value + " of " + card.suit + ".";
            }
        }
        public void UpdateWins(bool won)//keep track of how many times the player has won and lost
        {
            if(sessionOver)//when multiple possible win states are checked, don't let the player get excess wins/losses for meeting several of the conditions in a single session
            {
                return;
            }
            if(won)
            {
                Statistics.wins++;
            }
            else
            {
                Statistics.losses++;
            }
            labelWins.Text = Statistics.wins.ToString();
            labelLosses.Text = Statistics.losses.ToString();
            sessionOver = true;
        }
        public void CheckWin(Participant participant)//checks for a win involving someone hitting 21 or going over
        {
            if(participant.score == 21)
            {
                if(participant is Dealer)//check dealer first since the player always loses if the dealer hits 21
                {
                    labelResultDealer.ForeColor = Color.Red;
                    labelResultDealer.Text = "The dealer won by hitting 21.";
                    UpdateWins(false);
                    DisableButtons();//prevent hitting or standing since the game is over
                    return;
                }
                else if(participant is Player)
                {
                    labelResultPlayer.ForeColor = Color.LightSkyBlue;
                    labelResultPlayer.Text = "You won by hitting 21!";
                    UpdateWins(true);
                    DisableButtons();
                    return;
                }
            }
            else if(participant.score > 21)
            {
                if(participant is Player)//check the player first; they always lose if they go over
                {
                    labelResultPlayer.ForeColor = Color.Red;
                    labelResultPlayer.Text = "You lost by going over 21.";
                    UpdateWins(false);
                    DisableButtons();
                    return;
                }
                else if(participant is Dealer)
                {
                    labelResultDealer.ForeColor = Color.LightSkyBlue;
                    labelResultDealer.Text = "The dealer lost by going over 21!";
                    UpdateWins(true);
                    DisableButtons();
                    return;
                }
            }
        }
        public void CheckStandingWin(Player player, Dealer dealer)//checks for win conditions when the player has stood
        {
            if (dealer.score > 21)
            {
                labelResultDealer.ForeColor = Color.LightSkyBlue;
                labelResultDealer.Text = "The dealer lost by going over 21!";
                UpdateWins(true);
                Statistics.wins++;
                DisableButtons();
                return;
            }
            else if (dealer.score < player.score && dealer.stood)
            {
                labelResultPlayer.ForeColor = Color.Green;
                labelResultPlayer.Text = "You won by having a higher score!";
                UpdateWins(true);
                DisableButtons();
                return;
            }
            else if (player.score < dealer.score)
            {
                labelResultDealer.ForeColor = Color.Red;
                labelResultDealer.Text = "The dealer won by having a higher score.";
                UpdateWins(false);
                DisableButtons();
                return;
            }
            else if (player.score == dealer.score)
            {
                labelResultPlayer.ForeColor = Color.Red;
                labelResultPlayer.Text = "You lost by not beating the dealer's score.";
                UpdateWins(false);
                DisableButtons();
                return;
            }
        }
        public void DisableButtons()//disables the stand and hit buttons to make it more obvious the current session has ended
        {
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
            buttonContinue.Visible = false;
        }
        public void EnableButtons()
        {
            buttonHit.Enabled = true;
            buttonStand.Enabled = true;
        }
        public void ClearText()//clears out each label to get ready for a new session
        {
            labelDrawnCardDealer.Text = "";
            labelDealerScore.Text = "0";
            labelResultDealer.Text = "";

            labelDrawnCardPlayer.Text = "";
            labelPlayerScore.Text = "0";
            labelResultPlayer.Text = "";

            labelInitialDraws.Text = "";
        }



    private void buttonHit_Click(object sender, EventArgs e)//player hits, drawing a card
        {
            foreach(Participant participant in participants)
            {
                foreach(Deck deck in decks)
                {
                    if(participant is Player)
                    {
                        Random rand = new Random();
                        int randomCard = rand.Next(0, 52);
                        Card drawnCard = deck.GetCard(randomCard);
                        object O = Properties.Resources.ResourceManager.GetObject(drawnCard.imageName);
                        pictureBoxNewCard.Image = (Image)O;
                        pictureBoxNewCard.Visible = true;
                        UpdateScore(participant, drawnCard.intValue);
                        UpdateText(participant, drawnCard);
                        CheckWin(participant);
                        return;
                    }
                }
            }
        }

        private void buttonStand_Click(object sender, EventArgs e)//player stands, drawing no more cards and must now watch the dealer draw cards to see who will win
        {
            Player player = null;
            Dealer dealer = null;
            foreach (Participant participant in participants)
            {
                foreach (Deck deck in decks)
                {
                    if (participant is Player)
                    {
                        player = (Player)participant;
                        participant.stood = true;
                        labelDrawnCardPlayer.Text = "You have stood.";
                        DisableButtons();
                        buttonContinue.Visible = true;
                    }
                    if (participant is Dealer)
                        dealer = (Dealer)participant;
                }
            }
            if(dealer.score > player.score)
            {
                CheckStandingWin(player, dealer);
            }
            if(dealer.score > 17 && (dealer.score >= player.score))
            {
                CheckStandingWin(player, dealer);
            }
        }

        private void buttonContinue_Click_1(object sender, EventArgs e)//acknowledge each card the dealer draws. the dealer will try to draw until he reaches at least 17, then stand
        {
            Dealer dealer = null;
            Player player = null;
            foreach (Participant participant in participants)
            {
                foreach (Deck deck in decks)
                {
                    if (participant is Dealer)
                    {
                        dealer = (Dealer)participant;
                        if(dealer.score < 17)
                        {
                            Random rand = new Random();
                            int randomCard = rand.Next(0, 52);
                            Card drawnCard = deck.GetCard(randomCard);
                            object O = Properties.Resources.ResourceManager.GetObject(drawnCard.imageName);
                            pictureBoxNewCard.Image = (Image)O;
                            pictureBoxNewCard.Visible = true;
                            UpdateScore(participant, drawnCard.intValue);
                            UpdateText(participant, drawnCard);
                            CheckWin(participant);
                        }
                        if(dealer.score >= 17)
                        {
                            dealer.stood = true;
                            labelInitialDraws.Text = "The dealer has stood.";
                        }
                    }
                    if (participant is Player)
                    {
                        player = (Player)participant;
                    }
                }

            }
            if(dealer.score >= player.score)
            {
                CheckStandingWin(player, dealer);
            }
            if (dealer.stood)
            {
                CheckStandingWin(player, dealer);
                return;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)//begin the game
        {
            EnableButtons();
            buttonContinue.Visible = false;
            pictureBoxNewCard.Visible = false;
            if (buttonStart.Text == "Start")//if the game is being started for the first time...
            {
                buttonStart.Text = "Restart";
                Player player = new Player();
                player.score = 0;
                Dealer dealer = new Dealer();
                dealer.score = 0;
                ClearText();
                participants.Add(player);
                participants.Add(dealer);
                Deck deck = new Deck();
                decks.Add(deck);
                deck.Build();
                deck.Shuffle();
                InitialDraws(player, dealer, deck);
                CheckWin(player); CheckWin(dealer);
            }
            else//if you're restarting the game, just reset the values
            {
                sessionOver = false;
                Player player = null;
                Dealer dealer = null;
                Deck deck = null;
                foreach(Participant participant in participants)
                {
                    participant.score = 0;
                    if(participant is Player)
                    {
                        player = (Player)participant;//find the player and explicitly cast them
                    }
                    if (participant is Dealer)
                    {
                        dealer = (Dealer)participant;
                    }
                }
                foreach(Deck currentdeck in decks)
                {
                    deck = currentdeck;
                }
                dealer.stood = false;
                ClearText();
                deck.Shuffle();
                InitialDraws(player, dealer, deck);
                CheckWin(dealer); CheckWin(player);
            }
        }
        private void InitialDraws(Participant player, Participant dealer, Deck deck)
        {
            Random rand = new Random();

            int randomCard = rand.Next(0, 52);//draw the first two cards for the dealer
            Card firstDealerCard = deck.GetCard(randomCard);
            randomCard = rand.Next(0, 52);
            Card secondDealerCard = deck.GetCard(randomCard);
            dealer.score += firstDealerCard.intValue + secondDealerCard.intValue;
            labelDealerScore.Text = dealer.score.ToString();

            randomCard = rand.Next(0, 52);//draw the first two cards for the player
            Card firstPlayerCard = deck.GetCard(randomCard);
            randomCard = rand.Next(0, 52);
            Card secondPlayerCard = deck.GetCard(randomCard);
            player.score += firstPlayerCard.intValue + secondPlayerCard.intValue;
            labelPlayerScore.Text = player.score.ToString();

            labelInitialDraws.Text = $"The dealer dealt himself {firstDealerCard.value} of {firstDealerCard.suit} and {secondDealerCard.value} of {secondDealerCard.suit}. \nYou were dealt " +
                $"{firstPlayerCard.value} of {firstPlayerCard.suit} and {secondPlayerCard.value} of {secondPlayerCard.suit}.";
        }
    }
    public class Card
    {
        public string suit = "none";//clubs, spades, diamonds, hearts
        public string value = "none";//ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
        public int intValue = 0;
        public string imageName = "";

        public Card(int _intValue, string _suit)//when constructing a new card, assign its suit and integer value, then determine the string version of its value. use that to create the image name for cards
            //the cards in the resources folder use the naming format of "valuesuit" such as "twoclubs"
        {
            suit = _suit;
            intValue = _intValue;
            switch (intValue)
            {
                case 1: { value = "ace"; imageName = value + suit; return; }
                case 2: { value = "two"; imageName = value + suit; return; }
                case 3: { value = "three"; imageName = value + suit; return; }
                case 4: { value = "four"; imageName = value + suit; return; }
                case 5: { value = "five"; imageName = value + suit; return; }
                case 6: { value = "six"; imageName = value + suit; return; }
                case 7: { value = "seven"; imageName = value + suit; return; }
                case 8: {value = "eight"; imageName = value + suit; return; }
                case 9: {value = "nine"; imageName = value + suit; return; }
                case 10: {value = "ten"; imageName = value + suit; return; }
                case 11: {value = "jack"; imageName = value + suit; return; }
                case 12: {value = "queen"; imageName = value + suit; return; }
                case 13: {value = "king"; imageName = value + suit; return; }
                default: return;
            }
        }

        public string CardName()
        {
            return value + " of " + suit;
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

            int numCards = 52;//total number of cards to create
            int curCard = 13;//the value that will be assigned to each card as it's created
            int curDeck = 4;//the deck to assign each card to as it's created

            string[] Decks = { "", "clubs", "diamonds", "hearts", "spades" };
            while (numCards > 0)
            {
                Card newCard = new Card(curCard, Decks[curDeck]);
                this.AddCard(newCard);
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
        public bool stood = false;
    }
    public class Player : Participant
    {

    }
    public class Dealer : Participant
    {

    }
    public static class Statistics
    {
        public static int wins = 0;
        public static int losses = 0;
    }
}
