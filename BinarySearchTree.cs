﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftcount = 0, rightcount = 0;
        bool result = false;
        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Add(item);
            }
            else
            {
            if (this.RightTree == null)
            {
                this.RightTree = new BinarySearchTree<T>(item);
            }
            else
                this.RightTree.Add(item);
            }


        }
        public void Display()
        {
           if (this.LeftTree != null)
           {
                this.leftcount++;
                this.LeftTree.Display();
           }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightcount++;
                this.RightTree.Display();
            }
        }
    }
}