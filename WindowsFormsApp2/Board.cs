using System;

public class Class1
{
	public Class1()
	{
	//alpha beta - pass board into this
    //heuristic function to evaluate pos


		public Boolean isLegal(Square destinationSquare, Square originSquare)
        {
            double xCoord = newLocation.location.getX();
            double yCoord = newLocation.location.getY();

            if (destinationSquare.isEmpty() && xCoord >= 1 && xCoord <= 400 && yCoord >= 1 && yCoord <= 400) //goes by pixels
            {  
               if (!originSquare.piece.isKnighted())
                {
                    if (originSquare.piece.player.isUser())
                    {
                        if (!destinationSquare.location.compareTo(originSquare.location) > 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!destinationSquare.location.compareTo(originSquare.location) < 0)
                        {
                            return false;

                        }
                    }
                }
		        
            }
            else
            {
				return false;
            }
        }

        public Square moveComputerPiece(Square originSquare)
        {
            //gets the best move for the computer using alpha beta
        }

        public void moveUserPiece(Square originSquare, Square DestinationSquare)
        {
            originSquare.movePiece(DestinationSquare);
        }


	}
}
