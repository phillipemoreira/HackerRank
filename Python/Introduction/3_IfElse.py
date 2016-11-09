#Problem link: https://www.hackerrank.com/challenges/py-if-else

#!/bin/python

import sys


N = int(input().strip())

if (N % 2 > 0):
    print("Weird")
elif (N >= 2 and N <=5):
    print("Not Weird")
elif (N >= 6 and N <=20):
    print("Weird")
else:
    print("Not Weird")