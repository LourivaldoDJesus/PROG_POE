﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE
{
    public class BinaryTree<T>
    {
        private BinaryTree<T> rightNode; // right node of the binary tree.
        private BinaryTree<T> leftNode; // left node of the binary tree.
        public T value { get; set; } // the value of the current node.

        public BinaryTree(T value)
        {
            this.value = value;
            this.rightNode = null;
            this.leftNode = null;
        }

        public BinaryTree(T value, BinaryTree<T> left, BinaryTree<T> right) : this(value)
        {
            this.rightNode = right;
            this.leftNode = left;
        }

        public void SetLeftNode(BinaryTree<T> node)
        {
            this.leftNode = node;
        }

        public void SetRightNode(BinaryTree<T> node)
        {
            this.rightNode = node;
        }

        public BinaryTree<T> GetRightNode() => this.rightNode;
        public BinaryTree<T> GetLeftNode() => this.leftNode;

        public override string ToString() => this.value?.ToString();


    }
}
