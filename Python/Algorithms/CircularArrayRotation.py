#Problem link: https://www.hackerrank.com/challenges/circular-array-rotation/
#This is the slow implementation

#!/bin/python3

import sys

def rotate(array, times):
    for i in range(0, times):
        left = array[0];
        for j in range (1, len(array)):
            swap = array[j];
            array[j] = left;
            left = swap;

        array[0] = left;


n, k, q = input().strip().split(' ')
n, k, q = [int(n),int(k),int(q)]
a = [int(a_temp) for a_temp in input().strip().split(' ')]

rotate(a, k)

for a0 in range(q):
    m = int(input().strip())
    print(a[m])
