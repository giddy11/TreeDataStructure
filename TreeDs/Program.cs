// See https://aka.ms/new-console-template for more information
using TreeDs;

Console.WriteLine("Hello, World!");

#region Type 1 : Graph Using LinkedList
//BasicGraph graph = new BasicGraph(8);
//graph.addEdge(0, 2);
//graph.addEdge(1, 3);
//graph.addEdge(1, 4);
//graph.addEdge(2, 5);
//graph.addEdge(3, 5);
//graph.addEdge(4, 6);
//graph.addEdge(6, 7);
//graph.PrintAdjanceyList();
//graph.CreateAdjanceyMatrix(graph);
#endregion


#region Type 2 : Non-Zero Index Based Graph using Custom class
StandardGraph myGraph = new StandardGraph();
myGraph.AddNode(1);
myGraph.AddNode(2);
myGraph.AddNode(3);
myGraph.AddNode(4);
myGraph.AddNode(5);
myGraph.AddNode(6);
myGraph.AddNode(7);
myGraph.AddNode(8);

myGraph.AddEdge(1, 3);
myGraph.AddEdge(3, 6);
myGraph.AddEdge(2, 4);
myGraph.AddEdge(4, 6);
myGraph.AddEdge(2, 5);
myGraph.AddEdge(5, 7);
myGraph.AddEdge(7, 8);

Console.WriteLine(myGraph.ToString());
#endregion






Console.ReadLine();