#include <iostream>

using namespace std;

int main()
{
	double goldenRatio = 1.618;
	
	if (goldenRatio > 1)
	{
		// Do something...
	}
	else if(goldenRatio < 1)
	{
		// Do something...
	}
	else
	{
		// Do something...
	}

	// Switch requires an integral or enum type
	int only_an_integral_or_enum_type = 1;

	switch (only_an_integral_or_enum_type)
	{
	case 1:
		// Do something...
		break;
	case 2:
		// Do something...
		break;
	default:
		break;
	}

    return 0;
}