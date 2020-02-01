# =============================================================================
# Structured Data - Dictionary (a hased key-value structure)
# =============================================================================
def main():
    users = {'parker': 'peter.parker@mcu.com', 
             'rogers': 'steve.rogers@mcu.com',
             'banner': 'bruce.banner@mcu.com',
             'wayne': 'bruce.wayne@dc.com',
             'jessica': 'jessica.alba@mcu.com'}
    print_dict(users)

    heros = dict(parker = 'peter.parker@mcu.com', 
             rogers = 'steve.rogers@mcu.com',
             banner = 'bruce.banner@mcu.com',
             wayne = 'bruce.wayne@dc.com',
             jessica = 'jessica.alba@mcu.com')

    heros['jessica'] = 'sue.storm@mcu.com'
    print('\t', heros['jessica'])

    heros['scarlett'] = 'scarlett.johansson'


    print('\t', {'scarlett' in heros})
    print('\t', 'found' if 'scarlett123' in heros else 'not found')
    print('\t', heros.get('scarlett123'))

    print_dict_kv_pair(heros)
    print_dict_keys(heros)
    print_dict_values(heros)

def print_dict(o):
    for x in o:
        print(f'{x}: {o[x]}')
    print()

def print_dict_kv_pair(o):
    for k, v in o.items():
        print(f'{k}: {v}')
    print()


def print_dict_keys(o):
    for k in o.keys(): 
        print(k)
    print()

def print_dict_values(o):
    for k in o.values(): 
        print(k)
    print()

if __name__ == '__main__': main()