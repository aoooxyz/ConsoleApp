using System;  //引入System命名空间
namespace consoleapp  //定义命名空间consoleapp
{
    class Demo  //定义Demo类
	{
        static void Main(string[] args) //主方法，程序的入口
		{
			Test test1 = new Test();  //创建Test类的实例对象test1
			test1.setStr("奈非天");  //调用test1的setStr()方法(赋值为"奈非天")
			Test.getStr();  //调用静态方法getStr()输出静态字段str
			Test test2 = new Test();  //创建Test类的实例对象test2
			test2.setStr("莉莉丝");  //调用test2的setStr()方法(赋值为"莉莉丝")
			Test.getStr();  //调用静态方法getStr()输出静态字段str
		}
	}
	public class Test  //定义Test类
	{
	    public static string str;  //定义一个静态字段str,所有Test类的实例共享这个变量
		public void setStr(string s)  //定义实例方法setStr，用于修改静态字段str的值
		{
		    str = s;  //直接修改静态字段str
		}
		public static void getStr()  //定义实例方法getStr，用于输出静态字段str的值
		{
		    Console.WriteLine(str);  //输出静态字段str的值
		}
	}
}