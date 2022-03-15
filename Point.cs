internal class Point : IComparable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
    public override string ToString() => $"[{this.X}, {this.Y}]";
    
    // перегруженная операция -
    public static Point operator - (Point p0, Point p1) =>
    new Point(p0.X - p1.X, p0.Y - p1.Y);

    // сдвиг точки на 10
    public static Point operator ++(Point p0) => new Point(p0.X + 10, p0.Y + 10);

    // перегруженная операция != (обязательно в паре с ==)
    public override bool Equals(object o) => o.ToString() == this.ToString();
    public override int GetHashCode() => this.ToString().GetHashCode();
    public static bool operator ==(Point pi, Point p2) => pi.Equals(p2);
    public static bool operator !=(Point p0, Point p1) => !p0.Equals(p1);

    // перегруженное сравнение
    public int CompareTo(Point other)
    {
        if (this.X > other.X && this.Y > other.Y)
            return 1;
        if (this.X < other.X && this.Y < other.Y)
            return -1;
        else
            return 0;
    }
    public static bool operator <(Point p0, Point p1) => p0.CompareTo(p1) < 0;
    public static bool operator >(Point p0, Point p1) => p0.CompareTo(p1) > 0;
    public static bool operator <=(Point p0, Point p1) => p0.CompareTo(p1) <= 0;
    public static bool operator >=(Point p0, Point p1) => p0.CompareTo(p1) >= 0;
}