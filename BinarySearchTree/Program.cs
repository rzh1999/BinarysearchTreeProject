using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch bin = new BinarySearch();
            Node root = null;
            Node result;
            result = bin.Add(root, 10);
            bin.Add(result, 4);
            bin.Add(result, 6);
            bin.Add(result, 12);
            result = bin.Add(result, 8);
           

            Console.ReadLine();
        }
    }
}
