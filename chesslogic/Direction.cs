namespace chesslogic
{
    public class Direction
    {
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction Southwest = South + West;




        public int RowDelta { get; }
        public int ColumnDelta { get; }
        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }
        public static Direction operator +(Direction dirl, Direction dir2) 
        { 
            return new Direction (dirl.RowDelta + dir2.RowDelta, dirl.ColumnDelta + dir2.ColumnDelta); 
        }
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction (scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }
        public static Position operator +(Position pos , Direction dir)
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
