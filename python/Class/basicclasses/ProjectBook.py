import itertools
counter = itertools.count(1)


class Book():
    def __init__(self, bookTitle, bookAuthor, bookEditor, bookPrice):
        self.__bookId = next(counter)
        self.__bookTitle = bookTitle
        self.__bookAuthor = bookAuthor
        self.__bookEditor = bookEditor
        self.bookPrice = bookPrice

    def getBookdetails(self):
        print(f' BOOK {self.__bookId} Details: \n Title: {self.__bookTitle} \n Author: {self.__bookAuthor} \n Editor: {self.__bookEditor}  \n Price : {self.bookPrice}')


    def SetNewPrice(self, newprice):
        self.bookPrice = newprice

    def __str__(self):
        print('----------------------')
        return f" Book ID: {self.__bookId} \n Book Name: {self.__bookTitle} \n Book Author: {self.__bookAuthor} \n Book Price: {self.bookPrice}"




