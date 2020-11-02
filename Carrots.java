import java.util.*;

public class Carrots{
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);

        int nrContestants = scan.nextInt();
        int nrPoints = scan.nextInt();
        scan.nextLine();

        for(int i = 0; i < nrContestants; i++)
            scan.nextLine();

        System.out.println(nrPoints);
        scan.close();

    }
}