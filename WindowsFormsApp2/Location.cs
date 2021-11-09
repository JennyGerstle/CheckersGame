public class Location
{
    private double x;
    private double y;

    public Location(double xCoord, double yCoord)
    {
        x = xCoord;
        y = yCoord;
    }

    public int compareTo(Location otherLocation)
    {
        if (this.x > otherLocation.x)
        {
            return 1;
        }
        else if(this.x == otherLocation.x)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public double getX()
    {
        return x;
    }

    public double getY()
    {
        return y;
    }


}
