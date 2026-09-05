# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def hasPathSum(self, root: Optional[TreeNode], targetSum: int) -> bool:
        value = 0
        if not root:
            return False
        node = root
        def traverse(node, tS, isL):
            if not node:
                if targetSum == tS and isL:
                    return True
                return False
            
            val = tS+ node.val
            isL= node.left == node.right == None
            return traverse(node.left,val,isL) or traverse(node.right,val,isL)
        return traverse(root, 0,node.left == node.right == None)
                