namespace DeckOfCards
{

    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card(string sut, string sVal, int iVal)
        {
            stringVal = sVal;
            suit = sut;
            val = iVal;
        }



        public string ToString()
        {
            return suit + " " + stringVal + " ";
        }

    
    }
}