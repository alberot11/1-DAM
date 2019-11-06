import java.util.Scanner;

public class NumbersStrings
{

    public static void main (String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        String stringNumber1, stringNumber2, stringNumber3, stringNumber4;
        int n1, n2;
        System.out.println("Enter 4 numbers:");
        stringNumber1 = sc.nextLine();
        stringNumber2 = sc.nextLine();
        stringNumber3 = sc.nextLine();
        stringNumber4 = sc.nextLine();
        n1= Integer.parseInt(stringNumber1+stringNumber2);
        n2= Integer.parseInt(stringNumber3+stringNumber4);
        System.out.println("result= " + (n1+n2));
    }
}

