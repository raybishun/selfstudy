# =============================================================================
# Classes: Constructors
# =============================================================================
class Asset:
    def __init__(self, type, symbol, close):
        self._type = type
        self._symbol = symbol
        self._close = close

    def type(self):
        return self._type
    
    def symbol(self):
        return self._symbol

    def close(self):
        return self._close
    
def print_asset(o):
    if not isinstance(o, Asset):
        raise TypeError('print_asset(): requires an Asset')
    print(f'TYPE: {o.type()} \tSYMBOL: {o.symbol()} \tCLOSING_PRICE: {o.close()}')

def main():
    msft = Asset('Stock', 'MSFT', 170.23)
    spx = Asset('Option', 'SPX', 3225.52)
    print_asset(msft)
    print_asset(spx)
    print_asset(Asset('Futures', 'ES', 3227.00))

if __name__ == '__main__': main()