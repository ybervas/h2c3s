using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2c3s
{
    internal class Player
    {
        public Color color { get; set; }
        public int countMovement { get; set; }
        public string name{ get; set; }
        public List<Token> tokens { get; } = new List<Token>(); //token water / energy
        public List<Card> handCards { get; } = new List<Card>() ; //liste de carte du joueur
        public List<Pawn> pawns { get; } = new List<Pawn>(); //max 10 pions / joueurs
        
        public Player(Color c, String n)
        {
            this.color = c;
            this.name = n;
            this.countMovement = 7;
            InitToken();
            InitPawns();
        }

        private void InitToken()
        {
            for (int i =0; i <10; i++)
            {
                tokens.Add(new Token()); // token water
                tokens.Add(new Token()); //token energy
            }
        }

        private void InitPawns()
        {
            for(int i =0; i <2; i++)
            {
                pawns.Add(new Pawn(this, Board.START_CASE)); // pion joueur
            }
        }

        /**
         * Permet d'ajouter un pion à la liste si il a pas atteint le quota
         */
        public void addPawn()
        {
            if (pawns.Count < 10)
            {
                pawns.Add(new Pawn(this));
            }
        }

        public void movePawn(Pawn p, Case c)
        {
            //check que le pion que l'on souhaite bouger appartient bien au joueur courant
            if (p.player.Equals(this)) {
                p.currentCase = c;
                this.countMovement--;
            }
            
        }

        /**
         * "Fin tour : Joueur peut choisir placer compteur à 0 et récupérer autant jetons énergie que le compteur indiquait avant"
         */
        public void chooseGetEnergyAtEndTurn()
        {
            for(int i =0; i<this.countMovement; i++)
            {
                tokens.Add(new Token()); //energy token
            }
            this.countMovement = 0;
        }


    }
}

