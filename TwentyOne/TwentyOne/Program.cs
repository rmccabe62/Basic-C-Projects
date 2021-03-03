using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPLayers();
            Console.ReadLine();

            deck deck = new deck();
            deck.shuffle(3);

            foreach (card card in deck.cards)
            {
                console.writeline(card.face + " of " + card.suit);
            }
            console.writeline(deck.cards.count);
            console.readline();
        }


    }
        
}


        
