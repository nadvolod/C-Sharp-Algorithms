namespace Algorithms.Trees
{
    public class NodeDepths
    {
        	// average case: when the tree is balanced
	// O(n) time where n is the number of nodes in the tree
	// O(h) space where h is the height of the tree
	// recursive approch is typically better than iterative
	public static int NodeDepths(BinaryTree root) {
		return calculateDepths(root, 0);	
	}
	public static int calculateDepths(BinaryTree root, int depth){
		if(root == null)
			return 0;
		// we calculate the depth by taking the current depth and adding left +1 and right + 1
		return depth + calculateDepths(root.left, depth + 1) + calculateDepths(root.right, depth + 1);
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			left = null;
			right = null;
		}
	}
    }
}