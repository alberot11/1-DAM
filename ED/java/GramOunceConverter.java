import java.util.Scanner;

public class GramOunceConverter
{
    public static final float CONVERSOR = 28.3495f;
    public static void main (String[] args) 
    {
        Scanner sc=new Scanner(System.in);
        int grams;
        float ounces;
        System.out.print ("Enter the weight in grams: ");
        grams = sc.nextInt();
        ounces= grams/CONVERSOR;
        System.out.printf ("%d grams = %.3f ounces", grams, ounces);
    }
}

