using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryTree<T> where T : IComparable
    {
        //Variable
        public Node<T> root;
        public void CreateNode(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> parentNode = root;
                Node<T> currentNode = root;
                while (true)
                {
                    parentNode = currentNode;
                    if (currentNode.data.CompareTo(value) >= 0)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Method to display Root Node
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        //Method to display Nodes in binary search tree

        public void Display(Node<T> parent)
        {
            if (parent != null)
            {
                Display(parent.left);
                Display(parent.right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        //length of binary search tree 
        public int Size(Node<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }
        //Method to Search the specified key in binary search tree
        public bool Search(Node<T> root, T key)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data.CompareTo(key) == 0)
            {
                return true;
            }
            else if (root.data.CompareTo(key) > 0)
            {
                return Search(root.left, key);
            }
            else
            {
                return Search(root.right, key);
            }
        }
    }
}
