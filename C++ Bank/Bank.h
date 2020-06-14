#pragma once
#include <iostream>
#include <string>
#include <stdio.h>
#include <fstream>
#include <cmath>

using namespace std;

struct Accountholder
{
	string AccNumber;
	string ClientName;
	string Nip;
	float Balance = 0;
};

void DisplayTitle(string anyTitle)
{
	for (short i = 0; i < anyTitle.length(); i++)
	{
		anyTitle[i] = toupper(anyTitle[i]);
	}
	cout << "\t\t" << anyTitle << "\n\t\t";
	for (short i = 0; i < anyTitle.length(); i++)
	{
		cout << "-";
	}
	cout << "\n\n";
}

void DisplaysubTitle(string subTitle)
{
	for (short i = 0; i < subTitle.length(); i++)
	{
		subTitle[i] = toupper(subTitle[i]);
	}
	cout << "\t\t" << subTitle << "\n\t\t";
	for (short i = 0; i < subTitle.length(); i++)
	{
		cout << "-";
	}
	cout << "\n\n";
}

char readChoice()
{
	string choice;
	do {
		cout << "\nEnter your choice(1-4): ";
		cin >> choice;
		choice = choice.at(0);
	} while (choice.at(0) != '1' && choice.at(0) != '2' && choice.at(0) != '3');
	return choice[0];
}

void displayMenu()
{
	cout << endl;
	cout << "\t1 - Deposit" << endl;
	cout << "\t2 - Withdrawal" << endl;
	cout << "\t3 - Consult" << endl;

}

bool validateAccObjInit(Accountholder anyAccounts)
{
	bool isAccInitSuccessful = false;
	if (!anyAccounts.AccNumber.empty() &&
		!anyAccounts.ClientName.empty() &&
		!anyAccounts.Nip.empty())
		isAccInitSuccessful = true;
	return isAccInitSuccessful;
}

Accountholder authenticateClient(char recordsFile[], Accountholder custAccounts[], short nbRecords) {
	string AccNumber, Nip, line;
	bool isValidAccNum = false, isValidPass = false;
	Accountholder clientAcc;
	do {
		cout << "\nEnter your Account Number : ";
		getline(cin, AccNumber);
		for (short i = 0; i < nbRecords; i++)
		{
			if (custAccounts[i].AccNumber == AccNumber)
			{
				isValidAccNum = true;
				cout << "\n\t Welcome " << custAccounts[i].ClientName;
				do {
					cout << "\nEnter your Nip : ";
					getline(cin, Nip);
					if (Nip == custAccounts[i].Nip)
					{
						isValidPass = true;
						clientAcc = custAccounts[i];
						break;
					}
				} while (!isValidPass);
			}
		}
	} while (!isValidAccNum);
	return clientAcc;
}

short initAccounts(Accountholder custAccounts[], char recordsFile[]) {
	bool isInitSuccessful = true;
	fstream recordFileObj;
	string line;
	recordFileObj.open(recordsFile, ios::in);
	short counter = 0, initCounter = 0, nbRecords = 0;
	Accountholder custAcc;
	while (!recordFileObj.eof())
	{
		if (initCounter != counter)
		{
			isInitSuccessful = false;
			break;
		}
		counter++;
		getline(recordFileObj, line);
		switch (initCounter)
		{
		case 0:
			custAcc.AccNumber = line;
			initCounter++;
			break;
		case 1:
			custAcc.ClientName = line;
			initCounter++;
			break;
		case 2:
			custAcc.Nip = line;
			initCounter++;
			break;
		case 3:
			//			custAcc.Balance = stof(line);
			initCounter++;
			break;
		}
		if (initCounter % 4 == 0 && validateAccObjInit(custAcc))
		{
			custAccounts[(counter / 4) - 1] = custAcc;
			custAcc.AccNumber = "";
			custAcc.ClientName = "";
			custAcc.Nip = "";
			custAcc.Balance = 0;
			initCounter = 0;
		}
	}
	recordFileObj.close();
	return counter / 4;
}

void displayAccountInfo(Accountholder custAccount)
{
	cout << "\nACCOUNT INFORMATION" << endl;
	cout << "\n\tAccount Number : " << custAccount.AccNumber;
	cout << "\n\tClient : " << custAccount.ClientName;
	cout << "\n\tNip : " << custAccount.Nip;
	cout << "\n\tBalance $ : " << custAccount.Balance << endl;
}

void saveAccounts(Accountholder custAccounts[], char recordsFile[], short nbAccounts)
{
	fstream recordFileObj;
	string line;
	recordFileObj.open(recordsFile, ios::out);
	for (short i = 0; i < nbAccounts; i++)
	{
		recordFileObj << custAccounts[i].AccNumber << endl;
		recordFileObj << custAccounts[i].ClientName << endl;
		recordFileObj << custAccounts[i].Nip << endl;
		recordFileObj << custAccounts[i].Balance;
	}
	recordFileObj.close();
}

Accountholder withdraw(Accountholder custAcc)
{
	float amount;
	do {
		cout << "enter an amount to withdraw($20-$500) : ";
		cin >> amount;
	} while (fmod(amount, 20) != 0 || (amount > 500) || (amount < 20) || amount > custAcc.Balance);
	custAcc.Balance -= amount;
	return custAcc;
}

void updateAccount(Accountholder custAccounts[], short nbAcc, Accountholder custAcc)
{
	for (short i = 0; i < nbAcc; i++)
	{
		if (custAccounts[i].AccNumber == custAcc.AccNumber)
		{
			custAccounts[i].Balance = custAcc.Balance;
		}
	}
}

Accountholder deposit(Accountholder custAcc)
{
	float amount;
	do {
		cout << "enter an amount to deposit($2-$20,000) : ";
		cin >> amount;
	} while ((amount > 20000) || (amount < 2));
	custAcc.Balance += amount;
	return custAcc;
}
