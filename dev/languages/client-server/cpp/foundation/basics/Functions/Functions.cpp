#include <iostream>

using namespace std;

float ConvertCelsiusToFahrenheit(int c)
{
    return (9.0 * c / 5.0) + 32;
}

int main()
{
    float c;

    cout << "Enter temperature in Celsius: ";
    cin >> c;

    cout << c << " Celsius is " << ConvertCelsiusToFahrenheit(c) << " Fahrenheit." << endl;

    return 0;
}