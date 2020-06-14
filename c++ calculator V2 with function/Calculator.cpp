#include"MyHeader.h"
void main()
{
	short choice;
	do
	{
		system("cls");
		Displaymenu();
		choice = readChoice(1, 5);
		switch (choice)
		{
		case 1: // For addition
			toAdd();
			break;
		case 2: //For division
			toDivide();
			break;
		case 3: //for substraction
			toSubtract();
			break;
		case 4: //for multiplication
			toMultiply();
			break;
		}
	} while (choice != 5);
}