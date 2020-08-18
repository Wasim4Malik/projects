
string1 = input("Enter String1 = ")
string2 = input("Enter String2 = ")

midstring = int(len(string1)/2)
middleString = string1[:midstring-1:] + string2[midstring -1:]
print("Append String = ", middleString)
