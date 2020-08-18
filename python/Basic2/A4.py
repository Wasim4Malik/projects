firstSet = {27, 43, 34}
secondSet = {34, 93, 22, 27, 43, 53, 48}
if(firstSet.issubset(secondSet)):
    print('First set is the subset of Second set')
    firstSet.clear()

elif(secondSet.issubset(firstSet)):
    print('Second set is the subset of First set')
    secondSet.clear()

else:
    print ('Given sets are completly different')


print (firstSet)
print (secondSet)
