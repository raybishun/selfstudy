#include <iostream>
#include <string>

using namespace std;

// Variables
int wholeNumber     = 618;
float realNumber1   = 1.618;
double realNumber2  = 1.618;
bool isTrueOrFalse  = true;
string greeting     = " says, Hello World!";
string name         = "";

// Constants
const int fib       = 618;

int main()
{
    cout << "Enter name: ";

    cin >> name;

    cout << name << greeting << endl;

    return 0;

    // system("pause");
}