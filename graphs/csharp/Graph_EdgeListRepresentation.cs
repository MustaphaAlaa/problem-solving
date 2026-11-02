using System.Text;

public class Graph_EdgeListRepresentation
{
    List<Edge> graph;

    public Graph_EdgeListRepresentation(int capacity = 10)
    {
        graph = new(capacity);
    }

    public void Add_Edge(Edge edge)
    {
        graph.Add(edge);
    }

    public override string ToString()
    {
        StringBuilder str = new();

        foreach (var edge in graph)
        {
            str.Append(edge);
            str.Append("\n");
        }
        return str.ToString();
    }
}
