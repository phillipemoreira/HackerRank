#Problem link: https://www.hackerrank.com/challenges/python-lists

list = list()

number_of_commands = int(input())
for i in range(0, number_of_commands):
    s = input().split(' ')
    command = s[0]
    args = s[1:]
    if command == "insert":
        list.insert(int(args[0]), int(args[1]))
    elif command == "print":
        print(list)
    elif command == "remove":
        list.remove(int(args[0]))
    elif command == "append":
        list.append(int(args[0]))
    elif command == "sort":
        list.sort()
    elif command == "pop":
        list.pop()
    elif command == "reverse":
        list.reverse()