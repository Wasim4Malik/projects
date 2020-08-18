list = [10, 20, 30, 10, 20, 40, 50] 
my_dict={}
for letter in list:
    my_dict[letter] = my_dict.get(letter, 0) + 1
print(my_dict)
