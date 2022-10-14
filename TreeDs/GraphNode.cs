using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDs
{
    public class GraphNode
    {
        public GraphNode(int value)
        {
            this._value = value;
            _neighbors = new List<GraphNode>();
        }

        public bool AddNeighbor(GraphNode neighbor)
        {
            if (_neighbors.Contains(neighbor))
            {
                return false;
            }
            else
            {
                _neighbors.Add(neighbor);
                return true;
            }
        }

        public bool RemoveNeighbor(GraphNode myGraphNode)
        {
            if (_neighbors.Contains(myGraphNode))
            {
                return _neighbors.Remove(myGraphNode);
            }
            return false;
        }


        public bool RemoveAllNeighbor()
        {
            foreach (GraphNode item in _neighbors)
            {
                _neighbors.Remove(item);
            }
            return true;
        }


        public override string ToString()
        {
            StringBuilder nodeString = new StringBuilder();
            nodeString.Append("[Node Value: " + Value + " with Neighbors");
            foreach (var item in _neighbors)
            {
                nodeString.Append(" -> " + item.Value);
            }
            nodeString.Append(" ]");
            return nodeString.ToString();
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }
        public List<GraphNode> Neighbors
        {
            get
            {
                return _neighbors;
            }
        }


        private int _value;
        List<GraphNode> _neighbors;
    }
}
