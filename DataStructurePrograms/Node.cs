﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class Node<T>
    {
        public T data;
        public Node<T> nextNode;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
