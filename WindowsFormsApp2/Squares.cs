using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Squares
    {
        //add a map/array of squares with coordinate locations? when piece is moved update the board
        private Player player;
        private Piece piece;
        private int index;
        public Squares(Player player, Piece piece, int index)
        {
            this.player = player;
            this.piece = piece;
            this.index = index;
        }
        public Squares[,] initializeSquaresArrayList(int BoardSize)
        {
            Squares[,] squares = new Squares[BoardSize, BoardSize];
            return squares;
        }
        public int getIndex(Squares squares)
        {
            return Squares.indexOf[squares];

        }
        public Squares[,] initializePlayerPieces(Squares squares)
        {
            foreach (Squares square in squares)
            {
                if (square.getIndex() % 16 >= 9)
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
            return squares;
        }
    }
}
