# =============================================================================
# Classes: Methods
# =============================================================================
class Asset:
    def __init__(self, **kwargs):
        self._type = kwargs['type'] if 'type' in kwargs else 'Index'
        self._symbol = kwargs['symbol'] if 'symbol' in kwargs else 'SP500'
        self._close = kwargs['close'] if 'close' in kwargs else 0.00

    def type(self, t=None):
        if t: self._type = t
        return self._type
    
    def symbol(self, s=None):
        if s: self._symbol = s
        return self._symbol

    def close(self, c=None):
        if c: self._close = c
        return self._close

    def __str__(self):
        return f'{self.type()} \t{self.symbol()} \t{self.close()}'
    
def print_asset(o):
    if not isinstance(o, Asset):
        raise TypeError('print_asset(): requires an Asset')
    print(f'TYPE: {o.type()} \tSYMBOL: {o.symbol()} \tCLOSING_PRICE: {o.close()}')

def main():
    msft = Asset(type='Stock', symbol='MSFT', close=170.23)
    spx = Asset(type='Option', symbol='SPX', close=3225.52)
    
    msft.close(200.00)

    print(msft)
    print(spx)

if __name__ == '__main__': main()