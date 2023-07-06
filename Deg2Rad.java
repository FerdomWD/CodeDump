import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter your angle: ");
        int degrees = scanner.nextInt();

        double radians = degrees * (3.14 / 180);
        double roundedNumber = Math.round(radians);
        String output = String.valueOf(roundedNumber);

        System.out.println("Radians: " + output);

        scanner.close();
    }
}