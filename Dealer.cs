using System;

namespace HiLo
{
    
    public class Dealer
    {
        public int _userPoints = 300;
        public string _userPlay = "Y";


        public void DisplayInformation()
        {
            Console.WriteLine($"{_userPoints}, {_userPlay}");

        }




    }
}