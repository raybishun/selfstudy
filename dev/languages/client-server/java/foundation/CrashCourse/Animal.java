import java.util.Scanner; // accept user input

import javax.lang.model.util.ElementScanner6;

import java.util.*; // imports everything under util

public class Animal {
    // final classes can't be subclassed
    // final methods can't be overridden
    public static final double FAVNUMBER = 1.6180;

    private String name;
    private int weight; // -2^31 to 2^31 - 1
    private boolean hasOwner = false;
    private byte age; // -128 to 127
    private long uniqueID; // -2^63 to 2^63
    private char favoriteChar; // Unsigned ints that represent UTF16 for (single) characters
    private double speed; // 64-bit number
    private float height; // 32-bit number

    protected static int numberOfAnimals = 0; // can only be accessed by other code in this package

    static Scanner userInput = new Scanner(System.in);

    public Animal(){
        // super(); // call whatever the super class is for this class (however, in this case, Animal is the super class)

        numberOfAnimals++;

        int sumOfNumbers = 5 + 1;
        System.out.println("5 + 1 = " + sumOfNumbers);

        int diffOfNumbers = 5 - 1;
        System.out.println("5 - 1 = " + diffOfNumbers);

        int multOfNumbers = 5 * 1;
        System.out.println("5 * 1 = " + multOfNumbers);

        int divOfNumbers = 5 / 1;
        System.out.println("5 / 1 = " + divOfNumbers);

        // the remainder
        int modOfNumbers = 5 % 3;
        System.out.println("5 % 3 = " + modOfNumbers);

        System.out.print("Enter name: \n");

        // hasNextIn, hasNextFloat, hasNextDouble, hasNextBoolean, hasNextByte
        // nextInt, nextFloat, nextDouble, etc...
        if(userInput.hasNextLine())
        {
            this.setName(userInput.nextLine());

        }

        this.setFavoriteColor();
        this.setUniqueID();
    }

    protected static void countTo(int startingNumber){
        for(int i = startingNumber; i <= 100; i++){
            if(i == 90){
                continue;
            }
            System.out.println(i);
        }
    }

    protected static String printNumbers(int maxNumbers){
        int i = 1;
        while(i < maxNumbers / 2){
            System.out.println(i);
            i++;

            if(i == (maxNumbers / 2)){
                break;
            }
        }
        
        Animal.countTo(maxNumbers / 2);

        return "End of printNumbers";
    }

    protected static void guessMyNumber(){
        int number;
        do{
            System.out.println("Guess Number up to 100");
            while(!userInput.hasNextInt()){
                String numberEntered = userInput.next();
                System.out.printf("%s is not a number\n", numberEntered);
            }

            number = userInput.nextInt();
        }while(number != 50);
    }

    public String makeSound(){
        return "Grrr";
    }

    public void makeSound(Animal randAnimal){
        System.out.println("Animal says " + randAnimal.makeSound());
    }

    // Properties
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getWeight() {
        return weight;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public boolean isHasOwner() {
        return hasOwner;
    }

    public void setHasOwner(boolean hasOwner) {
        this.hasOwner = hasOwner;
    }

    public byte getAge() {
        return age;
    }

    public void setAge(byte age) {
        this.age = age;
    }

    public long getUniqueID() {
        return uniqueID;
    }

    public void setUniqueID(long uniqueID) {
        this.uniqueID = uniqueID;
        System.out.println("Unique ID set to: " + this.uniqueID);
    }

    public void setUniqueID() {
        long minNumber = 1;
        long maxNumber = 1000000;

        this.uniqueID = minNumber + (long) (Math.random() * ((maxNumber - minNumber) + 1));
        
        // Conversion examples
        String stringNumber = Long.toString(maxNumber);
        int numberString = Integer.parseInt(stringNumber);
    }

    public char getFavoriteChar() {
        return favoriteChar;
    }

    public void setFavoriteChar(char favoriteChar) {
        this.favoriteChar = favoriteChar;
    }

    public void setFavoriteChar() {
        int randomNumber = (int)(Math.random() * 126) + 1;

        this.favoriteChar = (char)randomNumber;

        if(randomNumber == 32) {
            System.out.println("Favorite character set to Space");
        } else if(randomNumber == 10) {
            System.out.println("Favorite character set to Newline");
        }
        else{
            System.out.println("Favorite character set to " + this.FavoriteChar);        
        }

        // Logical operators
        if((randomNumber > 97) && (randomNumber < 122)){
            System.out.println("Favorite character is a lowercase letter.");
        }

        if( ((randomNumber > 97) && (randomNumber < 122)) || ((randomNumber > 64) && (randomNumber < 91)) ){
            System.out.println("Favorite character is a letter.");
        }

        int whichIsBigger = (50 > randomNumber) ? 50 : randomNumber;

        switch(randomNumber){
            case 8: 
                system.out.println("Fav char set to backspace");
                break;
            case 10: 
            case 11: 
            case 12: 
                system.out.println("Fav char set between 10 - 12");
                break;
            default:
                system.out.println("Catch all...");
                break;
        }
    }

    public double getSpeed() {
        return speed;
    }

    public void setSpeed(double speed) {
        this.speed = speed;
    }

    public float getHeight() {
        return height;
    }

    public void setHeight(float height) {
        this.height = height;
    }

    public static void main(String[] args) {
        Animal theAnimal = new Animal();

        int[] favoriteNumbers = new int[20];
        favoriteNumbers[0] = 100;

        String[] stringArray = {"Random", "Words", "Here"};

        for(String work: stringArray){
            System.out.println(word);            
        }

        // [row][column][groups, that is, how many of these]
        String[][][] arrayName = {
            {"1", "3", "5", "7"},
            {"2", "4", "6", "8"},
            {"101", "103", "105", "107"}
        };

        // Copying an array
        string[] cloneOfArray = Arrays.copyOf(stringArray, 3);

        // Print an array
        System.out.println(Arrays.toString(cloneOfArray));

        // Search array
        System.out.println(Arrays.binarySearch(cloneOfArray, "Random"));
    }
}