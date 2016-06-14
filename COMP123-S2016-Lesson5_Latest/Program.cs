using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * This is driver class
 * Author :Chinatsu Kawakami
 * Student ID : 300821245
 * Date : 9th June 2016
 * Modified Date : 13th June 2016
 * version 0.0.1 - Added Suits and Faces enums
 *
 */
namespace COMP123_S2016_Lesson5_Latest
{
    class Program
    {
        /**
        * The main method for our driver class program
         * 
        * @method Main
        * @params {string[]} args
        * @returns {void}
        */
        static void Main(string[] args)
        {

            //List that represents deck of cards
            Deck deck = new Deck();
            deck.Display();//display the initial state of the deck

            deck.Shuffle();//shuffle the deck
            deck.Display();//dispay the deck of shuffled
            Console.WriteLine();

            Card cardDealt = deck.Deal();

            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.Face, cardDealt.Suit);

            Console.WriteLine();
            deck.Display();

        }//close Main


    }//close Program
}//close nameSpace

