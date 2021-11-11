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
    public playerOrComputerPlacement(int BoardSize)
    {
        for (int row = 0; row < 9; row++)
        {
            if (row % 2 == 0)
            {
                if (Player.Equals(this.Player.isUser()))
                {
                   squares.add(row < (BoardSize / 2) - 1);
                }
                else
                {
                    squares.add(row > (BoardSize / 2) - 1);
                }
            }
            else
            {
                if (Player.Equals(this.Player.isUser()))
                {
                    squares.add(row > (BoardSize / 2) - 1);
                }
                else
                {
                    squares.add(row < (BoardSize / 2) - 1);
                }
            }
        }
    }
}
