string = "PyNaTive"
lower = []
upper = []
for char in string:
    if char.islower():
        lower.append(char)
    else:
        upper.append(char)
sortString = ''.join(lower + upper)
print("\n Arranged string started from lowercase:")
print(sortString)

