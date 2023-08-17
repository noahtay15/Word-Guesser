using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guesser
{
    public class Player
    {
        private String name;
        private int points = 0;
        private int position;
        private String? guess;
        Color playerColor;

        public Player(String name, Color playerColor) 
        {
           this.name = name;
            this.playerColor = playerColor;
        }

        //GETTERS AND SETTERS PAST HERE

        public String getName()
        { 
            return name; 
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getPoints() 
        {
            return points; 
        }

        public void addPoints(int points)
        {
            this.points += points;
        }

        public int getPosition() 
        { 
            return position; 
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public String getGuess() 
        {
            return guess; 
        }

        public void setGuess(String guess)
        {
            this.guess = guess;
        }

        public Color getPlayerColor()
        {
            return playerColor;
        }

        public void setPlayerColor(Color playerColor)
        {
            this.playerColor = playerColor;
        }
    }
}
