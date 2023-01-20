namespace Binary_Search_Tree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);
            binarySearchTree.Display();
        }
    }
}