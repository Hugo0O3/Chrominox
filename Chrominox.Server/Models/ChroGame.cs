namespace Chrominox.Server.Models
{
    public class ChroGame
    {
        public List<Player> Players { get; }
        public Player currentPLayer { get; private set; }
        public ChroMosaic mosaic { get; }
        public ChroBag bag { get; }
        public Chrominox? pickedChromino { get; private set; }
        public bool HasPicked { get; private set; }
        public Gamemode mode { get; }
        public Player? playerEnded { get; private set; }

        public ChroGame(List<Player> players, ChroBag bag, ChroMosaic mosaic, GameMode mode, int firstPlayerIndex)
        {
            Players = players;
            Bag = bag;
            Mosaic = mosaic;
            Mode = mode;
            CurrentPlayer = players[firstPlayerIndex];
            FillStartHands();
        }
    }
}
