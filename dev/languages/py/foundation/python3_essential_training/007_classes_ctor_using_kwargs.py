# =============================================================================
# Classes: Constructors Using kwargs
# =============================================================================
class Asset:
    def __init__(self, **kwargs):
        self._type = kwargs['type']
        self._symbol = kwargs['symbol']
        self._close = kwargs['close']

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
    msft = Asset(type='Stock', symbol='MSFT', close=170.23)
    spx = Asset(type='Option', symbol='SPX', close=3225.52)
    print_asset(msft)
    print_asset(spx)
    print_asset(Asset(type='Futures', symbol='ES', close=3227.00))

if __name__ == '__main__': main()