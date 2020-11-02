import java.util.*;

public class Coldputerscience{

    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);

        int cases = scan.nextInt();
        int temp;
        int coldDays = 0;
        for(int i = 0; i < cases; i++){
            temp = scan.nextInt();
            if(temp < 0)
                coldDays++;
        }

        System.out.println(coldDays);
    }
}