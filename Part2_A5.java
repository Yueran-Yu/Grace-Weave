package exercise05;

import java.util.Scanner;

public class Part2_A5 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter triangle size: ");
		int size = Integer.parseInt(input.nextLine());

		int i = 0;
		//上半截循环限制条件
		for (i = 1; i <= size; i++) {
			for (int j = 1; j <= i; j++)
				System.out.print("*");
			System.out.println();
		}
		
		/*主要是看的更加清晰 一目了然*/
		
		//下半截循环限制条件
		for (i = size + 1; i <= 2 * size - 1; i++) {
			for (int k = 2 * size - i; k > 0; k--)
				System.out.print("*");
			System.out.println();
		}
	}
}
