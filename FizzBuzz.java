import java.util.*;

public class FizzBuzz {

    public static void main(String [] args){
        Scanner scan = new Scanner(System.in);

        int X = scan.nextInt();
        int Y = scan.nextInt();
        int N = scan.nextInt();

        for(int i = 1; i <= N; i++){
            String out = "";

            if( i % X == 0)
                out += "Fizz";
            if( i % Y == 0)
                out += "Buzz";
            
            if(out.length() != 0){
                System.out.println(out);
            } else {
                System.out.println(i);
            }
        }

        scan.close();
    }
}