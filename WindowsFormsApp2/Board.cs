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
         
   //     public Square moveComputerPiece(Square originSquare)
       // {
            //gets the best move for the computer using alpha beta
     //   }

        public void moveUserPiece(Board board, Square[,] squares, Square destinationSquare, Square originSquare)
        {
            const int SQUARE_SIZE = 50;
            double originXCoord = originSquare.getLocation().getX();
            double originYCoord = originSquare.getLocation().getY();
            int row = 1;
            int col = 1;
            for (int square = 0; square < 8; square++)
            {
                if (originXCoord > SQUARE_SIZE)
                {
                    originXCoord -= SQUARE_SIZE;
                    ++row;
                }
                if (originYCoord > SQUARE_SIZE)
                {
                    originYCoord -= SQUARE_SIZE;
                    ++col;
                }
            }
            double destinXCoord = destinationSquare.getLocation().getX();
            double destinYCoord = destinationSquare.getLocation().getY();
            int destinationRow = 1;
            int destinationCol = 1;
            for (int square = 0; square < 8; square++)
            {
                if (destinXCoord > SQUARE_SIZE)
                {
                    destinXCoord -= SQUARE_SIZE;
                    ++destinationRow;
                }
                if (destinYCoord > SQUARE_SIZE)
                {
                    destinYCoord -= SQUARE_SIZE;
                    ++destinationCol;
                }
            }
            if (board.isLegal(destinationSquare, originSquare))
            {
                Piece pieceToBeMoved = originSquare.getPiece();
                originSquare.setPiece(null);
                destinationSquare.setPiece(pieceToBeMoved);
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
