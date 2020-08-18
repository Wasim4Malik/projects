import itertools
counter = itertools.count(1)


class Circle():
    def __init__(self, radius, color):
        self.circleId = "CIR_"+str(next(counter))
        self.radius = radius
        self.color = color

        self.p = 2*3.14*(self.radius)
        self.a = 3.14 * (self.radius) * (self.radius)

    def findPerimeter(self):
        print(f'Perimeter of {self.circleId} : {self.p}')

    def findArea(self):
        print(f'Area of {self.circleId} : {self.a}')

    def __str__(self):
        print('----------------------')
        return f" Circle ID: {self.circleId} \n Radius: {self.radius} \n Color: {self.color} \n Perimeter: {self.p} \n Area: {self.a}"

    def __del__(self):
        print(f'a object of {self.__class__.__name__}  is deleted ')






