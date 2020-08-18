speed ={'jan':47, 'feb':52, 'march':47, 'April':44, 'May':52, 'June':53, 'july':54, 'Aug':44, 'Sept':54}


result = {}

for key,value in speed.items():
    if value not in result.values():
        result[key] = value

result = list(result.values())


print(result)
