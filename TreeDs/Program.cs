// See https://aka.ms/new-console-template for more information
using TreeDs;

Console.WriteLine("Hello, World!");

#region Type 1 : Graph Using LinkedList
BasicGraph graph = new BasicGraph(8);
graph.addEdge(0, 2);
graph.addEdge(1, 3);
graph.addEdge(1, 4);
graph.addEdge(2, 5);
graph.addEdge(3, 5);
graph.addEdge(4, 6);
graph.addEdge(6, 7);
graph.PrintAdjanceyList();
graph.CreateAdjanceyMatrix(graph);
#endregion







Console.ReadLine();