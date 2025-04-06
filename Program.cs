using System;  //引入System命名空间
namespace consoleapp  //定义命名空间consoleapp
{
    class Demo  //定义Demo类
	{
        void print(int i)
		{
			Console.WriteLine("打印int类型的数据：{0}",i);
		}
		void print(double d)
		{
			Console.WriteLine("打印double类型的数据：{0}",d);
		}
		void print(string s)
		{
			Console.WriteLine("打印string类型的数据：{0}",s);
		}
		static void Main(string[] args)
		{
			Demo p = new Demo();
			p.print(111);
			p.print("hello world");
			p.print(3.1415926);
		}
	}
}