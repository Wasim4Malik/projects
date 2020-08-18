 
list1 = [54, 44, 27, 79, 91, 41]

list2 = []
list2.append(list1[4])
list1[4:5] = []
list1 = list1[0:2] + list2 + list1[2:] + list2

print("List = ",list1)
