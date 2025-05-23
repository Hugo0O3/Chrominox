namespace Chrominox.Server.Models

{
    public enum Orientation
    {
        UP(1,0),
        DOWN(-1,0),
        LEFT(0,-1),
        RIGHT(0,1)
    }

    {
    private int x;
    private int y;

    Orientation(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int getX()
    {
        return this.x;
    }
    public int getY()
    {
        return this.y;
    }

    public Orientation rotate(this Orientation orientation)
    {
        return orientation switch
        {
            UP => RIGHT,
            DOWN => LEFT,
            LEFT => UP,
            RIGHT => DOWN,
            _ => UP
        }
    }

    public Orientation reverse(this Orientation orientation)
    {
        return orientation switch
        {
            UP => DOWN,
            DOWN => UP,
            LEFT => RIGHT,
            RIGHT => LEFT,
            _ => UP
        }
    }

}
}