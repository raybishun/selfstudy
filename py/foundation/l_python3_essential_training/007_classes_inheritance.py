# =============================================================================
# Classes: Inheritance
# =============================================================================

# Base Class
class Asset:
    def __init__(self, **kwargs):
        if 'type' in kwargs: self._type = kwargs['type']
        if 'symbol' in kwargs: self._symbol = kwargs['symbol']
        if 'close' in kwargs: self._close = kwargs['close']

    def type(self, t=None):
        if t: self._type = t
        try: return self._type
        except AttributeError: return None
    
    def symbol(self, s=None):
        if s: self._symbol = s
        try: return self._symbol
        except AttributeError: return None

    def close(self, c=None):
        if c: self._close = c
        try: return self._close
        except AttributeError: return None

    def __str__(self):
        return f'{self.type()}, {self.symbol()}, {self.close()}'

# Inherit from Base Class
class Stock(Asset):
    def __init__(self, **kwargs):
        self._type = "Stock"
        if 'type' in kwargs: del kwargs['type']
        super().__init__(**kwargs)

class Futures(Asset):
    def __init__(self, **kwargs):
        self._type = "Futures"
        if 'type' in kwargs: del kwargs['type']
        super().__init__(**kwargs)

    def exchange(self, e):
        print(f'{self.symbol()} trades on the {e}.')

def main():
    msft = Stock(symbol = 'msft', close = 180.12)
    print(msft)

    es = Futures(symbol = 'ES', close = 3293.25)
    es.exchange('CME')
    print(es)

if __name__ == '__main__': main()