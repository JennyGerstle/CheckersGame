using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Player
    {
        private String color;
        private Boolean user;

        public Player(String color, Boolean user)
        {
            this.color = color;
            this.user = user;
        }

        public String getColor()
        {
            return this.color;
        }

        public Boolean isUser()
        {
            return user;
        }
    }
    //user always on bottom. add if player is user or computer
}
