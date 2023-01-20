using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public T data;
        public BinarySearchTree<T> left;
        public BinarySearchTree<T> right;
        public BinarySearchTree(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        int leftIndex = 0;
        int rightIndex = 0;

        public void AddNode(T value)
        {
            T Nodevalue = this.data;
            if (Nodevalue.CompareTo(value) > 0)
            {
                if (this.left == null) this.left = new BinarySearchTree<T>(value);
                else
                    this.left.AddNode(value);

            }
            else
            {
                if (this.right == null) this.right = new BinarySearchTree<T>(value);
                else
                    this.right.AddNode(value);
            }
        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftIndex++;
                this.left.Display();
            }
            Console.WriteLine(this.data);
            if (this.right != null)
            {
                this.rightIndex++;
                this.right.Display();
            }
        }
    }
}

