#Algorithm
************
>**Reverse_Integer**
```java
package leetCode;

import java.util.Scanner;

public class Reverse_Integer {
	public static void main(String[] args) {
		Reverse_Integer test = new Reverse_Integer();
		System.out.println(test.reverse(1534236469));

	}

	public int reverse(int x) {
		int result = 0;
		String s = String.valueOf(x);
		String[] arr = s.split("");

		StringBuilder sb = new StringBuilder();
		if (x > Integer.MAX_VALUE || x < Integer.MIN_VALUE) {
			result = 0;
		}

		try {
			if (arr[0].equals("-")) {
				sb.append(arr[0]);
				for (int i = arr.length - 1; i >= 1; i--) {
					sb.append(arr[i]);
					result = Integer.parseInt(sb.toString());
				}

			} else {
				for (int i = arr.length - 1; i >= 0; i--) {
					sb.append(arr[i]);
					result = Integer.parseInt(sb.toString());
				}
			}

		} catch (NumberFormatException ignored) {
			result = 0;
		}

		return result;
	}
}
```
#Review
**********
**Reading Digest：**
>01 "A little learning is a dangerous thing."

>02 "True expertise may take a lifetime."

>03 "Excellence in any department can be attained only by the labor of a lifetime."

>04 "Prof. K. Anders Ericssion puts it,"In most domains it's remarkable how much time even the most talented individuals need in order to reach the highest levels of performance."

>05 "Get interested in programming, and do some because it is fun. Make sure that it keeps being enough fun so that you will be willing to put in your ten years/10,000 hours."

>06 "The most effective learning requires a well-defined task with an opportunities for repetition and corrections of errors."

>07 "Book learning alone won't enough."

#Tip
**********
**A little personal thought**
>This is my day managed to learn how to use 'Markdown'. I have browsed several web pages to find how to use Markdown, but almost no article showed the complete process to follow. So I changed to search the video, and then I found What I want. Yesterday, I finally joined the slack successfully, I really don't know what to do without others' help. But I eventually figured out this problem by myself, the difference is I spent a little more time to join in it. If someone teach me how to do, I will quickly enter and save some time.

* **Tip: how to use hashMap to traverse（4 ways）**
```java
Map <String,Integer> map = new hashMap<>();

//将元素添加到容器map中
map.put("apple",1);
map.put("bear",2);
map.put("curry",3);
map.put("rose",4);

//①普通遍历方法，通过 Map.keySet遍历key和value
for(String key : map.keySet()){
    System.out.printf("Key = %s Value = %d", key, map.get(key));
}

//②通过Map.entrySet遍历，使用iterator遍历key和value
Iterator<Map.Entry<String,Integer>> it = map.entrySet().iterator(); 
    while(it.hasNext()){
	Map.Entry<String, Integer> entry = it.next();
	System.out.printf("Key = %s Value = %d",entry.getKey(),entry.getValue());
}

//③通过Map.entrySet遍历key和value，这种便利方法通常是很大数据容量的时候使用
for(Map.Entry<String,Integer> entry : map.entrySet()){
    System.out.printf("Key = %s Value = %d",entry.getKey(),entry.getValue());
}

//④通过Map.values()遍历所有 value，但不能遍历 key
for(Integer v : map.values()){
	System.out.printf("Value = %d", v);
}
```

#Share
***************
* 01 on the spot 到现场
>例句1：Twenty miniutes after calling the emergency ambulance，medical care workers arrived <u>on the spot</u>.

* 02 go to court 上法庭，
     go to hosptial 去看病（表示功能时，不加the）
	 settle sth. out of court (庭外)私了
	> 
* 03 be/feel compelled to do不得不做(来自外界的压力)
     be/feel impelled to do(来自内内心的良知驱动)
>例句1：President Nixon felt compelled to resign.
>例句2：He felt impelled to investigate further.
* 04 claim to have done... 动词不定式+完成时：强调该事情已经发生过了
>例句1：I'm sorry to have kept you waiting.
 例句2：For the description given by people who claimed to have seen the puma were extraordinary similar.
* 05 prove(to be) + ajd./n.  被证明是... 此处，prove为系动词
>例句1：His injury proved (to be) fatal.
 例句2：The operation proved (to be)a success.
