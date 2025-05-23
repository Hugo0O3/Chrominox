
namespace Chrominox.Server.Models
{
    public static class TileTypeExtensions
    {
        public static string ToCssColor(this TileType color)
        {
            return color switch
            {
                TileType.Chameleon => "#FFFFFF",
                TileType.Cyan => "#00FFFF",
                TileType.Green => "#00FF00",
                TileType.Magenta => "#FF00FF",
                TileType.Red => "#FF0000",
                TileType.Yellow => "#FFFF00",
                _ => "#000000",
            };
        }
    }
}
