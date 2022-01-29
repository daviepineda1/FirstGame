using System;

namespace HiLo
{
    
    public class Dealer
    {
        

        int _randomNumber = new Random().Next(1,14);
        int _nextNumber = new Random().Next(1,14);
        int _userPoints = 300;
        string _userAnswer = "y";



        public void DisplayInformation()
        {
            

            while ((_userPoints != 0) && (_userAnswer != "n"))
            {
                Console.WriteLine($"The card is: {_randomNumber}");

                Console.Write($"Higher or lower? [h/l]: ");
                var highOrLow = (Console.ReadLine());
                var upperHighOrLow = highOrLow.ToUpper();



                if (highOrLow == "H")
                {
                    if (_randomNumber > _nextNumber)
                    {
                        Console.Write($"Next card was: {_nextNumber}");
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
                    if (_randomNumber > _nextNumber)
                    {
                        Console.WriteLine($"Next card was: {_nextNumber}");
                        _userPoints -= 75;
                        
                    }
                    else
                    {
                        Console.WriteLine($"Next card was: {_nextNumber}");
                        _userPoints += 100;
                    }

                }
                Console.WriteLine($"Your score is:  {_userPoints}");

                Console.WriteLine($"Play again? [y/n] ");
                _userAnswer  = Console.ReadLine();


            }

        }


    




    }
}