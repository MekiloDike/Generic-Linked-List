﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTask
{
    internal class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node (int data)
        {
            Data = data;
        }
    }
}
