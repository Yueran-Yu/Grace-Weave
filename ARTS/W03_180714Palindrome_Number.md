## Algorithm

**Reverse_Integer （第二种方法）**
```java
package leetCode;

public class Reverse_Integer2 {

	public static void main(String[] args) {

		System.out.println(Reverse_Integer2.reverse(-2147483647));
	}

	public static int reverse(int x) {
		long result = 0;

		while (x != 0) {
			result = result * 10 + x % 10;
			x = x / 10;
			if (result > Integer.MAX_VALUE || result < Integer.MIN_VALUE)
				result = 0;
		}
		return (int)result;
	}
}
```

**Palindrome Number**
```java
package leetCode;

public class Parlindrome_Number {

	public static void main(String[] args) {

		System.out.println(Parlindrome_Number.isPalindrome(121));
	}

	static boolean isPalindrome(int x) {
		int pa = x; // declare a value pa to store the value of x
		if (x < 0 || (x!=0 &&x % 10 == 0)) {
			return false;
		}
		int result = 0;
		while (x > 0) {
			result = result * 10 + x % 10;
			x /= 10;
		}

		return result == pa;
	}
}
```

## Review
##### Digest of   \<How To Ask Questions The Smart Way\> Just for reminding myself
>01 Hackers actually  like hard problems and good, thought-provking questions about them.

>02 Good questions help us develop our understanding, and often reveal problems we might not have noticed or thought about otherwise.

> 03 Before You Ask:
1 Try to find an answer by searching the archives of the forum or mailing list you plan to post to.
2 Try to find an answer by searching the Web.
3 Try to find an answer by reading the manual.
4 Try to find an answer by reading a FAQ.
5 Try to find an answer by inspection or experimention.
6 Try to find an answer by asking a skilled friend.
7 If you're a prgorammer, try to find an answer by reading the source code.

>04 Hasty-sounding questions get hasty answers, or none ant all.


## Tips
**Java 中 = 和 += 的区别**
```java

public class AddEqual {

	public static void main(String[] args) {
		int i = 234;
		double d = 43.4;
		
		//i = d + i; 用“=” 是会把后面的数值赋值到前面的变量时检测类型是否相同，非自动强制转换，
		//如果是高精度到低精度的计算，程序会报错，会告诉程序员lose of data

		 i += d;  //这条计算,+= 会将后面的数值自动强制转换为前面的类型，然后在那块内存上直接修改数值；
		
		System.out.println(i);
	}
}
```


## Share
>最近根据D瓜哥的学习路线建议在看HTML&CSS的书和视频，从而总结出在看书和教学视频上的一些优缺点，在此非常非常非常感谢他的建议！以下浅谈一点自己关于书和视频的学习感受。

>书的优点：给的例子比较多，覆盖相对于视频会更全面一点。另外，书会对单词缩写进行解释，比如```<ol><ul>```为啥是列表，其英文单词是，ordered list，unordered list，```<tr><th>``` 分别为 table row，table head，读者就知道为啥这些缩写是这么组合的了。

>书的缺点：
01 没法形成对 js，css，html一个整体框架的大致概念。看视频教程老师会给出点解释，不至于像看书看得有点无头无脑。知识点比较零散，缺少了老师的解释，有时候不知道一个知识点运用的具体原因，不能将知识点和知识点之间相互打通。
02 书如果比较旧，有的东西也许现在都不怎么用了，没有被剔除，会浪费不必要的学习精力。

>视频优点：
01 视频有老师自己的系统总结，比如‘XX学院’的HTML入门教程，老师能将内容以表格的形式系统整理在一个文档中，复习的时候也会一目了然。
02 老师会延伸拓展一点js和CSS的内容，有利于学生对js和css有个预告认知，对于js和css即将如何与html结合使用，有个大概的了解。

>视频缺点：举的例子可能没有书中全面，有些知识点也没有覆盖。当然作为入门视频，内容也不可能很多的。

