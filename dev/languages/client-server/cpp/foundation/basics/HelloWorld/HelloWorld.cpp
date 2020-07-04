#include <string>
#include <iostream>

using namespace std;

int main()
{
    // 'string' requires both:
    //  using namespace std and 
    //  #include <string>
    string greeting = "Hello World!";
    string name = "";

    // 'cout' and 'cin' require both:
    //  using namespace std and 
    //  #include <string>
    cout << "Enter name: ";
    cin >> name;
    
    cout << "Hello World, from " << name << endl;

    return 0; 
}