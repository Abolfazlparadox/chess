namespace chesslogic
{
    public class knight : Piece
    {
        //اسب
        public override PieceType Type => PieceType.Knight;
        public override Player Color { get; }
        public knight(Player color)
        {
            Color = color;
        }
        public override Piece Copy()
        {
            knight copy = new knight(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
        private static IEnumerable<Position> PotentialToMoves(Position from)
        {
            foreach(Direction vDir in new Direction[] {Direction.North,Direction.South})
            {
                foreach (Direction hDir in new Direction[] {Direction.West,Direction.East})
                {
                    yield return from + 2 * vDir + hDir;
                    yield return from + 2 * hDir + vDir;


                }
            }
        }
        private IEnumerable<Position> MovePositions(Position from, Board board)
        {
            return PotentialToMoves(from).Where(pos => Board.IsInside(pos) && (board.IsEmpty(pos) || board[pos].Color != Color));

        }
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositions(from, board).Select(to => new NormalMove(from, to));
        }
    }
}
