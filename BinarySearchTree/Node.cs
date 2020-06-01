using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        int data;
        public int count = 0;
        Node left;
        Node right;

        public Node(int data)
        {
            this.data = data;
            count++;
        }
    }
}
