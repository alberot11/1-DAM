import java.util.Scanner;

public class CircleArea
{
    public static final float PI = 3.14159f;
    public static void main (String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the radius of the circle: ");
        float radius = sc.nextFloat();
        float area = PI * radius * radius;
        System.out.printf("The area of the circle is: %.2f", area);
    }
}

