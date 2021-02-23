/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        helper(root, result);
        return result;
        
    }
        public void helper(TreeNode root, IList<int> result){
        //base case
        if (root == null)
            return;
        
        //recrusive call left subtree
        helper(root.left, result);
        
        //visist node
        result.Add(root.val);
        
        //recursive call rigth subtree
        helper(root.right, result);
        }
}
