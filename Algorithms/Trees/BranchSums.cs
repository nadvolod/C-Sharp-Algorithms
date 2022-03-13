namespace Algorithms.Trees
{
    public class BranchSums
    {
        	// This is the class of the input root. Do not edit it.
	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}

	public static List<int> BranchSums(BinaryTree root) {
		List<int> sums = new List<int>();
		// recursive function
		calculateBranchSums(root, 0, sums);
		return sums;
	}
	
	public static void calculateBranchSums(BinaryTree node, int runningSum, List<int> sums){
		// this is a common starting code for binary tree algos
		if (node == null) return;
		
		// runningSum = 0 then 1 and so on ... using our example tree
		int newRunningSum = runningSum + node.value;
		Console.WriteLine("newRunningSum=>" + newRunningSum);
		// this implies that we're currently on a leaf node
		if (node.left == null && node.right == null){
			sums.Add(newRunningSum);
			Console.WriteLine("sums=>" + string.Join(", ", sums));
			return;
		}
		
		//2, 1, []
		calculateBranchSums(node.left, newRunningSum, sums);
		//3, 1, []
		calculateBranchSums(node.right, newRunningSum, sums);
	}

    /*
    Test Case 1:
    Input
    {
        "tree": {
            "nodes": [
            {"id": "1", "left": "2", "right": "3", "value": 1},
            {"id": "2", "left": "4", "right": "5", "value": 2},
            {"id": "3", "left": "6", "right": "7", "value": 3},
            {"id": "4", "left": "8", "right": "9", "value": 4},
            {"id": "5", "left": "10", "right": null, "value": 5},
            {"id": "6", "left": null, "right": null, "value": 6},
            {"id": "7", "left": null, "right": null, "value": 7},
            {"id": "8", "left": null, "right": null, "value": 8},
            {"id": "9", "left": null, "right": null, "value": 9},
            {"id": "10", "left": null, "right": null, "value": 10}
            ],
            "root": "1"
        }
    }
    ---------- Test Case 1 Output -----------
    newRunningSum=>1
    newRunningSum=>3
    newRunningSum=>7
    newRunningSum=>15
    sums=>15
    newRunningSum=>16
    sums=>15, 16
    newRunningSum=>8
    newRunningSum=>18
    sums=>15, 16, 18
    newRunningSum=>4
    newRunningSum=>10
    sums=>15, 16, 18, 10
    newRunningSum=>11
    sums=>15, 16, 18, 10, 11
    
    */
	
	/**
	Testing
	input: 2
	node.value = 2
	node.left = 4
	node.right = 5
	sums = [15,]
	newRunningSum = 3
	sums
	*/
	
	// returning a sum of each of the branches
	// the # of branches is determined by number of leaf nodes
	// can the binary tree be null/empty?
	// can everything be done in memory?
	// one node, 1?
	// can the tree have the same values?
	
	// binaryTree.value < tree.left
    }
}