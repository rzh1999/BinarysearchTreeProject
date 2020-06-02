using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        
        public int count;
        public int data;
        public Node left;
        public Node right;

        public Node()
        {
            
            left = null;
            right = null;
            count++;
        }
    }
}
