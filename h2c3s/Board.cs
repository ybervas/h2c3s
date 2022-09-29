using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace h2c3s
{
    internal class Board
    {
        private List<Case> cases = new List<Case>();
        private Player[] players;
        private int numberOfPlayer;
        public static Case START_CASE { get; } = new NormalCase(0, 0);

        public Board(List<Player> p, List<Case> cases)
        {
            if (p.Count > 1 && p.Count < 5)
            {
                numberOfPlayer = p.Count;
                players = new Player[numberOfPlayer];
                for (int i = 0; i < numberOfPlayer; i++)
                {
                    players[i] = p[i];
                }
                this.cases = cases;
                AddCase(START_CASE);
            }
        }

        /// <summary>
        /// Ajoute une case dans le plateau
        /// </summary>
        public void AddCase(Case c)
        {
            cases.Add(c);
        }

        /// <summary>
        /// Affiche toutes les cases du plateau
        /// </summary>
        /// <param name="g">Graphique où on l'affiche</param>
        public void Dessiner(Graphics g)
        {
            foreach (Case c in cases)
            {
                c.Dessiner(g);
            }
        }
    }
}
