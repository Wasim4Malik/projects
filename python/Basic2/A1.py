list1 = [10,2,3,4,5,8,6,44,332,100,23,66]
print ('Original list -->',list1)
print('3 lists after slicing')
sliced1 = list1[:4]
print('Lists in normal order')
print ('List 1 --> ',sliced1)
sliced2 = list1[4:8]
print ('List 2 --> ',sliced2)
sliced3 = list1[8:]
print ('List 3 --> ',sliced3)
sliced1.reverse()
sliced2.reverse()
sliced3.reverse()
print('Lists in reverse order')
print ('List 1 --> ',sliced1)
print ('List 2 --> ',sliced2)
print ('List 3 --> ',sliced3)
