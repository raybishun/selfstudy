# =============================================================================
# Functions: KeyWord Arguments (aka Named Arguments)
# =============================================================================
print('\x1b[2J')

def nums(**kwargs):
   if len(kwargs):
      for k in kwargs:
         print('Num {} is {}'.format(k, kwargs[k])) 
   else:
      print('done.')

def main():
   nums(One = 1, Two = 2, Three = 3)

if __name__ == '__main__': main()