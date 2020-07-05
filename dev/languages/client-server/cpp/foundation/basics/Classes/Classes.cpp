#include <iostream>

using namespace std;

class OrderTicket
{
public:
    string Symbol;
    float Limit;
    int Shares;

    float Buy(OrderTicket order)
    {
        return Balance = Balance - order.Limit * order.Shares;
    }

    float GetBalance()
    {
        return Balance;
    }

private:
    float Balance = 500000.00;
};


int main()
{
    OrderTicket myOrder;
    myOrder.Symbol = "MSFT";
    myOrder.Limit = 200;
    myOrder.Shares = 1000;
    
    myOrder.Buy(myOrder);
    
    cout << myOrder.GetBalance() << endl;

    return 0;
}