#include <iostream>

using namespace std;

int main()
{
	//while (true)
	//{
	//	// Note, the program will never exit this.

	//	// Therefore, anything below is never executed.
	//}

	int ctr = 0;
	while (ctr <= 1000)
	{
		cout << ctr << " ";
		ctr++;
	}

	string password = "secret";
	string guess = "";
	do
	{
		cout << "\nEnter password: ";
		cin >> guess;
	} while (password != guess);

	cout << "Access granted..." << endl;

	for (int i = 0; i <= 10; i++)
	{
		cout << i << endl;
	}

	//for (;;)
	//{
	//	// As with the above while (true) statement {} => to infinity and beyond...
	//}

	return 0;
}