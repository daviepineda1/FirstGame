using System;

namespace HiLo
{
    public class Dealer
    {
        private int _card = -1;
        private int _previousCard = 0;


        public void DealCard()
        { 
            // set _previousCard
            if(_card != -1)
            {
                _previousCard = _card;
            }
            // set _card (random)
            Random randomCard = new Random();
            _card = randomCard.Next(1,14);

            
            while (_card == _previousCard)
            {
                System.Console.WriteLine($"This is: {_card}");
                _card = randomCard.Next(1,14);
            }
    
             
        }

        public void DisplayCard(bool isCurrent)
        {
            if (isCurrent)
            {
                System.Console.WriteLine($"The card is: {_card}");
            }
            else
            {
                System.Console.WriteLine($"Next card was: {_card}");
            }
            // Dislays the Card

        }

        public bool CheckUserGuess(string _guess)
        {

            // check if guess was correct 
            if (_guess == "h" || _guess == "H")
            {
                return _card > _previousCard;
            }
            else
            {
                return _card < _previousCard;
            }

        }


    }















}