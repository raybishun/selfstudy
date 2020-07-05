import java.util.Scanner; // accept user input
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

    static Scanner userinput = new Scanner(System.in);

    public Animal(){
        super(); // call whatever the super class is for this class (however, in this case, Animal is the super class)
    }
}