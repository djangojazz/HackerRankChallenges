using Challenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Helpers
{
    internal class CreateTreeStructureFromArrayOnly
    {
        public static NodeTree CreateTree(int[] arr)
        {
            var currentLevel = 1;
            var previous = 0;
            var root = new NodeTree();
            var currentNode = new NodeTree();
            var multiNode = false;

            for (int i = 0; i < arr.Length; i++)
            {
                var val = arr[i];
                var node = new NodeTree { Id = val, Level = currentLevel, Nodes = new List<NodeTree>() };

                if (i == 0)
                {
                    root = node;
                    previous = arr[0];
                    currentNode = root;
                    currentLevel++;
                }

                if (multiNode & val - previous != 1)
                {
                    currentNode.Nodes.Add(node);
                }

                if (val > previous) //direct node
                {
                    if (val - previous == 1) //direct node
                    {
                        currentNode.Nodes.Add(node);
                        previous = val;
                        currentNode = node;
                        currentLevel++;
                        multiNode = false;
                    }
                    else //has many nodes
                    {
                        currentNode.Nodes.Add(node);
                        previous = val;
                        currentNode = node;
                        currentLevel++;
                        multiNode = true;
                    }
                }


                if (!multiNode & val < previous) //related to a node higher up
                {
                    var parent = FindParentNodeById(root, val-1); //Should be val - 1

                    if (parent != null)
                    {
                        parent.Nodes.Add(node);
                        previous = val;
                        currentNode = node;
                        currentLevel++;
                    }
                }

            }

            return root;
        }

        public static NodeTree? FindParentNodeById(NodeTree root, int id)
        {
            Console.WriteLine($"Need to find parent: {root.Id} Id: {id}");
            var node = root.Nodes.FirstOrDefault(x => x.Id == id);

            if (node != null)
            {
                return node;
            }
            else
            {
                foreach (var child in root.Nodes)
                {
                    var result = FindParentNodeById(child, id);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
    }
}
