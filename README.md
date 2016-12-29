# CountTwoNumberSums
Counts the number of unique sums from adding two numbers together to equal an input. Lower and upper bound are taken as inputs.

I've posted this solution because it is a good example of code that can be scaled well without a large performance hit.

This is my work to solve the arcade challenge posted on codefights: https://codefights.com/arcade/code-arcade/loop-tunnel/hBw5BJiZ4LmXcy92u/solutions

Description of task:
Given integers n, l and r, find the number of ways to represent n as a sum of two integers A and B such that l ≤ A ≤ B ≤ r.

Example

For n = 6, l = 2 and r = 4, the output should be
countSumOfTwoRepresentations2(n, l, r) = 2.

There are just two ways to write 6 as A + B, where 2 ≤ A ≤ B ≤ 4: 6 = 2 + 4 and 6 = 3 + 3.

Input/Output

    [time limit] 3000ms (cs)

    [input] integer n

    A positive integer.

    Constraints:
    5 ≤ n ≤ 109.

    [input] integer l

    A positive integer.

    Constraints:
    1 ≤ l ≤ r.

    [input] integer r

    A positive integer.

    Constraints:
    l ≤ r ≤ 109,
    r - l ≤ 106.

    [output] integer

