import java.util.*;
import java.lang.Math;
import java.lang.Character;

public class Pot{

    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int cases = scan.nextInt();
        long sum = 0;

        for(int i = 0; i < cases; i++){
            String foo = scan.next();
            if(foo.length() > 1){
                int power = Character.getNumericValue(foo.charAt(foo.length()-1));
                int number = Integer.parseInt(foo.substring(0, foo.length()-1));
                sum += Math.pow(number, power);
            } else {
                sum += 1;
            }
        }
        System.out.println(sum);
    }

}