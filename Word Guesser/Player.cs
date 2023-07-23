using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guesser
{
    internal class Player
    {
        private String name;
        private int points = 0;
        private int position;
        private String? guess;
        private String color;

        public Player(String name, String color) 
        {
           this.name = name;
           this.color = color;
        }

        //GETTERS AND SETTERS PAST HERE

        public String GetName()
        { 
            return name; 
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public int GetPoints() 
        {
            return points; 
        }

        public void SetPoints(int points)
        {
            this.points = points;
        }

        public int GetPosition() 
        { 
            return position; 
        }

        public void SetPosition(int position)
        {
            this.position = position;
        }

        public String GetGuess() 
        {
            return guess; 
        }

        public void SetGuess(String guess)
        {
            this.guess = guess;
        }

        public String GetColor() 
        { 
            return color; 
        }

        public void SetColor(String color)
        {
            this.color = color;
        }
    }
}
