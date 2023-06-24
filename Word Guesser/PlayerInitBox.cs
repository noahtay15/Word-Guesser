using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guesser
{
    internal class PlayerInitBox
    {
        private String title;
        private String color;
        private String position; 

        public PlayerInitBox(string title)
        {
            this.title = title;
        }





        // GETTERS AND SETTERS PAST HERE

        public String GetTitle()
        {
            return title;
        }

        public void SetTitle(String title)
        {
            this.title = title;
        }

        public String GetColor()
        {
            return color;
        }

        public void SetColor(String color)
        {
            this.color = color;
        }

        public String GetPosition()
        {
            return position;
        }

        public void SetPosition(String position)
        {
            this.position = position;
        }

    }
}
