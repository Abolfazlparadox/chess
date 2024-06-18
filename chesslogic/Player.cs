namespace chesslogic
{
    public enum Player
    {
        None,
        white,
        Black
    }
    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.white => Player.Black,
                Player.Black => Player.white,
                _ => Player.None,
            };
        }
    }
}
