using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Piece
    {
        private Player player;
        private Boolean knighted;

        public Piece(Player player)
        {
            this.player = player;
        }

        public void knightPiece()
        {
            this.knighted = true;
        }

        public Boolean isKnighted()
        {
            return this.knighted;
        }
        public Player getPlayer()
        {
            return this.player;
        }

        

    }
}
