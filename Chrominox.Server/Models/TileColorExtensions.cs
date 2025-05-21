
namespace Chrominox.Server.Models
{
    public static class TileColorExtensions
    {
        public static string ToCssColor(this TileColor color)
        {
            return color switch
            {
                TileColor.Chameleon => "#FFFFFF",
                TileColor.Cyan => "#00FFFF",
                TileColor.Green => "#00FF00",
                TileColor.Magenta => "#FF00FF",
                TileColor.Red => "#FF0000",
                TileColor.Yellow => "#FFFF00",
                _ => "#000000",
            };
        }
    }
}
