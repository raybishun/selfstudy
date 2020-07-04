#include <iostream>

using namespace std;

int main()
{
    int myInt = 618;

    // '&myInt' returns the 32 or 64-bit (hexadecimal) memory address
    //  that was 'dynamically' allocated to the myInt variable
    cout << &myInt << endl;

    // A pointer is used to store the 'memory address' of myInt
    // int* denotes a pointer
    int* myIntPtr;
    myIntPtr = &myInt;
    cout << myIntPtr << endl;

    return 0;

    system("pause");
}