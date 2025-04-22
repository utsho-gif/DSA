Problem 1 (Combination): Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n]. You may return the answer in any order.

Example: n = 4, k=2
Output = [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
----------------------------------------------------------------

Problem 2 (Combination Sum): Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.

(The integers in the candidates array are all non-negative)

Example 1:

Input: candidates = [2,3,8,9], target = 9
Output: [[2,2,2,3],[3,3,3],[9]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 2+ 3 = 9. Note that 2 can be used multiple times.
3 is a candidate, and 3+3+3 = 9.
9 is a candidate, and 9 = 9.
These are the only two combinations.
----------------------------------------------------------------

Problem 3 (Combination Sum 2): Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target. Each number in the candidates may only be used once in the combination.
Note: The solution set must not contain duplicate combinations. 
Example :

Input: candidates = [3,5,2,1,3], target = 7
Output: [[1,3,3],[5,2]]
---------------------------------------------------------------

Problem 4 (Combination Sum 3): Find all valid combinations of k numbers that sum up to n, such that the following conditions are true: Only numbers 1 through 9 are used. Each number is used at most once. Return a list of all possible valid combinations. The list must not contain the same combination twice, and the combinations may be returned in any order.

Example: Input: k = 3, n = 6
Output: [[1,2,3]] 
Explanation: 1 + 2 + 3 = 6. There are no other valid combinations.
---------------------------------------------------------------
Problem 5 (Sudoku Solver): Write a program to solve a Sudoku puzzle by filling in the empty cells. A Sudoku solution must satisfy all of the following rules:
Each digit 1-9 must occur exactly once in each row.
Each digit 1-9 must occur exactly once in each column.
Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid. The '.' character indicates empty cells.
Constraints: board.length == 9, board[i].length == 9, board[i][j] is a digit between 1 and 9, inclusive, or '.'. It is guaranteed that the input board has only one solution.

Example: board = [

["5", "3", ".", ".", "7", ".", ".", ".", "."],

["6", ".", ".", "1", "9", "5", ".", ".", "."],

[".", "9", "8", ".", ".", ".", ".", "6", "."],

["8", ".", ".", ".", "6", ".", ".", ".", "3"],

["4", ".", ".", "8", ".", "3", ".", ".", "1"],

["7", ".", ".", ".", "2", ".", ".", ".", "6"],

[".", "6", ".", ".", ".", ".", "2", "8", "."],

[".", ".", ".", "4", "1", "9", ".", ".", "5"],

[".", ".", ".", ".", "8", ".", ".", "7", "9"]

]

Output : 
[

["5", "3", "4", "6", "7", "8", "9", "1", "2"],

["6", "7", "2", "1", "9", "5", "3", "4", "8"],

["1", "9", "8", "3", "4", "2", "5", "6", "7"],

["8", "5", "9", "7", "6", "1", "4", "2", "3"],

["4", "2", "6", "8", "5", "3", "7", "9", "1"],

["7", "1", "3", "9", "2", "4", "8", "5", "6"],

["9", "6", "1", "5", "3", "7", "2", "8", "4"],

["2", "8", "7", "4", "1", "9", "6", "3", "5"],

["3", "4", "5", "2", "8", "6", "1", "7", "9"]

]
-------------------------------------------------------
