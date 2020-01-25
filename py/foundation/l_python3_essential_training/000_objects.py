# =============================================================================
# Objects
# =============================================================================
class Car:
    make = 'BMW'
    model = '540i xDrive'

    def get_make(self):
        print(self.make)
    
    def get_model(self):
        print(self.model)

def main():
    car = Car()
    car.get_make()
    car.get_model()

if __name__ == '__main__': main()