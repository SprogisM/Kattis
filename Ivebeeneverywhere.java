import java.util.*;

public class Ivebeeneverywhere{

    public static void main(String[] args){
        HashMap<String, Integer> hashMap = new HashMap<String, Integer>();
        Scanner scan = new Scanner(System.in);

        int cases = scan.nextInt();
        for(int i = 0; i < cases; i++){
            int trips = scan.nextInt();

            scan.nextLine();
            for(int j = 0; j < trips; j++){
                hashMap.putIfAbsent(scan.nextLine(), 0);
            }
            System.out.println(hashMap.size());
            hashMap.clear();
        }
    }

}