using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5_Latest
{

    /**
     * <summary>
     * This class creates an object that represents a playing card
     * </summary>
     * @class Card
     */
    public class Card
    {
        //Public property*********************************************************

        public Faces Face { get; set; }//Face type
        public Suits Suit { get; set; }//Suit type Deck class has been updated

        /**
         * <summary>
         * This construcctor takes Card parameters : fase and suit to instance
         * </summary>
         * 
         * @constructor Card
         * @param {Faces} face
         * @param {Suits} suit
         */
        //Constructor**************************************************************
        public Card(Faces face, Suits suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
