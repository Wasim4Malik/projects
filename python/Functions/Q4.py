string = "pynativepynvepynative"
my_dict={}
for letter in string:
    my_dict[letter] = my_dict.get(letter, 0) + 1
print(my_dict)
