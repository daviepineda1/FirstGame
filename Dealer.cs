using System;

namespace HiLo
{
    
    public class Dealer
    {
        public int _userPoints = 300;
        public string _userPlay = "Y";

        Random _rand = new Random();
        List<int> _cardNumbers = new List<int>();



        public void DisplayInformation()
        {
            Console.WriteLine($"{_userPoints}, {_userPlay}");

        }




    }
}