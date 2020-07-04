# =============================================================================
# Classes: Constructors Using kwargs with Defaults
# =============================================================================
class Asset:
    def __init__(self, **kwargs):
        self._type = kwargs['type'] if 'type' in kwargs else 'Index'
        self._symbol = kwargs['symbol'] if 'symbol' in kwargs else 'SP500'
        self._close = kwargs['close'] if 'close' in kwargs else 0.00

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
    print_asset(Asset())

if __name__ == '__main__': main()