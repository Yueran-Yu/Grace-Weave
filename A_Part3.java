package exercise03;
import java.util.Arrays;
public class A_Part3 {
	public static void main(String[] args) {
		int[] arr = new int[3];
		arr[0] = 2;
		arr[1] = 5;
		arr[2] = 9;
		System.out.println(arr);
		System.out.println(arr[2]);
		
		int temp = arr[2];
		arr[2] = arr[0];
		arr[0] = temp;
		System.out.println(Arrays.toString(arr));
		
		int[] arr1 = new int[arr.length*3]; 
		//注意：创建新数组长度的写法 int[] example = new int[length];
		//忘了怎么表示最后一个数组元素
		
		arr1[arr1.length-1] = arr[0] + arr[1] - arr[2];
		System.out.println(Arrays.toString(arr1));
	}
}
