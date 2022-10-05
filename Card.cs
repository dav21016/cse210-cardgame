using System;

namespace MyApplication
{
    class Card
    {
        public int cardValue;
        public void getNewCard(){
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
    }
}