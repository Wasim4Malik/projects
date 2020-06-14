#include "Bank.h"

void main()
{
	char choice;
	char custRecords[] = "Bank.txt";
	char Title[] = "Canada Trust";
	char subTitle[] = "Automatic Banking Machine";

	Accountholder clientAcc, custAccounts[200];

	short numRecords = initAccounts(custAccounts, custRecords);

	do {
		DisplayTitle(Title);
		DisplaysubTitle(subTitle);
		clientAcc = authenticateClient(custRecords, custAccounts, numRecords);
		displayMenu();
		choice = readChoice();
		switch (choice) {
		case '1':
			clientAcc = deposit(clientAcc);
			updateAccount(custAccounts, numRecords, clientAcc);
			saveAccounts(custAccounts, custRecords, numRecords);
			initAccounts(custAccounts, custRecords);
			displayAccountInfo(clientAcc);
			break;
		case '2':
			clientAcc = withdraw(clientAcc);
			updateAccount(custAccounts, numRecords, clientAcc);
			saveAccounts(custAccounts, custRecords, numRecords);
			initAccounts(custAccounts, custRecords);
			displayAccountInfo(clientAcc);
			break;
		case '3': displayAccountInfo(clientAcc);
			break;
		}
	} while (true);
	system("pause");
}
