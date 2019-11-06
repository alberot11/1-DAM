import java.util.Scanner;

public class FormattedDate
{

    public static void main (String[] args) 
    {
        Scanner sc=new Scanner(System.in);
        System.out.print("enter your day, month and year of birth: ");
        int day=sc.nextInt();
        int month=sc.nextInt();
        int year=sc.nextInt();
        System.out.printf("%02d/%02d/%d", day, month, year);
    }
}

