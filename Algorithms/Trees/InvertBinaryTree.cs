using System;

public class InvertBinaryTree {
	// O(n) time where n is the number of nodes
	// O(d) space where d is the height of the tree. There comes a time when
	// all of the leaf nodes are in the queue, with all of the nodes
	public static void InvertTree(BinaryTree tree) {
		// standard loc for a binary tree
		if(tree == null){
			return;
		}
		swapLeftAndRight(tree);
		InvertTree(tree.left);
		InvertTree(tree.right);
	}
	
	private static void swapLeftAndRight(BinaryTree tree){
		BinaryTree left = tree.left;
		tree.left = tree.right;
		tree.right = left;
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
		}
	}
}

/*
rightmost node becomes a leftmost node and vice versa
// start at the top
// look at children
// switch
// move down
// switch
// continue until left and right are null

//what happens if it's an unbalanced tree?
can the input be null?
Only integer values in the binary tree?

*/
