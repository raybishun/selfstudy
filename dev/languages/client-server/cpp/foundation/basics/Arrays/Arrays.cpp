#include <iostream>

using namespace std;

void SingleDimensionalArrays()
{
    string workDays[5] = { "Mon", "Tue", "Wed", "Thu", "Fri" };

    // Two options to find the length of an array
    // ------------------------------------------------------------------------
    // int workDaysLength = sizeof(workDays) / sizeof(workDays[0]);

    // This second option uses a pointer hack
    int workDaysLength = *(&workDays + 1) - workDays;

    for (int i = 0; i < workDaysLength; i++)
    {
        cout << workDays[i] << endl;
    }
}

void MultiDimensionalArrays()
{
    int nums[3][4] = {
        {1, 3, 5, 7},
        {2, 4, 6, 8},
        {101, 103, 105, 107}
    };

    cout << "103 is here: " << nums[2][1] << endl;

    for (int r = 0; r <= 2; r++)
    {
        for (int c = 0; c <= 3; c++)
        {
            cout << nums[r][c] << " ";
        }

        cout << endl;
    }
}

int main()
{
    // SingleDimensionalArrays();
    MultiDimensionalArrays();

    return 0;
}
