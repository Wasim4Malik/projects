#include<iostream>	//calling the header files beacause we will be dealing with only numerics and charechters
using namespace std;
void main()
{
	short choice, Nvalues;
	float result=0 , value1,value2;
	char option;
	do{		//heading loop
		do {  // loop for choices btween 1 to 5
		system("cls");
		cout << "\t\t\tCALCULATOR " << endl;
		cout << "\t\t\t----------  " << endl;
		cout << "\t\tBY WASIM ABDULRASHID MALIK" << endl;
		cout << "\t\tFOR FODE TOURE" << endl;
	
			
				cout << "1: ADDITION "<<endl;
				cout << "2: DIVISION "<<endl;
				cout << "3: SUBSTRACTION "<<endl;
				cout << "4: MULTIPLICATION "<<endl;
				cout << "5: QUIT "<<endl;
			
						cout << "Enter your choice(1-5):";
						cin >> choice;
				
				
				
				} while (choice < 0 || choice>5 );

		switch (choice)  //instruction to follow from choice
	 {		
			 
		 case 1:
			 do {			//heading loop
				 system("cls");
				 cout << "\t\t CALCULATOR " << endl;
				 cout << "\t\t-------------  " << endl;
				 cout << "\t\t ADDITION" << endl;
				do{				//for number of values to be add which should be more then 2
				 cout << "\nEnter the number of values to add: ";
				 cin >> Nvalues;
				} while (Nvalues <2 );
				result = 0;
					 for (int i = 0; i < Nvalues; i++) //For loop for number of values to be calculated 
					 {
						 cout << "\nValue " << (i+1) << ":";
						 cin >> value1;
						 result = result + value1; //LOGICAL CODE
					 }
					 cout << "\nThe Result is  " << result << endl;//Summation
					 do // to ask if user wants to do the same process again or not
					 {
					 
						 cout << "\nWould you like to do another Addition (Y/N) : ";
						 cin >> option;
					 }while (option != 'y' && option != 'Y' && option != 'n' && option != 'N');
					 
					 
			 } while (option=='Y' || option == 'y');
			 break;

		case 2:
			 do {	//for heading loop
				 system("cls");
				 result = 0,value1=0,value2=0;
				 cout << "\t\t CALCULATOR " << endl;
				 cout << "\t\t-------------  " << endl;
				 cout << "\t\t DIVISION" << endl;
				 
				 
				 cout << "\nEnter the value of Numerator : ";
				 cin >> value1;
				 do{ //For demonitor which should not be zero in division
				 cout << "\nEnter the value of denominator : ";
				 cin >> value2;
				 } while (value2 == 0);

				 result = value1 / value2;
				 
				 cout << "\nThe result is " << result << endl;//quotient

				 do // to ask if user wants to do the same process again or not
				 {

					 cout << "\nWould you like to do another DIVISION (Y/N) : ";
					 cin >> option;
				 } while (option != 'y' && option != 'Y' && option != 'n' && option != 'N');
				 
			 } while (option == 'Y' || option == 'y');
				 
				 
				 
				 
				 break;
		case 3:
			do {	//for heading loop
				system("cls");
				result = 0, value1 = 0, value2 = 0;
				cout << "\t\t CALCULATOR " << endl;
				cout << "\t\t-------------  " << endl;
				cout << "\t\tSUBSTRACTION" << endl;


				cout << "\nEnter the value of Minuend : ";
				cin >> value1;
				do { //For demonitor which should not be zero in division
					cout << "\nEnter the value of Subtrahend : ";
					cin >> value2;
				} while (value2 == 0);

				result = value1 - value2;

				cout << "\nThe Result is " << result << endl;//difference 
				
				do // to ask if user wants to do the same process again or not
				{

					cout << "\nWould you like to do another Substraction (Y/N) : ";
					cin >> option;
				} while (option != 'y' && option != 'Y' && option != 'n' && option != 'N');

			} while (option == 'Y' || option == 'y');

				
				break;

		 case 4:
			 do {			//heading loop
				 system("cls");
				 Nvalues = value1 = 0;
				 result = 1;
				 cout << "\t\t CALCULATOR " << endl;
				 cout << "\t\t-------------  " << endl;
				 cout << "\t\t MULTIPLICATION" << endl;
				 do {				//for number of values to be add which should be more then 2
					 cout << "\nEnter the number of values to Multiply: ";
					 cin >> Nvalues;
				 } while (Nvalues < 2);
				
				 for (int i = 0; i < Nvalues; i++) //For loop for number of values to be calculated 
				 {
					 cout << "\nValue " << (i + 1) << ":";
					 cin >> value1;
					 result = result * value1;  // LOGICAL CODE
				 }
				 cout << "\nThe result is  " << result << endl; //quotient
				 do // to ask if user wants to do the same process again or not
				 {

					 cout << "\nWould you like to do another Multiplication (Y/N) : ";
					 cin >> option;
				 } while (option != 'y' && option != 'Y' && option != 'n' && option != 'N');


			 } while (option == 'Y' || option == 'y');
			 break;




	 }



	} while (choice != 5);
	
	
}