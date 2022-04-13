using System.Collections.Generic;

public class DepthFirstSearch
{
    // every letter in a graph is a vertex
    // edges are the connections between the vertices
    // Time = O(v + e)
    // Space = O(v) where v is the count of vertices. Each vertex is a call to the DepthFirstSearch()
    // hence, each level of nodes is a frame on the call stack. So we need space to resolve each node in the 
    // call stack
    public class Node {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name) {
            this.name = name;
        }
        public List<string> DepthFirstSearch(List<string> array)
        {
            array.Add(name);
            foreach (var child in children)
            {
                child.DepthFirstSearch(array);
            }

            return array;
        }
        // not used
        public Node AddChild(string name) {
            var child = new Node(name);
            children.Add(child);
            return this;
        }
    }


    public static void dfs(Graph G, int startVert)
    {
        bool[] visited = new bool[G.Size];
        System.Collections.Generic.Stack<int> s = new System.Collections.Generic.Stack<int>();

        visited[startVert] = true;

        s.Push(startVert);

        while(s.Count > 0)
        {
            int v = s.Pop();
            foreach(int adjV in G.adjacent[v])
            {
                if (!visited[adjV])
                {
                    visited[adjV] = true;
                    s.Push(adjV);
                }
            }
        }

    }

    public class Graph
    {
        public LinkedList<int>[] adjacent;
        public int Size;
    }
    /*
     * A
     * A,B,E,F,C,D
     */
    public static void dfsRecursive(Graph source, int startVert)
    {
        // array of booleans
        bool[] visited = new bool[source.Size];
        dfsAux(source, startVert, visited);
    }

    private static void dfsAux(Graph source, int node, bool[] visited)
    {
        // set visited node to true
        visited[node] = true;
        foreach(int child in source.adjacent[node])
        {
            if (!visited[child])
            {
                dfsAux(source, child, visited); // Visiting.
            }
        }
    }
}