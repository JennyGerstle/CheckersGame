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
        private Location location;

        public Piece(Player player, Location location)
        {
            this.player = player;
            this.location = location;
        }

        public void moveLocation(Location newLocation)
        {
            this.location = newLocation;
        }

    }
}
