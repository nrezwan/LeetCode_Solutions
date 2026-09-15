# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrder(self, root: TreeNode | None) -> list[list[int]]:
        if root is None:
            return []
        result = []
        que = deque([root])
        while que:
            level = []
            size = len(que)
            for i in range(size):
                temp = que.popleft()
                level.append(temp.val)
                if temp.left:
                    que.append(temp.left)
                if temp.right:
                    que.append(temp.right)
            result.append(level)
        return result
        