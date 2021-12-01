using System;

namespace WindowsFormsApp2
{
    class Square
    {
        private readonly Location location;
        private Piece piece;

        public Square(Location location)
        {
            this.location = location;
            this.piece = null;
        }

        public Square(Location location, Piece piece)
        {
            this.location = location;
            this.piece = piece;
        }
        public Location getLocation()
        {
            return this.location;
        }
        public Piece getPiece()
        {
            return this.piece;
        }
        public void movePiece(Square newSquare)
        {
            newSquare.givePiece(this.piece);
            this.piece = null;

        }

        public void givePiece(Piece piece)
        {
            this.piece = piece;
        }

        public bool isEmpty()
        {
            return this.piece == null;
        }
    }
}

