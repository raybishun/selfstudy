# =============================================================================
# Classes: Intro
# =============================================================================
class Car:
    make = 'BMW'
    model = '540i xDrive'

    # 'self' appears to be similar to 'this' in C#, however, 
    # 'self' is not a keyword, you can use anything you want, 
    # but using 'self' is best practice
    def get_make(self):
        print(self.make)
    
    def get_model(self):
        print(self.model)

def main():
    car = Car()
    car.get_make()
    car.get_model()

if __name__ == '__main__': main()