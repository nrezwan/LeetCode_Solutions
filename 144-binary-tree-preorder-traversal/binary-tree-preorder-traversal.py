# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        results = []
        def traverse(currNode):
            if currNode is None:
                return
            results.append(currNode.val)
            if(currNode.left):
                traverse(currNode.left)
            if(currNode.right):
                traverse(currNode.right)
        traverse(root)
        return results
        