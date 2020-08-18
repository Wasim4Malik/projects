string = input("Enter a odd length string : ")
length_str = len(string)
if length_str > 7 :
    middle_index = int(length_str//2)
    print("The middle three characters of odd string :",string[(middle_index) - 1 : (middle_index) + 2])
else :
    print("The string is not odd")
