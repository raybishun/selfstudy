#include <iostream>

using namespace std;

struct Equity
{
    string Symbol, Name;
    float Last, Volume;
    
}Stock, Future;


int main()
{
    Stock.Symbol = "MSFT";
    Stock.Name = "Microsoft";
    Stock.Last = 206.26;

    Future.Symbol = "ES";
    Future.Name = "S&P 500 E-mini Contract";
    Future.Last = 3115.50;

    cout << Future.Symbol << ": " << Future.Last;

    return 0;
}