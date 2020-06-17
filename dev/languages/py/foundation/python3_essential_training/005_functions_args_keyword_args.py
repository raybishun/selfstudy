# =============================================================================
# Functions: KeyWord Arguments
# =============================================================================
print('\x1b[2J')

def main():
   nums(one = 1)
   print()
   
   nums(one = 1, two = 2)
   print()

   nums(one = 1, two = 2, three = 3)
   print()

   nums(bmw = '540ix', mb = 'sl 500', honda = 'accord')
   print()

   x = dict(bmw = '540ix', mb = 'sl 500', honda = 'accord')
   nums(**x)

def nums(**kwargs):
   if len(kwargs):
      for k in kwargs:
         print('Value of {} is {}'.format(k, kwargs[k])) 
   else:
      print('done.')

if __name__ == '__main__': main()