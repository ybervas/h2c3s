using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2c3s
{
    internal class NormalCase : Case
    {
        public NormalCase(int x, int y) : base(x, y) {}

        public override void Dessiner(Graphics g)
        {
            Rectangle r = new Rectangle(Position, SIZE);
            g.DrawRectangle(Pens.Black, r);
        }
    }
}
