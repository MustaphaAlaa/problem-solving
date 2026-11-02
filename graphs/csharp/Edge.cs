public class Edge
{
    public int from;
    public int to;
    public int cost;

    public static bool operator >(Edge e1, Edge e2)
    {
        return e1.cost > e2.cost;
    }

    public static bool operator <(Edge e1, Edge e2)
    {
        return e1.cost < e2.cost;
    }

    public override string ToString()
    {
        return $"From : {from}  -  To : {to}  -  cost : {cost}";
    }
}
