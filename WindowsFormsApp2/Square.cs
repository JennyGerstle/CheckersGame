using System;

public class Class1
{
	public Class1()
	{
		private const Location location;
		private Piece piece;

		public Square(Location location)
        {
			this.location = location;
			this.piece = null;
        }

		public Square(Location, location, Piece piece)
		{
			this.location = location;
			this.piece = piece;
		}

		public void movePiece(Square newSquare)
        {
			newSquare.givePiece(this.piece);
			this.piece = null;
			
        }

		public givePiece(Piece piece)
        {
			this.piece = piece;
        }

		public boolean isEmpty()
		{
			return this.piece == null; 
		}
	}

}
