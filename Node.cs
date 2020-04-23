using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrevoForms
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node(int x)
        {
            val = x;
        }
    }
}
