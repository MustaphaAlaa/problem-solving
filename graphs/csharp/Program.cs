 

 Graph_EdgeListRepresentation gra = new();

 gra.Add_Edge(new Edge {from=3, to = 1, cost = 200});
 gra.Add_Edge(new Edge {from=3, to = 2, cost = 100});
 gra.Add_Edge(new Edge {from=1, to = 2, cost = 1200});

 System.Console.WriteLine(gra);