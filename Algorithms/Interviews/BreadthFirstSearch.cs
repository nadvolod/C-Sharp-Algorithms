using System;
using System.Collections.Generic;

public class BreadthFirstSearch
{
    /*
     * Use a Queue for bfs
     * 
     */
    public class Node
    {
        public Node left;
        public Node right;
        public string data;

        public Node(string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public Node(string data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    public static void BFS(Node node)
    {
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            Console.Write(node.data + " ");

            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }
    }

    public static Node SampleTree()
    {
        Node root = new Node("A", new Node("B", new Node("C"), new Node("D")),
            new Node("E", new Node("F"), new Node("G", new Node("H"), null)));
        return root;
    }
}