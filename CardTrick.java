import java.util.*;

public class CardTrick{

    public static void main(String[] main){
        Scanner scan = new Scanner(System.in);
        int cases = scan.nextInt();

        for(int i = 0; i < cases; i++){
            int cards = scan.nextInt();
            LinkedList<Integer> deck = new LinkedList<Integer>();

            for(int j = cards; j > 0; j--){
                deck.add(0, j);

                for(int k = 0; k < j; k++){
                    deck.add(0, deck.pollLast());
                }
            }
            for(int j : deck)
                System.out.print(j + " ");

            System.out.println("");
        }
    }

}