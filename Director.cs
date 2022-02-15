using System;


namespace HiLo
{
    public class Director
    {
        private Dealer _newDealer =  new Dealer();
        private string _guess = "";
        private int _score = 300;
        private bool isPlaying = true;

        // public Director()
        // {

        // }


        private void DoUpdates()
        {   

            _newDealer.DisplayCard(true);

            DoInputs();

            _newDealer.DealCard();
            _newDealer.DisplayCard(false);


            if (_newDealer.CheckUserGuess(_guess))
            {
                _score += 100;
            }
            else
            {
                _score -= 75;
            }

            DoOutputs();


            if(_score <=0 )
            {
                isPlaying = false;
                return;
            }

            Console.Write("Play again? [y/n]");
            if (Console.ReadLine().ToLower() == "n")
            {
                isPlaying = false;
            }
           
            

        }

        private void DoInputs()
        {
            Console.Write("Higher or Lower? [h/l ]");
            _guess = Console.ReadLine();

        }

        private void DoOutputs()
        {
            Console.WriteLine($"Your score is: {_score}");
        }

        
        public void StartGame()
        {
            _newDealer.DealCard();
            while (isPlaying)
            {
                DoUpdates();
            }
        }

    }










}