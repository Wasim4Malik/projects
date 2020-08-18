sampleList = [87, 45, 41, 65, 94, 41, 99, 94]
sampleList1 = []

for i in sampleList:
    if i not in sampleList1:
        sampleList1.append(i)
print(sampleList)
print(sampleList1)

tuple1 = tuple(sampleList1)
print (tuple1)

print (max(tuple1))
print (min(tuple1))
