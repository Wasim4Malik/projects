#pragma once
#include<iostream>
using namespace std;

// Title with underline
void Displaytitle(string anyTitle)
{
	short count = 0;
	for (short i = 0; i < anyTitle.length(); i++)
	{
		anyTitle[i] = toupper(anyTitle[i]);
		if (anyTitle[i] == ' ')
		{
			count++;
		}
	}
	cout << "\t\t\t" << anyTitle << endl << "\t\t\t";
	for (short i = 0; i < anyTitle.length(); i++)
	{
		if (anyTitle[i] == ' ')
		{
			cout << ' ';
		}
		else
		{
			cout << '-';
		}

	}
	cout << "\n";
}
// header 2
void Displaysubtitle(string anytitle)
{
	for (short i = 0; i < anytitle.length(); i++)
	{
		anytitle[i] = toupper(anytitle[i]);
	}
	cout << "\t\t\t" << anytitle << endl<<endl;

}
// for menu display
void Displaymenu()
{
	Displaytitle("calculator 2.0");
	Displaysubtitle("By Wasim Abdulrashid Malik");
	Displaysubtitle("For Sir fode toure");
	cout << "1-Addition\n";
	cout << "2-Division\n";
	cout << "3-Substraction\n";
	cout << "4-Multiplication\n";
	cout << "5-Quit\n\n";
}
//to read choice
short readChoice(short range1, short range2)
{
	short choice;
	do
	{
		cout << "Enter your choice(1-5): ";
		cin >> choice;
		if (choice < range1 || choice > range2)//range validation
		{
			cout << "Please select the right option\n";
		}
	} while (choice < range1 || choice > range2);
	return choice;
}
//Logical part of addition
float calculateAddition(short value)
{
	float  result = 0, anyvalue;
	for (short i = 1; i <= value; i++) 
	{
		cout << "Value " << i << ": ";
		cin >> anyvalue;
		result = result + anyvalue;
	}
	return result;
}
// logical part of division
float calculateDivision(float value1, float value2, float result)
{
	result = value1 / value2;
	return result;
}
//logical part of substraction
float calculateSubtraction(float value1, float value2, float result)
{
	result = value1 - value2;
	return result;
}
//logical part of multiplication
float calculateMultiplication(short value)
{
	float Anyvalue, result = 1;
	for (short i = 1; i <= value; i++)
	{
		cout << "Value " << i << ": ";
		cin >> Anyvalue;
		result = result * Anyvalue;
	}
	return result;
}

short readNumberofValues(string operation)
{
	short value;
	cout << "Enter the number of values to " << operation << "-:";
	cin >> value;
	return value;
}

float readValue(string operation, float value)
{
	cout << "Enter the " << operation << ": ";
	cin >> value;
	return value;
}
//validation for atleast 2 values  
void lessThanTwoValues(string operation)
{
	cout << "Minimum 2 values required for " << operation << endl; ;
}
//ask to repeate the operation again
char TorepeateOperation(string operation)
{
	char ch;
	do
	{
		cout << "Would you like to do another " << operation << " ?(Y/N):";
		cin >> ch;
		ch = toupper(ch); // covert the string to upper for the ease in validation
		if (ch != 'Y' && ch != 'N')
		{
			cout << "Please select one of the given options\n"; 
		}
		} while (ch != 'Y' && ch != 'N'); //all upercases in ch 
	return ch;
}
//show result
void DisplayResult(float result)
{
	cout << "The result is " << result << endl;
}

//Addition
void toAdd()
{
	char ch;
	float value, result = 0;
	do
	{
		system("cls");
		Displaytitle("calculator 2.0");
		Displaysubtitle("addition");
		do
		{
			value = readNumberofValues("add");
			if (value < 2)

			{
				lessThanTwoValues("Addition");
			}

		} while (value < 2); // Atlease 2 values for addition
		result = calculateAddition(value);
		DisplayResult(result);
		result = 0; 
		ch = TorepeateOperation("addition");
	} while (ch == 'Y'); //repete the operation choice 
}
//Division
void toDivide()
{
	char ch;
	float value1 = 0, value2 = 0, result = 0;
	do
	{
		system("cls");
		Displaytitle("calculator 2.0");
		Displaysubtitle("division");
		value1 = readValue("value for division", value1);
		do {
			value2 = readValue("divider", value2);
			if (value2 == 0)
			{
				cout << "Divider can not be zero\n";
				}
			} while (value2 == 0);  
		result = calculateDivision(value1, value2, result);
		DisplayResult(result);
		ch = TorepeateOperation("Division");
	} while (ch == 'Y');
}
//substraction
void toSubtract()
{
	char ch;
	float value1 = 0, value2 = 0, result = 0;
	do
	{
		system("cls");
		Displaytitle("calculator 2.0");
		Displaysubtitle("subtraction");
		value1 = readValue("value for subtraction", value1);
		value2 = readValue("subtractor", value2);
		result = calculateSubtraction(value1, value2, result);
		DisplayResult(result);
		ch = TorepeateOperation("Subtraction");
	} while (ch == 'Y');
}
//multiplication
void toMultiply()
{
	char ch;
	float value, result = 1;
	do
	{
		system("cls");
		Displaytitle("calculator 2.0");
		Displaysubtitle("multiplication");
		do
		{
			value = readNumberofValues("multiply");
			if (value < 2)

			{
				lessThanTwoValues("Multiplication");
			}

		} while (value < 2); //minimum 2 values for multiplication
		result = calculateMultiplication(value);
		DisplayResult(result);
		result = 1; 
		ch = TorepeateOperation("multiplication");
	} while (ch == 'Y');
}