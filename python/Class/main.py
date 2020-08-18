from basicclasses.ProjectBook import Book
from basicclasses.ProjectCircle import Circle


b1 = Book('a Journey to the West ', 'Nisha', 'Nectar', 150.23)
b2 = Book('Shreemad Bhagvat Gita', 'Shree Krishna', 'himself', 250.23)
b3 = Book('Ramayan', 'shree Valmiki', 'rushi', 250.23)
b4 = Book('Mahabharta', 'shree Vedvyas', 'rushi', 250.23)
b5 = Book('Samved', 'Brahma', 'himself', 250.23)

b1.getBookdetails()
b1.SetNewPrice(999)
print(b1)

c1 = Circle(1,'SkyBlue')
c2 = Circle(2,'Pink')
c3 = Circle(3,'Red')
print(c1)
del c2
print(c3)
