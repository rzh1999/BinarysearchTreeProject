using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearch
    {

        //Used as research
        //https://www.codeproject.com/Articles/18976/A-simple-Binary-Search-Tree-written-in-C
        //https://www.youtube.com/watch?v=oKndim5-G94
        public Node Add(Node root, int data)
        {
            if (root == null)
            {
                root = new Node();
                root.data = data;
               // return root;
            }
            else if (data < root.data)
            {
                //Will create a new node since root.left is null and recalling Add() 
                root.left = Add(root.left, data);
            }
            else
            {
                root.right = Add(root.right, data);
            }
            return root;

        }

        public Node Search(Node head, int value)
        {
            //add this to make sure its not getting called before there is a root, I forgot this earlier
            if (head != null)
            {
                if (value == head.data)
                {
                    return head;
                }
                if (value < head.data)
                {
                    return Search(head.left, value);
                }
                else
                {
                    return Search(head.right, value);
                }
                
            }
            return null;
        }
           

    }
}
