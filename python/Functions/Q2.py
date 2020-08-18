inputString = "P3*ython$@1!)program0"
charCount = 0
digitCount = 0
symbolCount = 0
for char in inputString:
    if char.islower() or char.isupper():
        charCount+=1
    elif char.isnumeric():
        digitCount+=1
    else:
        symbolCount+=1
          
print("Characters of the string = ", charCount)
print("Digits of the string  = ", digitCount)
print("Symbol in this string = ", symbolCount)

