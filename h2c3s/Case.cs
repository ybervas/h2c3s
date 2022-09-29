using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2c3s
{
    internal abstract class Case
    {
        public Point Position { get; set; }
        protected readonly Size SIZE = new Size(10, 10);
        protected List<Pawn> Pawns { get; set; } = new List<Pawn>();
        
        public Case(int x, int y)
        {
            Position = new Point(x, y);
        }

        /// <summary>
        /// Permet de d'affecter un pion à une case
        /// </summary>
        /// <param name="p"> Le pion à affecter </param>
        public void AddPawn(Pawn p)
        {
            this.Pawns.Add(p);
        }

        /// <summary>
        /// Permet de connaître la taille d'une case
        /// </summary>
        /// <returns> Size </returns>
        public Size GetCaseSize()
        {
            return SIZE;
        }

        public abstract void Dessiner(Graphics g);
    }
}
