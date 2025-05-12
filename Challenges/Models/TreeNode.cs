using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Models
{
    public class NodeTree
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public List<NodeTree> Nodes { get; set; } = new List<NodeTree>();

        public void InsertNode(int id, int level)
        {
            if (Nodes == null)
                Nodes = new List<NodeTree>();

            var node = new NodeTree { Id = id, Level = level };
        }

        public void AddALevel(int x) => Level += x;
    }
}
