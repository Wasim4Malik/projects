
list1 = [3,6,9,12,15,18,21]
list2 = [4,8,12,16,20,24,28]

list3 = list()
oddlist = list1[1::2]
evenlist = list2[0::2]
list3.extend(oddlist)
list3.extend(evenlist)
print("Odd List = ",oddlist)
print("Even List = ",evenlist)
print("List3 = ",list3)
