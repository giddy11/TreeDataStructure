using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDs
{
    public class StandardGraph
    {
        public StandardGraph()
        {

        }

        //Neighbor: Add, Find, Remove, Clear
        public int Count
        {
            get
            {
                return myGraphNodes.Count;
            }
        }
        public IList<GraphNode> GraphNodes
        {
            get
            {
                return myGraphNodes.AsReadOnly();
            }
        }
        public bool AddNode(int value)
        {
            if (Find(value) != null)
            {
                return false;
            }
            else
            {
                myGraphNodes.Add(new GraphNode(value));
                return true;
            }
        }
        public bool AddEdge(int n1, int n2)
        {
            GraphNode gn1 = Find(n1);
            GraphNode gn2 = Find(n2);
            if (gn1 == null && gn2 == null)
            {
                return false;
            }
            else if (gn1.Neighbors.Contains(gn2))
            {
                return false;
            }
            else
            {
                gn1.AddNeighbor(gn2);
                return true;
            }
        }
        GraphNode Find(int value)
        {
            foreach (GraphNode item in myGraphNodes)
            {
                if (item.Value.Equals(value))
                {
                    return item;
                }
            }
            return null;
        }
        public bool RemoveNode(int value)
        {
            GraphNode TBR = Find(value);
            if (TBR != null)
            {
                myGraphNodes.Remove(TBR);
                foreach (GraphNode item in myGraphNodes)
                {
                    item.RemoveNeighbor(TBR);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveEdge(int n1, int n2)
        {
            GraphNode gn1 = Find(n1);
            GraphNode gn2 = Find(n2);
            if (gn1 == null || gn2 == null)
            {
                return false;
            }
            else if (!gn1.Neighbors.Contains(gn2))
            {
                return false;
            }
            else
            {
                gn1.RemoveNeighbor(gn2);
                return true;
            }
        }
        public bool Clear()
        {
            foreach (GraphNode item in myGraphNodes)
            {
                item.RemoveAllNeighbor();
            }
            for (int i = Count - 1; i >= 0; i--)
            {
                myGraphNodes.RemoveAt(i);
            }
            return true;
        }
        public override string ToString()
        {
            Console.WriteLine("========================================\n");
            Console.WriteLine("New Graph Adjacency List Implementation:\n");
            Console.WriteLine("----------[Non Zero Index Based]--------\n");
            Console.WriteLine("========================================\n");
            StringBuilder nodeString = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                nodeString.Append(myGraphNodes[i].ToString());
                if (i < Count - 1)
                {
                    nodeString.Append("\n");
                }
            }
            return nodeString.ToString();
        }

        List<GraphNode> myGraphNodes = new List<GraphNode>();
    }
}
