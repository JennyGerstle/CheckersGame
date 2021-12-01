using System;

namespace WindowsFormsApp2
{
	class Board
	{
        //add a map/array of squares with coordinate locations? when piece is moved update the board
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

        public Square moveComputerPiece(Square originSquare)
        {
            //gets the best move for the computer using alpha beta
        }

        public void moveUserPiece(Square originSquare, Square DestinationSquare)
        {
            originSquare.movePiece(DestinationSquare);
            //actually change the squares of the board
        }

        public Square[,] initializeBoardSquares(int BoardSize)
        {
            Square[,] squares = new Square[BoardSize, BoardSize];
            return squares;
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
