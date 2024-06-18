using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace chesslogic
{
    public class Board
    {
        private readonly Piece[,] pieces = new Piece[8, 8];
        
        public Piece this[int row , int col]
        {
            get { return pieces[row, col]; }
            set { pieces[row, col] = value; }
        }
        public Piece this[Position pos]
        {
            get { return pieces[pos.Row,pos.Column]; }
            set { this[pos.Row, pos.Column] = value; }
        }
        public static Board Initial()
        {
            Board board = new Board();
            board.AddStartPieces();
            return board;
        }
        private void AddStartPieces()
        {
            this[0, 0] = new Rook(Player.Black);
            this[0, 1] = new knight(Player.Black);
            this[0, 2] = new Bishop(Player.Black);
            this[0, 3] = new Queen(Player.Black);
            this[0, 4] = new king(Player.Black);
            this[0, 5] = new Bishop(Player.Black);
            this[0, 6] = new knight(Player.Black);
            this[0, 7] = new Rook(Player.Black);


            this[7, 0] = new Rook(Player.white);
            this[7, 1] = new knight(Player.white);
            this[7, 2] = new Bishop(Player.white);
            this[7, 3] = new Queen(Player.white);
            this[7, 4] = new king(Player.white);
            this[7, 5] = new Bishop(Player.white);
            this[7, 6] = new knight(Player.white);
            this[7, 7] = new Rook(Player.white);
            for (int i = 0; i < 8; i++)
            {
                this[1, i] = new Pawn(Player.Black);
                this[6, i] = new Pawn(Player.white);
            }
        }
        public static bool IsInside(Position pos)
        {
            return pos.Row >= 0 && pos.Row <8 && pos.Column >= 0 && pos.Column < 8;
        }
        public bool IsEmpty(Position pos)
        {
            return this[pos] == null;
        }
    }
}
