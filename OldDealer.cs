using System;

namespace HiLo
{
    
    public class OldDealer
    {
        

        int _currentNumber = new Random().Next(1,14);
        int _nextNumber = new Random().Next(1,14);
        int _userPoints = 300;
        string _userAnswer = "Y";



        public void DisplayInformation()
        {
            Console.WriteLine($"Your current score is: {_userPoints}");
            

            while ((_userPoints != 0) && (_userAnswer != "n"))
            {
                Console.WriteLine($"The card is: {_currentNumber}");

                Console.Write($"Higher or lower? [h/l]: ");
                var highOrLow = (Console.ReadLine());
                var upperHighOrLow = highOrLow.ToUpper();



                if (highOrLow == "h")
                {
                    if (_currentNumber < _nextNumber)
                    {
                        Console.WriteLine($"Next card was: {_nextNumber}");
                        _userPoints += 100;
                        
                    }
                    else
                    {
                        Console.WriteLine($"Next card was: {_nextNumber}");
                        _userPoints -= 75;
                    }
                   


                }
                else
                {
                    if (_currentNumber > _nextNumber)
                    {
                        Console.WriteLine($"Next card was: {_nextNumber}");
                        _userPoints += 100;
                        
                    }
                    else
                    {
                        Console.WriteLine($"Next card was: {_nextNumber}");
                        _userPoints -=75;
                    }

                }
                Console.WriteLine($"Your score is:  {_userPoints}");

                Console.WriteLine($"Play again? [y/n] ");
                _userAnswer  = Console.ReadLine();


            }

        }


    




    }
}