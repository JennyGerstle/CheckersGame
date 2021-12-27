using System;
using System.Collections.Generic;
namespace WindowsFormsApp2
{
	class Board
	{
        public Board()
        {
            List<Square> squares = new List<Square>();
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    //initialize bboard
                }
            }
        }
        //alpha beta - pass board into this
        //heuristic function to evaluate pos

        public Boolean isLegal(Square destinationSquare, Square originSquare)
        {
            double xCoord = destinationSquare.getLocation().getX();
            double yCoord = destinationSquare.getLocation().getY();

            if (destinationSquare.isEmpty() && xCoord >= 1 && xCoord <= 400 && yCoord >= 1 && yCoord <= 400) //goes by pixels
            {  
               if (!originSquare.getPiece().isKnighted())
                {
                    if (originSquare.getPiece().getPlayer().isUser())
                    {
                        if (destinationSquare.getLocation().compareTo(originSquare.getLocation()) > 0)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (destinationSquare.getLocation().compareTo(originSquare.getLocation()) < 0)
                        {
                            return true;

                        }
                    }
                }
		        
            }
            return false;
        }
         
   //     public Square moveComputerPiece(Square originSquare)
       // {
            //gets the best move for the computer using alpha beta
     //   }

        public void moveUserPiece(Square[,] squares, Square destinationSquare, Square originSquare)
        {
            Location originLoc = this.getLoc(originSquare);
            Location destLoc = this.getLoc(destinationSquare);

            if (this.isLegal(destinationSquare, originSquare))
            {
                originSquare.movePiece(destinationSquare);
                squares[(int)originXCoord, (int)originYCoord] = originSquare;
                squares[(int)destinXCoord, (int)destinYCoord] = destinationSquare;
            }
            //
            //remove originPiece fom originLocation in the squares/ board list
            //take original piece move to destination location
            //actually change the squares of the board
            //if destinationsquare isLegal
            //get location of originsquare 
            //delete the originSquare piece
            //put piece in destination piece
        }

        public Square[,] initializeBoardSquares(int BoardSize)
        {
            Square[,] squares = new Square[BoardSize, BoardSize];
            return squares;
        }


        private Location getLoc(Square originSquare)
        {
            const int SQUARE_SIZE = 50;
            double XCoord = originSquare.getLocation().getX();
            double YCoord = originSquare.getLocation().getY();
            Location loca = new Location(1, 1);
            for (int square = 0; square < 8; square++)
            {
                if (XCoord > SQUARE_SIZE)
                {
                    XCoord -= SQUARE_SIZE;
                    loca.incrememtRow();
                }
                if (YCoord > SQUARE_SIZE)
                {
                    YCoord -= SQUARE_SIZE;
                    loca.incrementCol();
                }
            }
            return loca;
        }
        private int getIndex(Square square, Square[,] squares)
        {
            int count = -1;
            if (square.getPiece() != null)
            {
                foreach(Square posibleSquare in squares)
                {
                    if(posibleSquare.Equals(square))
                    {
                        return count;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
