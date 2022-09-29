using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2c3s
{
    internal class Pawn
    {
        private const int MIN_PAWNS_BY_PLAYER = 0;
        private const int MAX_PAWNS_BY_PLAYER = 10;
        private static Size PAWN_RADIUS = new Size(5, 5);

        public Player player { get; set; }
        public Case currentCase { get; set; }

        public Pawn(Player player, Case position)
        {
            this.player = player;
            this.currentCase = position;
        }

        public Pawn(Player player) : this(player, null) {}

        public void Dessiner(Graphics g)
        {
            if (currentCase != null)
            {
                Rectangle r = new Rectangle(currentCase.Position, currentCase.GetCaseSize());
                Pen p = new Pen(player.color);
                g.DrawEllipse(p, r);
            }
        }
    }
}
