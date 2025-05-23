namespace Chrominox.Server.Models
{
    public class Chromino
    {
        private TileType part1;
        private TileType part2;
        private TileType part3;
        private Coordinate position;
        private Orientation rotation;

        public Chromino(TileType part1, TileType part2, TileType part3)
        {
            this(part1, part2, part3);
        }
    }
}
